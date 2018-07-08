using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPYC.Model;

namespace PPYC.ServerInteract
{
    public class CommentReserve : ApiGetRequestBase
    {
        /**
         * GET /PCMIS_App.asmx/UpdateApp_CarOrderInfo?&Signature=14fe20b552b80d6c02988fc2e948f49d9c2feb02&Nonce=1215511576&Timestamp=1215511376&RecordID=0155be1d4a394150a00a1c6a099a56ba&GradeType=3&GradeContent=%E5%BE%88%E5%A5%BD&TeacherStar=05&SchoolStar=05&TeacherScoreCodes=050101|050201|050301|050401|050501&SchoolScoreCodes=050101|050201|050301 HTTP/1.1
         */

        public static ModelBase DoComment(ApiCode code, string reserveRecordId)
        {
            var request = GetNewRequest(code, UrlManager.UpdateApp_CarOrderInfo);
            request.AddParameter("RecordID", reserveRecordId);
            request.AddParameter("GradeType", 3);
            request.AddParameter("GradeContent", UrlManager.MyComment);
            request.AddParameter("TeacherStar", "05");
            request.AddParameter("SchoolStar", "05");
            request.AddParameter("TeacherScoreCodes", "050101|050201|050301|050401|050501");
            request.AddParameter("SchoolScoreCodes", "050101|050201|050301");
            return RequestClient.DoWithRequest<ModelBase>(request);
        }
    }
}
