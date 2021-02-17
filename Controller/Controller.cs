using DBBroker;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperations;

namespace Controller
{
    public class Controller
    {
        private Broker broker = new Broker();
        private static Controller _instance;
        public static Controller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Controller();
                }
                return _instance;
            }
        }
        private Controller()
        {
        }

        public Doctor LoginUser(Doctor doctor)
        {
            AbstractGenericOperation ago = new LoginSO();
            return (Doctor)ago.ExecuteSO(doctor);
        }

        public bool SacuvajBolest(Illness i)
        {
            return (bool) new UnosBolestiSO().ExecuteSO(i);
        }

        public List<Illness> UcitajBolesti()
        {
            return (List<Illness>) new UcitajBolestiSO().ExecuteSO(new Illness());
        }

        public bool UnosLeka(Medicine m)
        {
            return (bool) new UnosLekaSO().ExecuteSO(m);
        }

        public bool BrisanjeLeka(Medicine m)
        {
            return (bool)new BrisanjeLekaSO().ExecuteSO(m);
        }

        public List<Medicine> PretragaLekova(Medicine m)
        {  
            return (List<Medicine>)new PretragaLekovaSO().ExecuteSO(m);
        }

        public bool SacuvajPacijentaIDijagnozu(Diagnosis diagnosis)
        {
            var res = new UnosPacijentaIDijagnozeSO().ExecuteSO(diagnosis);
            if (res == null) return false;
            return (bool)res;
        }

        public List<Medicine> UcitajLekove()
        {
            return (List<Medicine>)new UcitajLekoveSO().ExecuteSO(new Medicine());
        }

        public List<Patient> PretragaPacijenata(Patient pacijent)
        {
            return (List<Patient>)new PretragaPacijentaSO().ExecuteSO(pacijent);
        }

        public bool SacuvajDijagnozu(Diagnosis diagnosis)
        {
            var ret = new UnosDijagnozeSO().ExecuteSO(diagnosis);
            if (ret == null) return false;
            return (bool) ret;
        }

        public bool IzmenaPacijenta(Patient p)
        {
            return (bool)new IzmenaPacijentaSO().ExecuteSO(p);
        }
    }
}
