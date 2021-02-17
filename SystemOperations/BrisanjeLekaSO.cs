using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class BrisanjeLekaSO : AbstractGenericOperation
    {
        protected override object Execute(IDomain entity)
        {
            return broker.Delete(entity) > 0;
        }

        protected override void Validate(IDomain entity)
        {
            if(!(entity is Medicine))
            {
                throw new ArgumentException();
            }
        }
    }
}
