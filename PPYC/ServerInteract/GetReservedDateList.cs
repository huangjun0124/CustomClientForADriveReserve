using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPYC.Model;

namespace PPYC.ServerInteract
{
    public class GetReservedDateList : ApiGetRequestBase
    {
        public static ApiGetReservedDateResult Get(ApiCode code, ApiLoginInfo info)
        {
            var request = GetNewRequest(code, UrlManager.GetReservedDateListNew);
            request.AddParameter("AppRecordID", info.RecordID);
            request.AddParameter("TeachID", info.TeachNo);
            return RequestClient.DoWithRequest<ApiGetReservedDateResult>(request);
        }
    }
}
