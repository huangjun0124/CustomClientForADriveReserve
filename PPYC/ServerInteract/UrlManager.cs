using System.Configuration;
namespace PPYC
{
    public class UrlManager
    {
        public static string BaseUrl { get; }

        /// <summary>
        /// 获取 signature， timestamp， nonce
        /// </summary>
        public const string GetApiCode = "GetApiCode";

        /// <summary>
        /// 获取登陆信息
        /// </summary>
        public const string GetLogin = "GetLogin";

        /// <summary>
        /// 获取教练信息
        /// </summary>
        public const string GetStudentBindTeachInfo = "GetStudentBindTeachInfo";

        /// <summary>
        /// 获取可以预约的日期
        /// </summary>
        public const string GetReservedDateListNew = "GetReservedDateListNew";

        /// <summary>
        /// 获取选择日期的可预约情况
        /// </summary>
        public const string GetReservedTimeList = "GetReservedTimeListNew";

        /// <summary>
        ///  执行预约
        /// </summary>
        public const string AddCarOrderInfo_Android = "AddCarOrderInfo_Android";

        /// <summary>
        /// 取消预约
        /// </summary>
        public const string CancelReserve = "StudentCancelCarOrderInfo";

        static UrlManager()
        {
            BaseUrl = ConfigurationManager.AppSettings["BaseUrl"];
        }
    }
}
