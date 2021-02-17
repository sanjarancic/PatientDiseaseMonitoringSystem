using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    class UnosDijagnozeSO : AbstractGenericOperation
    {
        protected override object Execute(IDomain entity)
        {
            return broker.Insert(entity) > 0;
        }

        protected override void Validate(IDomain entity)
        {
            if(!(entity is Diagnosis))
            {
                throw new ArgumentException();
            }
        }
    }
}
