using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Sockets;

namespace Server
{
    class ServerProgram : Socket
    {
        public delegate void ClientReceiveHandler(Socket sock, String msg); //수신 메시지 이벤트를 위한 델리게이트
        public event ClientReceiveHandler OnReceive;

        public delegate void ClientDisconnectHandler(Socket sock);
        public event ClientDisconnectHandler OnDisconnect;

        public delegate void ClientConnectHandler(Socket sock);
        public event ClientConnectHandler OnConnect;

        private bool _disposed = false;

        public Server.Properties.Server serverSocket;
        public IPEndPoint ipEndPoint;

        public ServerProgram(int port) : base(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
        {
            ipEndPoint = new IPEndPoint(IPAddress.Any, port);

            try
            {
                base.Bind(ipEndPoint);//소켓에 포트를 부여
                base.Listen(20);//보류중인 연결큐의 최대길이??

                // 비동기 소켓으로 Server 클래스를 선언한다. (IOCP로 집어넣는것)
                serverSocket = new Server.Properties.Server(this); //?
                serverSocket.OnConnect += ClientConnect;
                serverSocket.OnDisconnect += ClientDisConnect;
                serverSocket.OnReceive += ClientRecieve;

                base.AcceptAsync(serverSocket);
            }
            catch (Exception ex)
            {
                return;
            }
        }


        private void ClientRecieve(Socket sock, string msg)
        {
            if (OnReceive != null)
                OnReceive(sock, msg);
        }

        private void ClientDisConnect(Socket sock)
        {
            if (OnDisconnect != null)
                OnDisconnect(sock);
        }

        private void ClientConnect(Socket sock)
        {
            if (OnConnect != null)
                OnConnect(sock);
        }

        protected override void Dispose(bool disposing)
        {
            if (_disposed) return;
            try
            {
                if (serverSocket != null)
                {
                    serverSocket.SocketClose();
                    base.Disconnect(true);

                    base.Shutdown(SocketShutdown.Both);
                    base.Close();
                    base.Dispose();

                    GC.SuppressFinalize(serverSocket);
                }
                //serverSocket = null;
            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                //base.Close(0);
            }
            _disposed = true;
        }

        public void SendMessage(String msg)
        {
            if (serverSocket != null)
                serverSocket.SendAllMessage(msg);
        }

    }
}
