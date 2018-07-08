using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPYC.Model;
using RestSharp;

namespace PPYC
{
    public class RequestClient
    {
        private const string UserAgent = "Dalvik/2.1.0 (Linux; U; Android 8.0.0; APF-110 Build/HUAWEISTF)";
        public static T DoRequest<T>(string invokeMethodName, RestSharp.Method method)
        {
            var client = new RestClient(UrlManager.BaseUrl)
            {
                UserAgent = UserAgent
            };
            var request = new RestRequest(invokeMethodName, method);
            request.RequestFormat = DataFormat.Xml;
            var response = client.Execute(request);
            var result = XmlResponseParser.DoParse<T>(response.Content);
            return result;
        }

        public static T DoWithRequest<T>(RestRequest request)
        {
            var client = new RestClient(UrlManager.BaseUrl)
            {
                UserAgent = UserAgent
            };
            request.RequestFormat = DataFormat.Xml;
            var response = client.Execute(request);
            var result = XmlResponseParser.DoParse<T>(response.Content);
            return result;
        }
    }
}
