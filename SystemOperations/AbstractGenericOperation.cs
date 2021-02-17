using DBBroker;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public abstract class AbstractGenericOperation
    {
        protected abstract object Execute(IDomain entity);
        protected abstract void Validate(IDomain entity);
        protected Broker broker = new Broker();

        public object ExecuteSO(IDomain entity)
        {
            object res = null;

            try
            {
                Validate(entity);
                broker.OpenConnection();
                broker.BeginTransaction();

                res = Execute(entity);

                broker.CommitTransaction();
            }
            catch (Exception)
            {
                broker.RollbackTransaction();
            }
            finally
            {
                broker.CloseConnection();
            }

            return res;
        }

    }
}
