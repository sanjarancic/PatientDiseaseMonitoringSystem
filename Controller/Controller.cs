using DBBroker;
using Domain;
using Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public bool LoginUser(Doctor d)
        {
            StorageUser storage = new StorageUser();
            List<Doctor> users = storage.ReturnDoctors();

            if (users.SingleOrDefault((user) => (user.Username == d.Username && user.Password == d.Password)) is null) return false;
            return true;
        }
    }
}
