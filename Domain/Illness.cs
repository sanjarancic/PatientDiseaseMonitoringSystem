using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class Illness:IDomain
    {
        public int IllnessId { get; set; }
        public string IllnessName { get; set; }
        public string IllnessCategory { get; set; }
        public Doctor Doctor { get; set; }

        public string Table => "Illness";

        public string InsertValues => $"'{this.IllnessName}', '{this.IllnessCategory}', {this.Doctor.DoctorId}";

        public string UpdateValues => $"IllnessId = {this.IllnessId}, IllnessName = '{this.IllnessName}', IllnessCategory = '{this.IllnessCategory}', DoctorId = {this.Doctor.DoctorId}";

        public string SearchWhere { get ; set; }

        public string SearchId => $"IllnessId = {this.IllnessId}";

        public string JoinFull => $"i join Doctor d on (i.DoctorId = d.DoctorId)";

        public object ColumnId => "IllnessId";

        public List<IDomain> GetReaderResult(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public List<IDomain> GetReaderResultJoin(SqlDataReader reader)
        {
            List<IDomain> list = new List<IDomain>();
            while (reader.Read())
            {
                Illness m = new Illness
                {
                    IllnessId = (int)reader[0],
                    IllnessName = reader.GetString(1),
                    IllnessCategory = reader.GetString(2),
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
            return IllnessName;
        }
    }
}
