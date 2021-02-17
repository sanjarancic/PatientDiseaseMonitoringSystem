using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public class StorageUser
    {
        private List<Doctor> doctors;
        public StorageUser()
        {
            doctors = new List<Doctor>() {
                new Doctor {
                Username = "sanja",
                Password = "sanja"
                }

             };
        }

        public List<Doctor> ReturnDoctors()
        {
            return doctors;
        }
    }
}
