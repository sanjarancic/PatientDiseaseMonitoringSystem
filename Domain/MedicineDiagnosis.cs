using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class MedicineDiagnosis:IDomain
    {
        public Diagnosis Diagnosis { get; set; }
        public Medicine Medicine { get; set; }

        public string Table => "MedicineDiagnosis";

        public string InsertValues => $"{Medicine.MedicineId}, '{Diagnosis.Patient.PatientJMBG}', '{Diagnosis.Date}'";

        public string UpdateValues => $"MedicineId = {Medicine.MedicineId}, PatientJMBG = '{Diagnosis.Patient.PatientJMBG}', date = '{Diagnosis.Date}'";

        public string SearchWhere { get ; set ; }

        public string SearchId => throw new NotImplementedException();

        public string JoinFull => throw new NotImplementedException();

        public object ColumnId => throw new NotImplementedException();

        public List<IDomain> GetReaderResult(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public List<IDomain> GetReaderResultJoin(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
