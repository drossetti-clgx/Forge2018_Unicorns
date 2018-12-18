using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Forge2018Connectivity
{
    public class HelperMethods
    {
        public static string SerializeXml(object order)
        {
            var req = new XmlSerializer(order.GetType());

            var sb = new StringBuilder();
            using (var writer = XmlWriter.Create(sb))
            {
                req.Serialize(writer, order);
            }
            return sb.ToString();
        }

        public static T DeserializeXml<T>(string xmlObj)
        {
            var req = new XmlSerializer(typeof(T));
            var tr = new StringReader(xmlObj);
            var reader = XmlReader.Create(tr);
            return (T)req.Deserialize(reader);
        }

        public static async Task<string> PostRequestToGAARRover(string xmlContent)
        {
            var client = new RestClient("https://devdata.fncinc.com/cdnarover/dna_runService.ashx");
            var request = new RestRequest(Method.POST);
            //request.AddHeader("Content-Type", "text/plain");

            if (xmlContent != null) request.AddParameter("plain/text", xmlContent, ParameterType.RequestBody);

            // Post and wait for response
            string response = client.Execute(request).Content;
            return response;
        }
    }
}
