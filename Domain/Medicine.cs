using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Medicine:IDomain
    {
        public int MedicineId { get; set; }
        public string MedicineName { get; set; }
        public string MedicineCategory { get; set; }
        public Doctor Doctor { get; set; }

        public string Table => "Medicine";

        public string InsertValues => $"{this.MedicineId}, '{this.MedicineName}', '{this.MedicineCategory}', {this.Doctor.DoctorId}";

        public string UpdateValues => $"MedicineId = {this.MedicineId}, MedicineName = '{this.MedicineName}', MedicineCategory = '{this.MedicineCategory}', DoctorId = {this.Doctor.DoctorId}";

        public string SearchWhere { get; set; }

        public string SearchId => $"MedicineId = {this.MedicineId}";

        public string JoinFull => $"m join Doctor d on (m.DoctorId = d.DoctorId)";

        public object ColumnId => "MedicineId";

        public List<IDomain> GetReaderResult(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public List<IDomain> GetReaderResultJoin(SqlDataReader reader)
        {
            List<IDomain> list = new List<IDomain>();
            while (reader.Read())
            {
                Medicine m = new Medicine
                {
                    MedicineId = (int)reader[0],
                    MedicineName = reader.GetString(1),
                    MedicineCategory = reader.GetString(2),
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
    }
}
