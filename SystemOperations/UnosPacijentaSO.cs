using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class UnosPacijentaSO : AbstractGenericOperation
    {
        protected override object Execute(IDomain entity)
        {
            return broker.Insert(entity) > 0;
        }

        protected override void Validate(IDomain entity)
        {
            if (!(entity is Patient))
            {
                throw new ArgumentException();
            }
        }
    }
}
