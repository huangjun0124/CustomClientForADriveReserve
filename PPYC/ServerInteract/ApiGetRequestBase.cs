using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPYC.Model;
using RestSharp;

namespace PPYC.ServerInteract
{
    public class ApiGetRequestBase
    {
        protected static RestRequest GetNewRequest(ApiCode apiCode, string urlMethod)
        {
            var request = new RestRequest(urlMethod, Method.GET);
            request.AddParameter("Signature", apiCode.Signature);
            request.AddParameter("Nonce", apiCode.Nonce);
            request.AddParameter("Timestamp", apiCode.Timestamp);
            return request;
        }
    }
}
