using Controller;
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
                        case Operation.SacuvajBolest:
                            response = SacuvajBolest((Illness)request.Object);
                            formatter.Serialize(stream, response);
                            break;
                        case Operation.UcitajBolesti:
                            response = UcitajBolesti();
                            formatter.Serialize(stream, response);
                            break;
                        case Operation.UnosLeka:
                            response = UnosLeka((Medicine)request.Object);
                            formatter.Serialize(stream, response);
                            break;
                        case Operation.PretragaLekova:
                            response = PretragaLekova((Medicine)request.Object);
                            formatter.Serialize(stream, response);
                            break;
                        case Operation.SacuvajPacijentaIDijagnozu:
                            response = SacuvajPacijentaIDijagnozu((Diagnosis)request.Object);
                            formatter.Serialize(stream, response);
                            break;
                        case Operation.UcitajLekove:
                            response = UcitajLekove();
                            formatter.Serialize(stream, response);
                            break;
                        case Operation.PretragaPacijenata:
                            response = PretragaPacijenata((Patient)request.Object);
                            formatter.Serialize(stream, response);
                            break;
                        case Operation.UnosDijagnoze:
                            response = UnosDijagnoze((Diagnosis)request.Object);
                            formatter.Serialize(stream, response);
                            break;
                        case Operation.IzmenaPacijenta:
                            response = IzmenaPacijenta((Patient)request.Object);
                            formatter.Serialize(stream, response);
                            break;
                        case Operation.BrisanjeLeka:
                            response = BrisanjeLeka((Medicine)request.Object);
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

        private Response IzmenaPacijenta(Patient p)
        {
            bool res = Controller.Controller.Instance.IzmenaPacijenta(p);
            if (res)
            {
                return createResponse(Signal.OK, "Patient updated!", res);
            }
            return createResponse(Signal.Error, "Patient not updated!", res);
        }

        private Response UnosDijagnoze(Diagnosis diagnosis)
        {
            bool res = Controller.Controller.Instance.SacuvajDijagnozu(diagnosis);
            if (res)
            {
                return createResponse(Signal.OK, "Diagnosis saved!", res);
            }
            return createResponse(Signal.Error, "Diagnosis not saved!", res);
        }

        private Response PretragaPacijenata(Patient pacijent)
        {
            List<Patient> pacijenti = Controller.Controller.Instance.PretragaPacijenata(pacijent);
            if (pacijenti != null)
            {
                return createResponse(Signal.OK, "Pacijenti su pronadjeni", pacijenti);
            }
            return createResponse(Signal.Error, "Pacijenti nisu pronadjeni", pacijenti);
        }

        private Response UcitajLekove()
        {
            List<Medicine> lekovi = Controller.Controller.Instance.UcitajLekove();
            if (lekovi != null)
            {
                return createResponse(Signal.OK, "Lista lekova je ucitana", lekovi);
            }
            return createResponse(Signal.Error, "Lista lekova nije ucitana", lekovi);
        }

        private Response SacuvajPacijentaIDijagnozu(Diagnosis diagnosis)
        {
            bool res = Controller.Controller.Instance.SacuvajPacijentaIDijagnozu(diagnosis);
            if (res)
            {
                return createResponse(Signal.OK, "Patient saved!", res);
            }
            return createResponse(Signal.Error, "Patient not saved!", res);
            
        }

        private Response Login(Doctor doctor)
        {
            Doctor doc = Controller.Controller.Instance.LoginUser(doctor);
            if (doc != null)
            {
                return createResponse(Signal.OK, "Uspesno ste se prijavili!", doc);
            }
            return createResponse(Signal.Error, "Pogresno ste uneli neki parametar", doc);
        }

        private Response SacuvajBolest(Illness i)
        {
            bool res = Controller.Controller.Instance.SacuvajBolest(i);
            if (res)
            {
                return createResponse(Signal.OK, "Illness saved!", res);
            }

            return createResponse(Signal.Error, "Illness not saved", res);
        }

        private Response UcitajBolesti() 
        {
            List<Illness> res = Controller.Controller.Instance.UcitajBolesti();
            if (res != null)
            {
                return createResponse(Signal.OK, "Illness saved!", res);
            }

            return createResponse(Signal.Error, "Illness not saved", res);
        }

        private Response UnosLeka(Medicine m)
        {
            bool res = Controller.Controller.Instance.UnosLeka(m);
            if (!res)
            {
                return createResponse(Signal.OK, "Medicine saved!", res);
            }

            return createResponse(Signal.Error, "Medicine not saved", res);
        }

        private Response BrisanjeLeka(Medicine m)
        {
            bool res = Controller.Controller.Instance.BrisanjeLeka(m);

            if (res)
            {
                return createResponse(Signal.OK, "Medicine deleted!", res);
            }

            return createResponse(Signal.Error, "Medicine is not deleted", res);
        }

        private Response PretragaLekova(Medicine m)
        {
            List<Medicine> medicines = Controller.Controller.Instance.PretragaLekova(m);

            if (medicines == null)
            {
                return createResponse(Signal.OK, "Medicine deleted!", medicines);
            }

            return createResponse(Signal.Error, "Medicine not deleted", medicines);
        }

        private Response createResponse(Signal signal, string message, Object obj)
        {
            Response r = new Response
            {
                Object = obj,
                Message = message,
                Signal = signal
            };
            return r;
        }
    }
}
