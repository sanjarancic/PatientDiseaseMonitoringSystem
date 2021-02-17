using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Transfer;

namespace Client
{
    class Communication
    {
        private static Communication instance;
        private Socket socket;
        private NetworkStream stream;
        private BinaryFormatter formatter = new BinaryFormatter();

        public static Communication Instance
        {
            get
            {
                if (instance == null) instance = new Communication();
                return instance;
            }
        }

        internal Response PretragaPacijenata(Patient p)
        {
            SendRequest(p, Operation.PretragaPacijenata);
            Response r = (Response)formatter.Deserialize(stream);
            return r;
        }

        internal List<Medicine> UcitajLekove()
        {
            SendRequest(null, Operation.UcitajLekove);

            Response r = (Response)formatter.Deserialize(stream);

            return (List<Medicine>)r.Object;
        }

        internal Response UnosDijagnoze(Diagnosis d)
        {
            SendRequest(d, Operation.UnosDijagnoze);
            Response r = (Response)formatter.Deserialize(stream);
            return r;
        }

        internal bool Connect()
        {
            try
            {
                if (socket == null || !socket.Connected)
                {
                    socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    socket.Connect("localhost", 9090);
                    stream = new NetworkStream(socket);
                }
                return true;
            }
            catch (SocketException)
            {
                return false;
            }
        }

        internal Response IzmeniPacijenta(Patient pacijent)
        {
            SendRequest(pacijent, Operation.IzmenaPacijenta);
            Response r = (Response)formatter.Deserialize(stream);

            return r;
        }

        internal Response SacuvajPacijenta(Diagnosis dijagnoza)
        {
            SendRequest(dijagnoza, Operation.SacuvajPacijentaIDijagnozu);
            Response r = (Response)formatter.Deserialize(stream);

            return r;
        }

        private void SendRequest(Object obj, Operation operation)
        {
            Request request = new Request();
            request.Object = obj;
            request.Operation = operation;

            formatter.Serialize(stream, request);
        }


        internal Doctor LoginUser(Doctor d)
        {
            SendRequest(d, Operation.Login);
            Response r = (Response)formatter.Deserialize(stream);
            if (r.Signal.Equals(Signal.OK)) 
                return (Doctor)r.Object;
            else 
                return null;
        }

        internal Response SacuvajBolest(Illness illness)
        {
            SendRequest(illness, Operation.SacuvajBolest);
            Response r = (Response)formatter.Deserialize(stream);

            return r;
        }

        internal List<Illness> UcitajBolesti()
        {
            SendRequest(null, Operation.UcitajBolesti);

            Response r = (Response)formatter.Deserialize(stream);

            return (List<Illness>) r.Object;
        }

        internal Response UnosLeka(Medicine m)
        {
            SendRequest(m, Operation.UnosLeka);
            Response r = (Response)formatter.Deserialize(stream);

            return r;
        }

        internal Response BrisanjeLeka(Medicine m)
        {
            SendRequest(m, Operation.BrisanjeLeka);
            Response r = (Response)formatter.Deserialize(stream);

            return r;
        }

        internal Response PretragaLekova(Medicine m)
        {
            SendRequest(m, Operation.PretragaLekova);
            Response r = (Response)formatter.Deserialize(stream);

            return r;
        }


    }
}
