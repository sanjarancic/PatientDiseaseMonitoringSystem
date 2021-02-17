using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Doctor:IDomain
    {
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string DoctorSurname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string Table => "Doctor";

        public string InsertValues => $"{this.DoctorId}, '{this.DoctorName}', '{this.DoctorSurname}', '{this.Username}', '{this.Password}'";

        public string UpdateValues => $"DoctorId = {this.DoctorId}, DoctorName = '{this.DoctorName}', DoctorSurname = '{this.DoctorSurname}', Username = '{this.Username}', Password = '{this.Password}'";

        public string SearchWhere { get; set; }

        public string SearchId => $"DoctorId = {this.DoctorId}";

        public string JoinFull => "";

        public object ColumnId => "DoctorId";

        public List<IDomain> GetReaderResult(SqlDataReader reader)
        {
            List<IDomain> list = new List<IDomain>();
            while (reader.Read())
            {
                Doctor m = new Doctor
                {
                    DoctorId = (int)reader[3],
                    DoctorName = reader.GetString(5),
                    DoctorSurname = reader.GetString(6),
                    Username = reader.GetString(7),
                    Password = reader.GetString(8)
                };
                list.Add(m);
            }
            return list;
        }

        public List<IDomain> GetReaderResultJoin(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
