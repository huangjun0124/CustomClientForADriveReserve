using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPYC.Model;
using RestSharp;

namespace PPYC.ServerInteract
{
    public class GetTeacherInfo : ApiGetRequestBase
    {
        public static ApiGetTeacherResult Get(ApiCode code, ApiLoginInfo logInfo)
        {
            var request = GetNewRequest(code, UrlManager.GetStudentBindTeachInfo);
            request.AddParameter("AppRecordID", logInfo.RecordID);
           
            return RequestClient.DoWithRequest<ApiGetTeacherResult>(request);
        }
    }
}
