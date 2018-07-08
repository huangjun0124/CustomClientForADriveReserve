using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPYC.Model;

namespace PPYC.ServerInteract
{
    public class ExecuteReserve : ApiGetRequestBase
    {
        public static ApiExecuteReserveResult Reserve(ApiCode code, string appRecordID, string reserveId)
        {
            var request = GetNewRequest(code, UrlManager.AddCarOrderInfo_Android);
            request.AddParameter("AppRecordID", appRecordID);
            request.AddParameter("ReservedID", reserveId);
            return RequestClient.DoWithRequest<ApiExecuteReserveResult>(request);
        }
    }
}
