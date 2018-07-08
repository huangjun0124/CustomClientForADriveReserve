using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPYC.Model;

namespace PPYC.ServerInteract
{
    public class GetUncommentedReserve : ApiGetRequestBase
    {
        public static ApiGetUncommentedReserveResult Get(ApiCode code, string appRecordId)
        {
            var request = GetNewRequest(code, UrlManager.GetMyApp_CarOrderInfoNew);
            request.AddParameter("AppRecordID", appRecordId);
            request.AddParameter("State", 2); // 订单状态 (1:已预约;2:待评价;0:已取消;4:已评论)
            return RequestClient.DoWithRequest<ApiGetUncommentedReserveResult>(request);
        }
    }
}
