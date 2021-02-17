using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class IllnessMedicine: IDomain
    {
        public Medicine Medicine { get; set; }
        public Illness Illness { get; set; }

        public string Table => "IllnessMedicine";

        public string InsertValues => $"{this.Illness.IllnessId}, {this.Medicine.MedicineId}";

        public string UpdateValues => throw new NotImplementedException();

        public string SearchWhere { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
