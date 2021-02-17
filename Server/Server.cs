using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Server
    {
        private Socket serverSocket;
        internal static List<Socket> connectedClients = new List<Socket>();

        public bool RunServer()
        {
            try
            {
                serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                serverSocket.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9090));
                serverSocket.Listen(5);

                return true;
            }
            catch (SocketException)
            {
                return false;
            }
        }

        public void Listen()
        {
            bool end = false;
            try
            {

                while (!end)
                {
                    Socket clientSocket = serverSocket.Accept();
                    ClientHandler handler = new ClientHandler(clientSocket, connectedClients);
                    connectedClients.Add(clientSocket);
                }
            }
            catch (Exception)
            {

                end = true;
            }

        }

        public bool StopServer()
        {
            try
            {

                serverSocket.Close();


                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
    }
}
