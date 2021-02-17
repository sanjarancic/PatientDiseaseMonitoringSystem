using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class IzmenaPacijentaSO : AbstractGenericOperation
    {
        protected override object Execute(IDomain entity)
        {
            return broker.Update(entity) > 0 ;
        }

        protected override void Validate(IDomain entity)
        {
            if(!(entity is Patient))
            {
                throw new ArgumentException();
            }
        }
    }
}
