using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Sockets;

namespace Server
{
    internal class Client : SocketAsyncEventArgs
    {
        //메시지 개행으로 구분
        private static char CR = (char)0x0D;
        private static char LF = (char)0X0A;
        private Socket socket;

        //메시지 모으기 위한 버퍼
        private StringBuilder sb = new StringBuilder();
        private IPEndPoint remoteAddr;//네트워크 엔드포인트를 IP와 포트번호로 나타냄

        public delegate void ClientReceiveHandler(Socket sockt, String msg); //수신 메시지 이벤트를 위한 델리게이트
        public event ClientReceiveHandler OnReceive;
        public delegate void ClientDisconnectHandler(Socket sock);
        public event ClientDisconnectHandler OnDisconnect;

        public Client(Socket socket)
        {
            try
            {
                this.socket = socket;
                // 메모리 버퍼를 초기화 한다. 크기는 1024이다
                base.SetBuffer(new byte[1024], 0, 1024); // base 부모클래스의 생성자를 이용할 때 사용
                base.UserToken = socket;

                base.Completed += Client_Completed;// 메시지가 오면 이벤트를 발생시킨다. (IOCP로 꺼내는 것), completed 이벤트는 데이터를 주거나 받을때 발생함
                
                this.socket.ReceiveAsync(this);// 메시지가 오면 이벤트를 발생시킨다. (IOCP로 넣는 것)
                
                remoteAddr = (IPEndPoint)socket.RemoteEndPoint;// 접속 환영 메시지
                if (remoteAddr != null)
                {
                    Console.WriteLine($"Client : (From: {remoteAddr.Address.ToString()}:{remoteAddr.Port}, Connection time: {DateTime.Now})");
                    this.Send("Welcome server!\r\n>");
                }

            }
            catch (Exception e)
            {
                return;
            }

        }

        ~Client()
        {
            socket = null;
        }

        public void Send(String msg)
        {
            byte[] sendData = Encoding.Unicode.GetBytes(msg);
            //sendArgs.SetBuffer(sendData, 0, sendData.Length);
            //socket.SendAsync(sendArgs);

            // Client로 메시지 전송, public int Send (byte[] buffer, int size, System.Net.Sockets.SocketFlags socketFlags);
            if (socket != null) socket.Send(sendData, sendData.Length, SocketFlags.None);//SocketFlags.None : 플래그를 사용하지 않음
        }

        private void Client_Completed(object sender, SocketAsyncEventArgs e)
        {
            if (socket.Connected && base.BytesTransferred > 0) //연결이 되고 전송된 것이 있으면
            {
                byte[] data = e.Buffer; //수신데이터가 e에 저장됨
                string msg = Encoding.Unicode.GetString(data);
                // 메모리 버퍼를 초기화 한다. 크기는 1024이다
                base.SetBuffer(new byte[1024], 0, 1024); // base 부모클래스의 생성자를 이용할 때 사용
                sb.Append(msg.Trim('\0'));//버퍼의 공백을 없앤다.(바이트 배열을 string으로 변환할 때 공백을 \0 변환한다. 이것을 제거하기 위함)

                // 메시지의 끝이 이스케이프 \r\n의 형태이면 서버에 표시한다.
                if (sb.Length >= 2 && sb[sb.Length - 2] == CR && sb[sb.Length - 1] == LF)
                {
                    //개행문자 제거
                    sb.Length = sb.Length - 2;
                    msg = sb.ToString(); //문자열로 변환

                    if (OnReceive != null) OnReceive(this.socket, msg); // 수신 이벤트 발생

                    if ("exit".Equals(msg, StringComparison.OrdinalIgnoreCase))// 메시지가 exit이면(대소문자 무시하고 비교)
                    {
                        OnDisconnect(socket); //접속 중단
                        // 접속을 중단한다.
                        socket.DisconnectAsync(this);
                        return;
                    }
                    sb.Clear(); // 버퍼를 비운다.

                }

                this.socket.ReceiveAsync(this); // 메시지가 오면 이벤트를 발생시킨다.(데이터를 받기위해)
            }
            else
            {
                OnDisconnect(socket);
            }
        }
    }
}
