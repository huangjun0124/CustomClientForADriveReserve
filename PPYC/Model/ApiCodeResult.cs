using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPYC.Model
{
    public class ApiCode
    {
        public string Signature { get; set; }
        public int Timestamp { get; set; }
        public int Nonce { get; set; }
    }

    public class GetApiCodeResult : ModelBase
    {
        public ApiCode Data { get; set; }
    }
}
