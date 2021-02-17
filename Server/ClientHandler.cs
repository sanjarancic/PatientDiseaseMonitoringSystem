using Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Transfer;

namespace Server
{
    class ClientHandler
    {
        private Socket clientSocket;
        private NetworkStream stream;
        private BinaryFormatter formatter;
        private List<Socket> connectedClients;
        public ClientHandler(Socket clientSocket, List<Socket> connectedClients)
        {
            this.clientSocket = clientSocket;
            this.stream = new NetworkStream(clientSocket);
            formatter = new BinaryFormatter();
            this.connectedClients = connectedClients;

            Thread clientThread = new Thread(HandleRequest);
            clientThread.IsBackground = true;
            clientThread.Start();
        }

        private void HandleRequest()
        {
            bool end = false;
            while (!end)
            {
                try
                {
                    Request request = (Request)formatter.Deserialize(stream);
                    Response response = null;
                    switch (request.Operation)
                    {
                        case Operation.Login:
                            response = Login((Doctor)request.Object);
                            formatter.Serialize(stream, response);
                            break;
                    }
                }
                catch (SocketException)
                {
                    end = true;
                    connectedClients.Remove(clientSocket);

                }
                catch (IOException)
                {
                    end = true;
                    connectedClients.Remove(clientSocket);

                }
            }
        }

        private Response Login(Doctor @object)
        {
            throw new NotImplementedException();
        }
    }
}
