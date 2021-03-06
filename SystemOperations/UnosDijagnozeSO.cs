﻿using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public class UnosDijagnozeSO : AbstractGenericOperation
    {
        protected override object Execute(IDomain entity)
        {
            Diagnosis d = (Diagnosis)entity;

            int rows = broker.Insert(d);
            if (rows == 0) return false;

            List<IDomain> dm = broker.Select(d);
            Diagnosis diagnosisInDb = (Diagnosis)dm.Last();

            bool success = false;
            foreach (Medicine m in d.Medicines)
            {
                MedicineDiagnosis md = new MedicineDiagnosis()
                {
                    Diagnosis = diagnosisInDb,
                    Medicine = m
                };
                if (broker.Insert(md) == 0)
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
            if(!(entity is Diagnosis))
            {
                throw new ArgumentException();
            }
        }

        public override object ExecutePublic(IDomain entity)
        {
           return Execute(entity);
        }
    }
}
