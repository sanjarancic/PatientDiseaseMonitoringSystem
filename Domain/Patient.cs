using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Patient:IDomain
    {
        public string PatientJMBG { get; set; }
        public string PatientName { get; set; }
        public string PatientSurname { get; set; }
        public Doctor Doctor { get; set; }

        [Browsable(false)]
        public string Table => "Patient";

        [Browsable(false)]
        public string InsertValues => $"'{this.PatientJMBG}', '{this.PatientName}', '{this.PatientSurname}', {this.Doctor.DoctorId}";

        [Browsable(false)]
        public string UpdateValues => $"PatientJMBG = '{this.PatientJMBG}', PatientName = '{this.PatientName}', PatientSurname = '{this.PatientSurname}', DoctorId= {this.Doctor.DoctorId}";

        [Browsable(false)]
        public string SearchWhere { get ; set; }

        [Browsable(false)]
        public string SearchId => $"PatientJMBG = '{this.PatientJMBG}'";

        [Browsable(false)]
        public string JoinFull => $"p join Doctor d on (p.DoctorId = d.DoctorId)";

        [Browsable(false)]
        public object ColumnId => "PatientJMBG";

        public List<IDomain> GetReaderResult(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public List<IDomain> GetReaderResultJoin(SqlDataReader reader)
        {
            List<IDomain> list = new List<IDomain>();
            while (reader.Read())
            {
                Patient m = new Patient
                {
                    PatientJMBG = reader.GetString(0),
                    PatientName = reader.GetString(1),
                    PatientSurname = reader.GetString(2),
                    Doctor = new Doctor
                    {
                        DoctorId = (int)reader[3],
                        DoctorName = reader.GetString(5),
                        DoctorSurname = reader.GetString(6),
                        Username = reader.GetString(7),
                        Password = reader.GetString(8)
                    }
                };
                list.Add(m);
            }
            return list;
        }

        public override string ToString()
        {
            return $"{PatientName} {PatientSurname}";
        }
    }
}
