using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Sockets;

namespace Server.Properties
{
    class Server : SocketAsyncEventArgs
    {
        public delegate void ClientReceiveHandler(Socket sock, String msg); //수신 메시지 이벤트를 위한 델리게이트
        public event ClientReceiveHandler OnReceive;

        public delegate void ClientDisconnectHandler(Socket sock);
        public event ClientDisconnectHandler OnDisconnect;

        public delegate void ClientConnectHandler(Socket sock);
        public event ClientConnectHandler OnConnect;

        private Socket socket;
        public List<Socket> clientSocketList = new List<Socket>();//클라이언트 소켓을 관리하는 리스트, 소켓과 접속 아이디를 관리하자.
        public Dictionary<Socket, Client> clientList = new Dictionary<Socket, Client>();//클라이언트 소켓을 관리하는 리스트, 소켓과 접속 아이디를 관리하자.

        public Server(Socket socket)
        {
            this.socket = socket;
            base.UserToken = socket;// 확인요

            base.Completed += Server_Completed;
        }

        public void SocketClose()
        {
            foreach (var client in clientSocketList)
            {
                if (client.Connected) client.Disconnect(false);//재사용 안하므로 false로
                client.Dispose();//소켓 리소스 해제?
            }
            foreach (var client in clientList)
            {
                Client c = client.Value;
                c.Dispose();
            }
            clientSocketList.Clear();
            clientList.Clear();
        }

        private void Server_Completed(object sender, SocketAsyncEventArgs e)
        {
            try
            {
                // 접속이 완료되면, Client Event를 생성하여 Receive이벤트를 생성한다.
                var client = new Client(e.AcceptSocket);
                client.OnReceive += ClientReceive;
                client.OnDisconnect += ClientDisconnect;

                clientSocketList.Add(e.AcceptSocket);
                clientList.Add(e.AcceptSocket, client);
                // 서버 Event에 cilent를 제거한다.
                e.AcceptSocket = null;
                // Client로부터 Accept이 되면 이벤트를 발생시킨다. (IOCP로 넣는 것)
                this.socket.AcceptAsync(e);
                if (OnConnect != null)
                {
                    OnConnect(this.socket);
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }


        private void ClientDisconnect(Socket sock)
        {

            if (OnDisconnect != null)
                OnDisconnect(sock);

            clientList.Remove(sock);
            clientSocketList.Remove(sock);
        }


        private void ClientReceive(Socket sock, string msg)
        {
            if (OnReceive != null)
                OnReceive(sock, msg);
        }


        public void SendAllMessage(String msg)
        {
            foreach (var client in clientList)
            {
                Client c = client.Value;
                c.Send(msg);
            }
        }


    }
}
