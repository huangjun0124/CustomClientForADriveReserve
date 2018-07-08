using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPYC.Model;
using RestSharp;

namespace PPYC.ServerInteract
{
    public class GetApiCode
    {
        public static GetApiCodeResult DoJob()
        {
           return RequestClient.DoRequest<GetApiCodeResult>(UrlManager.GetApiCode, Method.GET);
        }
    }
}
