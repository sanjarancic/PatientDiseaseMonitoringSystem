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
    public class Medicine:IDomain
    {
        [Browsable(false)]
        public int MedicineId { get; set; }
        public string MedicineName { get; set; }
        public string MedicineCategory { get; set; }
        public Doctor Doctor { get; set; }
        public List<Illness> Illnesses { get; set; }

        [Browsable(false)]
        public string Table => "Medicine";

        [Browsable(false)]
        public string InsertValues => $"'{this.MedicineName}', '{this.MedicineCategory}', {this.Doctor.DoctorId}";

        [Browsable(false)]
        public string UpdateValues => $"MedicineName = '{this.MedicineName}', MedicineCategory = '{this.MedicineCategory}', DoctorId = {this.Doctor.DoctorId}";

        [Browsable(false)]
        public string SearchWhere { get; set; }

        [Browsable(false)]
        public string SearchId => $"MedicineId = {this.MedicineId}";

        [Browsable(false)]
        public string JoinFull => $"m join Doctor d on (m.DoctorId = d.DoctorId)";

        [Browsable(false)]
        public object ColumnId => "MedicineId";

        public List<IDomain> GetReaderResult(SqlDataReader reader)
        {
            List<IDomain> list = new List<IDomain>();
            while (reader.Read())
            {
                Medicine m = new Medicine
                {
                    MedicineId = (int)reader[0],
                    MedicineName = reader.GetString(1),
                    MedicineCategory = reader.GetString(2)
                };
                list.Add(m);
            }
            return list;
        }

        public List<IDomain> GetReaderResultJoin(SqlDataReader reader)
        {
            List<IDomain> list = new List<IDomain>();
            while (reader.Read())
            {
                Doctor doctor = new Doctor
                {
                    DoctorId = (int)reader[3],
                    DoctorName = reader.GetString(5),
                    DoctorSurname = reader.GetString(6),
                    Username = reader.GetString(7),
                    Password = reader.GetString(8)
                };

               
               
                Medicine m = new Medicine
                {
                    MedicineId = (int)reader[0],
                    MedicineName = reader.GetString(1),
                    MedicineCategory = reader.GetString(2),
                    Doctor = doctor
                };

                list.Add(m);
               
            }
            return list;
        }
        public override string ToString()
        {
            return MedicineName;
        }
    }
}
