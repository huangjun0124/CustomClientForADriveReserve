using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPYC.Model
{
    public class ApiMyReserveInfo
    {
        public string Course { get; set; }
        public string OrderDateTime { get; set; }
        public string UserName { get; set; }
        public string RecordID { get; set; }
        public int ReservedHours { get; set; }
    }

    public class ApiGetUncommentedReserveResult : ModelBase
    {
        public IList<ApiMyReserveInfo> Data { get; set; }
    }
}
