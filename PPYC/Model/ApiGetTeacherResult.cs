using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPYC.Model
{
    public class ApiTeacherInfo
    {
        public string TeachNo { get; set; }
    }

    public class ApiGetTeacherResult : ModelBase
    {
        public ApiTeacherInfo Data { get; set; }
    }
}
