using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPYC.Model
{
    public class ApiLoginInfo
    {
        public string RecordID { get; set; }
        public string UserID { get; set; }
        public string UserName { get; set; }
        public string SexCodeNO { get; set; }
        public string IdentityCard { get; set; }
        public string PhoneNumber { get; set; }
        public string Country { get; set; }
        public string Birthday { get; set; }
        public string UserType { get; set; }
        public string Remark { get; set; }
        public string PhotoAddress { get; set; }
        public int IsStudent { get; set; }
        public string IsHoursModel { get; set; }
        public string DeptCodeNO { get; set; }
        public string DeptCodeName { get; set; }
        public string StudentNO { get; set; }
        public string TeachNo { get; set; }
    }

    public class ApiLoginResult:ModelBase
    {
        public IList<ApiLoginInfo> Data { get; set; }
    }
}
