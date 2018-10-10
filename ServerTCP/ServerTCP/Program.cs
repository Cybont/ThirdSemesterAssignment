using System;

namespace ServerTCP
{
    class Program
    {
        private const int PORT = 7;
        static void Main(string[] args)
        {
            EchoServer server = new EchoServer(10001);
            server.Start();

            Console.ReadLine();
        }
    }
}
