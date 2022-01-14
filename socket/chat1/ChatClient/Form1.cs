﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.Sockets;
using System.Threading;

namespace ChatClient
{
    public partial class Form1 : Form
    {
        TcpClient clientSocket; // 소켓
        NetworkStream stream = default(NetworkStream);//??
        string stSendMessage = "";
        // 메시지는 개행으로 구분한다.
        private static char CR = (char)0x0D;
        private static char LF = (char)0x0A;
        bool bThreadExit = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bThreadExit = false;
            int Port = Int32.Parse(txt_Port.Text);
            clientSocket = new TcpClient();
            stream = default(NetworkStream);

            try
            {
                clientSocket.Connect(txt_ServerIP.Text, Port); // 접속 IP 및 포트
                stream = clientSocket.GetStream();//??
            }
            catch (Exception e2)
            {
                MessageBox.Show("서버가 실행중이 아닙니다.", "연결 실패!");
                return;
            }
            btnLogin.Enabled = false;
            txt_user.Enabled = false;

            byte[] buffer = Encoding.Unicode.GetBytes("Login$" + txt_user.Text + CR + LF);
            stream.Write(buffer, 0, buffer.Length);
            stream.Flush();

            Thread t_handler = new Thread(GetMessage);
            t_handler.IsBackground = true;//??
            t_handler.Start();
        }

        private void GetMessage()
        {
            while (!bThreadExit)
            {
                stream = clientSocket.GetStream();
                int BUFFERSIZE = clientSocket.ReceiveBufferSize;
                byte[] buffer = new byte[BUFFERSIZE];
                int bytes = stream.Read(buffer, 0, buffer.Length);
                string message = Encoding.Unicode.GetString(buffer, 0, bytes);
                DisplayText(message);
            }
        }

        private void DisplayText(string message)
        {
            if (rt_Message.InvokeRequired) //다른 쓰레드에서 실행되어 Invoke가 필요한 상태라면 
            {
                rt_Message.BeginInvoke(new MethodInvoker(delegate   ///델리게이트로 넘겨서 실행
                {
                    rt_Message.AppendText(message + Environment.NewLine);
                }));
            }
            else
                rt_Message.AppendText(message + Environment.NewLine);
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            byte[] buffer = Encoding.Unicode.GetBytes("exit" + CR + LF);
            stream.Write(buffer, 0, buffer.Length);
            stream.Flush();
            bThreadExit = true;
            Thread.Sleep(1000);

            Application.Exit();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            byte[] buffer = Encoding.Unicode.GetBytes(txt_user.Text + "$" + txt_message.Text + CR + LF);
            stream.Write(buffer, 0, buffer.Length);
            stream.Flush();
            txt_message.Text = "";
        }

        private void txt_message_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btn_Send_Click(sender, e);
        }
    }
}
