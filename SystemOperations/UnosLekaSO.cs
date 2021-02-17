using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class UnosLekaSO : AbstractGenericOperation
    {
        protected override object Execute(IDomain entity)
        {
            Medicine m = (Medicine)entity;

            int rows = broker.Insert(m);
            if (rows == 0) return false;

            List<IDomain> ms = broker.Select(m);
            Medicine medicineInDb = (Medicine) ms.Last();

            bool success = false;
            foreach (Illness i in m.Illnesses)
            {
                IllnessMedicine im = new IllnessMedicine()
                {
                    Medicine = medicineInDb,
                    Illness = i
                };
                if (broker.Insert(im) == 0)
                {
                    success = false;
                }
                else
                {
                    success = true;
                }

            }
            return success;
        }

        protected override void Validate(IDomain entity)
        {
            if (!(entity is Medicine))
            {
                throw new ArgumentException();
            }
        }
    }
}
