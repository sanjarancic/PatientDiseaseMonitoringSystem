using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class LoginSO : AbstractGenericOperation
    {
        protected override object Execute(IDomain entity)
        {
            Doctor d = (Doctor)entity;
            Doctor doctor = (Doctor)broker.Select(entity)[0];
            if (d.Password == doctor.Password)
                return doctor;
            else
                return null;
            
        }

        protected override void Validate(IDomain entity)
        {
            if(!(entity is Doctor))
            {
                throw new ArgumentException();
            }
        }
    }
}
