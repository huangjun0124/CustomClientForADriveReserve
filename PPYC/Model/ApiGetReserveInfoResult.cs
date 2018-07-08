using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPYC.Model
{
    public class ApiReserveTime
    {
        public string RecordID { get; set; }
        public string TeacherID { get; set; }
        public string ReservedDate { get; set; }
        public string ReservedTime { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int Number { get; set; }
        public string IsValid { get; set; }
        public int UsedNumber { get; set; }
        public int IsMyUsed { get; set; }
        public double HoursPrice { get; set; }
        public string ValidMemo { get; set; }
        public string CarOrderID { get; set; }
        public string Name { get; set; }
        public string Tel { get; set; }
        public string IdentityCard { get; set; }
    }

    public class ApiGetReserveInfoResult : ModelBase
    {
        public IList<ApiReserveTime> Data { get; set; }
    }
}
