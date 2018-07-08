using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;

namespace PPYC.Model
{
    public class XmlResponseParser
    {
        public static T DoParse<T>(string xmlOrigin)
        {
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(xmlOrigin); // suppose that myXmlString contains "<Names>...</Names>"
            string json = xml.InnerText;
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
