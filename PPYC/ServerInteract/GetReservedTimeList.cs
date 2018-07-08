using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPYC.Model;

namespace PPYC.ServerInteract
{
    public class GetReservedTimeList : ApiGetRequestBase
    {
        public static ApiGetReserveInfoResult Get(ApiCode code, ApiLoginInfo info, string reserveDate, int phase)
        {
            var request = GetNewRequest(code, UrlManager.GetReservedTimeList);
            request.AddParameter("AppRecordID", info.RecordID);
            request.AddParameter("TeachID", info.TeachNo);
            request.AddParameter("ReservedDate", reserveDate);
            request.AddParameter("Phase", phase);
            return RequestClient.DoWithRequest<ApiGetReserveInfoResult>(request);
        }
    }
}
