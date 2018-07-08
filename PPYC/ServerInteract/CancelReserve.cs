using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPYC.Model;

namespace PPYC.ServerInteract
{
    public class CancelReserve : ApiGetRequestBase
    {
        public static ModelBase Cancel(ApiCode code, string cardOrderId)
        {
            var request = GetNewRequest(code, UrlManager.CancelReserve);
            request.AddParameter("RecordID", cardOrderId);
            return RequestClient.DoWithRequest<ModelBase>(request);
        }
    }
}
