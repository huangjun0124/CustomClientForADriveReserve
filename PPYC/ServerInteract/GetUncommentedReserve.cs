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
            request.AddParameter("State", 2);
            return RequestClient.DoWithRequest<ApiGetUncommentedReserveResult>(request);
        }
    }
}
