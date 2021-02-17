using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Diagnosis : IDomain
    {
        public Patient Patient { get; set; }
        public DateTime Date { get; set; }
        public Doctor Doctor { get; set; }
        public Illness Illness { get; set; }
        public List<Medicine> Medicines { get; set; }
        public string Table => "Diagnosis";

        public string InsertValues => $"'{this.Patient.PatientJMBG}', '{this.Date}', {this.Doctor.DoctorId}, {this.Illness.IllnessId}";

        public string UpdateValues => $"PatientJMBG = '{this.Patient.PatientJMBG}', Date = '{this.Date}', DoctorId = {this.Doctor.DoctorId}, IllnessId = {this.Illness.IllnessId}";

        public string SearchWhere { get; set; }

        public string SearchId => $"PatientJMBG = '{this.Patient.PatientJMBG}' and Date = '{this.Date}'";

        public string JoinFull => $"d join Patient p on(d.PatientJMBG = p.PatientJMBG) join Illness i on(d.IllnessId = i.IllnessId) join Doctor doc on(d.DoctorId = doc.DoctorId)";

        public object ColumnId => "PatientJMBG";

        public List<IDomain> GetReaderResult(SqlDataReader reader)
        {
            List<IDomain> list = new List<IDomain>();
            while (reader.Read())
            {
                Diagnosis d = new Diagnosis
                {
                    Patient = new Patient
                    {
                        PatientJMBG = reader.GetString(0)
                    },
                    Date = reader.GetDateTime(1),
                    Doctor = new Doctor
                    {
                        DoctorId = (int)reader[2]
                    },
                    Illness = new Illness
                    {
                        IllnessId = (int)reader[3]
                    }
                };
                list.Add(d);
            }
            return list;
        }

        public List<IDomain> GetReaderResultJoin(SqlDataReader reader)
        {
            List<IDomain> list = new List<IDomain>();
            while (reader.Read())
            {
                Diagnosis m = new Diagnosis
                {
                    Patient = new Patient
                    {
                        PatientJMBG = reader.GetString(5),
                        PatientName = reader.GetString(6),
                        PatientSurname = reader.GetString(7)
                    },
                    Date = reader.GetDateTime(1),
                    Illness = new Illness
                    {
                        IllnessId = (int)reader[9],
                        IllnessName = reader.GetString(10),
                        IllnessCategory = reader.GetString(11)
                    },
                    Doctor = new Doctor
                    {
                        DoctorId = (int)reader[13],
                        DoctorName = reader.GetString(14),
                        DoctorSurname = reader.GetString(15),
                        Username = reader.GetString(16),
                        Password = reader.GetString(17)
                    }
                };
                list.Add(m);
            }
            return list;
        }
    }
}
