using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPYC.Model
{
    public class ApiReservedDate
    {
        public string ReservedDate { get; set; }
        public string ReservedTime { get; set; }
        public string WeekName { get; set; }
    }

    public class ApiGetReservedDateResult:ModelBase
    {
        public IList<ApiReservedDate> Data { get; set; }
    }
}
