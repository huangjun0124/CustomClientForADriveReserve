using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPYC.Model
{
    public class ApiReserveResult
    {
        public string RecordID { get; set; }
        public string ReservedID { get; set; }
        public string StudentNO { get; set; }
        public string AppRecordID { get; set; }
        public string TeacherNo { get; set; }
        public string Course { get; set; }
        public string OrderDateTime { get; set; }
        public string GradeType { get; set; }
        public string GradeContent { get; set; }
        public string TeacherStar { get; set; }
        public string SchoolStar { get; set; }
        public string State { get; set; }
        public string TrainingItem { get; set; }
        public string Mileage { get; set; }
        public string Remark { get; set; }
        public string DeviceType { get; set; }
        public string CancelDate { get; set; }
        public string CancelRemark { get; set; }
        public string CreatedOn { get; set; }
        public string IsValid { get; set; }
        public string ReviewDate { get; set; }
        public int ReservedHours { get; set; }
        public string ReservedHoursInto { get; set; }
        public string SignInDateTime { get; set; }
        public string SignOutDateTime { get; set; }
        public string PayNum { get; set; }
        public string PayDate { get; set; }
        public string PayState { get; set; }
        public string PayModeNO { get; set; }
        public string IPAddr { get; set; }
        public string IsSync { get; set; }
        public string SyncDate { get; set; }
        public string EndTime { get; set; }
        public string StartTime { get; set; }
    }

    public class ApiExecuteReserveResult : ModelBase
    {
        public IList<ApiReserveResult> Data { get; set; }
    }
}
