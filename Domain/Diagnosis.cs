using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Diagnosis : IDomain
    {
        public Patient Patient { get; set; }
        public DateTime Date { get; set; }
        public Doctor Doctor { get; set; }
        public Illness Illness { get; set; }
        public Medicine Medicine { get; set; }
        public string Table => "Diagnosis";

        public string InsertValues => $"'{this.Patient.PatientJMBG}', '{this.Date}', {this.Doctor.DoctorId}, {this.Illness.IllnessId}, {this.Medicine.MedicineId}";

        public string UpdateValues => $"PatientJMBG = '{this.Patient.PatientJMBG}', Date = '{this.Date}', DoctorId = {this.Doctor.DoctorId}, IllnessId = {this.Illness.IllnessId}, MedicineId = {this.Medicine.MedicineId}";

        public string SearchWhere { get; set; }

        public string SearchId => $"PatientJMBG = '{this.Patient.PatientJMBG}' and Date = '{this.Date}'";

        public string JoinFull => $"d join Patient p on(d.PatientJMBG = p.PatientJMBG) join Medicine m on(d.MedicineId = m.MedicineId) join Illness i on(d.IllnessId = i.IllnessId) join Doctor doc on(d.DoctorId = doc.DoctorId)";

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
                        IllnessId = (int)reader[13],
                        IllnessName = reader.GetString(14),
                        IllnessCategory = reader.GetString(15)
                    },
                    Medicine = new Medicine
                    { 
                        MedicineId = (int)reader[9],
                        MedicineName = reader.GetString(10),
                        MedicineCategory = reader.GetString(11)
                    },
                    Doctor = new Doctor
                    {
                        DoctorId = (int)reader[17],
                        DoctorName = reader.GetString(18),
                        DoctorSurname = reader.GetString(19),
                        Username = reader.GetString(20),
                        Password = reader.GetString(21)
                    }
                };
                list.Add(m);
            }
            return list;
        }
    }
}
