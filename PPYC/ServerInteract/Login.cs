using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPYC.Model;
using RestSharp;

namespace PPYC.ServerInteract
{
    public class Login : ApiGetRequestBase
    {
        public static ApiLoginResult DoLogin(ApiCode apiCode)
        {
            var request = GetNewRequest(apiCode, UrlManager.GetLogin);
            request.AddParameter("AppPhoneNumber", LoginParameter.LoginPhoneNumber);
            request.AddParameter("AppPassword", LoginParameter.LoginPassword);
            return RequestClient.DoWithRequest<ApiLoginResult>(request);
        }
    }
}

