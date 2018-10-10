using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using WeightConverter;

namespace ServerTCP
{
    internal class EchoServer
    {
        private readonly int PORT;

        public EchoServer(int port)
        {
            this.PORT = port;
        }

        public void Start()
        {
            TcpListener serverListener = new TcpListener(IPAddress.Loopback, PORT);
            serverListener.Start();
            while (true)
            {
                TcpClient socket = serverListener.AcceptTcpClient();

                // print out src + dst end points
                IPEndPoint localAddr = (IPEndPoint)socket.Client.LocalEndPoint;
                IPEndPoint remoteAddr = (IPEndPoint)socket.Client.RemoteEndPoint;
                Console.WriteLine($"Incomming IP={remoteAddr.Address} PORT={remoteAddr.Port}");
                Console.WriteLine($"My own    IP={localAddr.Address} PORT={localAddr.Port}");

                Task.Run(() =>
                {
                    TcpClient tempSocket = socket;
                    DoClient(tempSocket);
                });
            }
        }

        private static void DoClient(TcpClient socket)
        {
            using (StreamReader sr = new StreamReader(socket.GetStream()))
            using (StreamWriter sw = new StreamWriter(socket.GetStream()))
            {
                // Ændre disse 4 linijer
                String incommingStr = sr.ReadLine();
                string[] strArray = incommingStr.Split(" ");

                string method = strArray[0].ToLower();
                double value = double.Parse(strArray[1]);

                switch (method)
                {
                    case "toounces":
                        sw.WriteLine( MyConverter.OuncesToGrams(value));
                    break;
                    case "tograms":
                        sw.WriteLine(MyConverter.GramsToOunces(value));
                    break;
                }

                
                //


                //sw.WriteLine(incommingStr);
                sw.Flush();
                // her til 
            }
            //socket?.Close();
        }
    }
}
