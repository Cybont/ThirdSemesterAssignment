using System;

namespace ClientTCP
{
    class Program
    {
        private const int ConnectToPort = 7;
        private const String ConnectToHost = "localhost";

        static void Main(string[] args)
        {
            Client client = new Client(ConnectToHost, 10001);
            client.Start();

            Console.ReadLine();
        }
    }
}
