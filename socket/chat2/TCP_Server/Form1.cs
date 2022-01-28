﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.Sockets; //TcpListener
using System.Net;
using System.Threading;
using System.IO;

//https://m.blog.naver.com/PostView.naver?isHttpsRedirect=true&blogId=beamteam&logNo=220024228074

namespace TCP_Server
{
    public partial class Form1 : Form
    {
        TcpListener _tcpListener;//tcp 클라이언트에서 연결을 수신
        bool _open_flag = false;
        Thread _thread_listner;
        Thread _thread_receive;
        NetworkStream _ntstream;
        StreamReader _streader;
        StreamWriter _stwriter;
        TcpClient _client;

        delegate void D_receive(string data);

        public Form1()
        {
            InitializeComponent();
        }

        private void bt_open_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_open_flag) //현재 접속중인지 확인
                {
                    _tcpListener = new TcpListener(IPAddress.Parse(tb_ip.Text), int.Parse(tb_port.Text));
                    _tcpListener.Start();// 연결요청 수신 시작
                    _open_flag = true;         //서버를 오픈하였기 때문에 오픈 플래그를 True로 변경
                    _thread_listner = new Thread(listner); //listner메서드 스레드로 생성
                    _thread_listner.Start();
                    tb_receive_text("서버가 시작되었습니다.\r\n");
                    bt_send.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                _open_flag = false;                                                                     //실패할경우 오픈이 취소되었음으로 플래그를 false로 변경
                MessageBox.Show(ex.ToString());     //오류 보고
            }
        }

        void listner()
        {
            try
            {
                if (_open_flag)                                                                         //현재 오픈중인지 아닌지 판단
                {
                    _client = _tcpListener.AcceptTcpClient();                                   //클라이언트로 부터 연결요청을 받는다. TcpClient 객체가 리턴되는데 이것으로 클라이언트와 데이터를 주고 받을 수 있다.
                    tb_receive_text("Client가 접속하였습니다\r\n");
                    create_stream();                                                              //접속한 Client로 create_stream메소드 실행
                }
                else
                {
                    tb_receive_text("서버가 열리지 않았습니다\r\n");
                }
            }
            catch (Exception ex)                                                                         //에러
            {
                _open_flag = false;                                                                     //실패할경우 오픈이 취소되었음으로 플래그를 false로 변경
                MessageBox.Show(ex.ToString());
            }
        }


        void tb_receive_text(string data)                                                 //텍스트박스에 텍스트 추가하는 메서드
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new D_receive(tb_receive_text), data);                         //델리게이트 관련 코드로 다음번에 간단히 다시 설명하겠습니다.
            }
            else
            {
                if (data != null)                                                         //data가 null이 아닐경우
                {
                    tb_receive.AppendText(data + "\r\n");                                 //텍스트박스에 데이터+개행문자 추가
                }
            }
        }

        void create_stream()
        {
            try
            {
                _ntstream = _client.GetStream();                                                         //접속한 Client에서 networkstream 추출???
                _client.ReceiveTimeout = 500;                                                            //Client의 ReceiveTimeout
                _streader = new StreamReader(_ntstream);                                                //추출한 networkstream으로 streamreader,writer 생성
                _stwriter = new StreamWriter(_ntstream);
                _thread_receive = new Thread(receive);                                                  //receive메서드 스레드로 생성
                _thread_receive.Start();                                                                //스레드 시작     
            }
            catch (Exception ex)                                                                        //에러
            {
                _open_flag = false;                                                                     //실패할경우 접속이 취소되었음으로 플래그를 false로 변경
                MessageBox.Show(ex.ToString());
            }
        }

        void receive()
        {
            try
            {
                while (_open_flag)                                                                         //현재 오픈중인지 아닌지 판단
                {
                    string _receive_data = _streader.ReadLine();                                           //streamreader의 한줄을 읽어들여 string 변수에 저장                              
                    if (_receive_data != null)                                                             //데이터가 null이 아니면
                    {
                        tb_receive_text(_receive_data);
                    }
                }

            }
            catch (IOException)                                                                           //IO에러 (Timeout에러도 이쪽으로 걸림)                  
            {
                if (_open_flag)                                                                           //현재 접속중인지 아닌지 체크
                {
                    _thread_receive = new Thread(receive);                                                //접속중일 경우 receive메서드를 이용한 스레드 다시생성
                    _thread_receive.Start();
                }                                                                                         //접속중이 아닐경우 자연스럽게 스레드 정지
            }
            catch (Exception ex)                                                                          //그 밖의 에러
            {
                _open_flag = false;

                tb_receive_text("클라이언트의 연결이 종료되었습니다\r\n다시 서버오픈을 시도합니다.\r\n");
                _tcpListener.Stop();
                bt_open_Click(null, null);
            }
        }

        private void bt_send_Click(object sender, EventArgs e)
        {
            try
            {
                if (_open_flag)                                                        //현재 접속중인지 아닌지 체크
                {
                    if (tb_writeline.Text != string.Empty)                                //전송할 내용이 담긴 TextBox가 비었는지 체크
                    {
                        tb_receive.AppendText(tb_ID.Text + " : " + tb_writeline.Text + "\r\n");
                        _stwriter.WriteLine(tb_ID.Text + " : " + tb_writeline.Text);                           //StreamWriter 버퍼에 텍스트박스 내용 저장
                        _stwriter.Flush();                                                //StreamWriter 버퍼 내용을 스트림으로 전달
                        tb_writeline.Text = null;
                    }
                }
            }
            catch (Exception ex)                                                           //에러
            {
                _open_flag = false;                                                    //접속이 취소되었음으로 플래그를 false로 변경

                MessageBox.Show(ex.ToString());                                           //에러 내용 보고

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) //formclosing 이벤트
        {
            if (_open_flag)
            {
                if (_ntstream.CanRead)
                {
                    _stwriter.WriteLine(tb_ID.Text + "의 연결이 끊어졌습니다. ");                           //StreamWriter 버퍼에 텍스트박스 내용 저장
                    _stwriter.Flush();
                    _ntstream.Close();
                }
                _open_flag = false;
            }
        }
    }
}
