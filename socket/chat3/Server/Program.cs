using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net
using System.Net.Sockets;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("서버 콘솔창 \n\n\n");

            TcpListener server = new TcpListener(IPAddress.Any, 9999); // 모든 네트워크의 클라이언트에 대하여 대기해야함을 의미

            server.Start(); //서버를 시작한다.

            TcpClient client = server.AcceptTcpClient(); //클라이언트 객체를 만들어 9999에 연결한  클라이언트를 받아온다.

            byte[] byteData = new byte[1024];


            // client가 write한 정보를 읽어옵니다.
            client.GetStream().Read(byteData, 0, byteData.Length);

            // Socket은 byte[] 형식으로 데이터를 주고받으므로 출력을 위해 
            // string형으로 바꿔줍니다.
            Console.WriteLine(Encoding.Default.GetString(byteData));

            server.Stop();

        }
    }
}
