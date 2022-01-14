﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Dictionary<Socket, string> clientSocketList = new Dictionary<Socket, string>();//클라이언트 소켓을 관리하는 리스트, 소켓과 접속 아이디를 관리하자.

        ServerProgram multiServer;
        int serverPort;

        private void allClientSend(string message, string username, bool flag)
        {
            String curDate = DateTime.Now.ToString("yyyy.MM.dd. HH:mm:ss"); // 현재 날짜 받기

            String sendMsg;

            byte[] buffer = null;
            if (flag)
            {
                if (message.Equals("disConnect"))
                    sendMsg = username + " 님이 대화방을 나갔습니다.";
                else
                    sendMsg = "[ " + curDate + " ] " + username + " : " + message;

            }
            else
            {
                sendMsg = message;
            }

            multiServer.SendMessage(sendMsg);
        }

        private void displayMessage(string text)
        {
            if (txt_Message.InvokeRequired) //다른 쓰레드에서 실행되어 Invoke가 필요한 상태라면 
            {
                txt_Message.BeginInvoke(new MethodInvoker(delegate   ///델리게이트로 넘겨서 실행
                {
                    txt_Message.AppendText(text + Environment.NewLine);
                }));
            }
            else
                txt_Message.AppendText(text + Environment.NewLine);

        }

        private void button_Click(object sender, EventArgs ev)
        {
            button.Enabled = false;
            try
            {
                serverPort = Int32.Parse(txt_ServerPort.Text.ToString()); // 소켓 번호 설정
            }
            catch (FormatException e)
            {
                //textbox 에 숫자 외의 문자인 경우
                serverPort = 1004;
            }

            multiServer = new ServerProgram(serverPort);
            multiServer.OnConnect += clientConnected;
            multiServer.OnDisconnect += clientDisconncted;
            multiServer.OnReceive += clientReceive;
        }

        private void clientReceive(Socket sock, String msg)
        {
            int index = msg.IndexOf("$");
            String curDate = DateTime.Now.ToString("HH:mm:ss"); // 현재 날짜 받기
            String stCmd = "";
            String stData = "";
            String sendMsg = "";
            if (index > 0)
            {
                stCmd = msg.Substring(0, index); //$를 기준으로 앞 부분을 cmd로 
                stData = msg.Substring(index + 1);

            }
            if (stCmd.ToUpper() == "Login".ToUpper())
            {
                clientSocketList[sock] = stData; // Login 사용자명 셋팅
                sendMsg = "[ " + curDate + " ] " + stData + "님이 입장하셨습니다.";
            }
            else
            {
                sendMsg = "[ " + curDate + " ] " + stCmd + " : " + stData;
            }
            displayMessage(sendMsg);
            if (multiServer != null) multiServer.SendMessage(sendMsg);

        }

        private void clientDisconncted(Socket sock)
        {
            String userName;
            if (clientSocketList.ContainsKey(sock))
            {
                userName = clientSocketList[sock];
                allClientSend("disConnect", userName, true);
                clientSocketList.Remove(sock);
            }
        }

        private void clientConnected(Socket sock)
        {
            clientSocketList.Add(sock, "");
        }
    }
}
