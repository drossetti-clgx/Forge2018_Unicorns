using Forge2018Connectivity.GAARRequestGenerator;
using Forge2018Connectivity.GAARResponseHandler;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

        public static string SerializeJson(object requestObj)
        {
            return JsonConvert.SerializeObject(requestObj);
        }

        public static T DeserializeJson<T>(string inputJson)
        {
            return JsonConvert.DeserializeObject<T>(inputJson);
        }

        public static async Task<string> PostRequestToGAARRover(string xmlContent)
        {
            var client = new RestClient("https://devdata.fncinc.com/cdnarover/dna_runService.ashx");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "text/plain");

            if (xmlContent != null) request.AddParameter("plain/text", xmlContent, ParameterType.RequestBody);

            // Post and wait for response
            string response = client.Execute(request).Content;
            return response;
        }

        /// <summary>
        /// Returns Updated Json Dto string
        /// </summary>
        /// <param name="orderCalculationsDataDtoJsonString"></param>
        /// <param name="inputUserMismo"></param>
        /// <returns></returns>
        public static async Task<string> ExtractInformationFromAppraisalMISMO(string orderCalculationsDataDtoJsonString, string inputUserMismo)
        {
            var orderCalculationsDataObject = DeserializeJson<OrderCalculationDataDto>(orderCalculationsDataDtoJsonString);
            var userMismoXmlObject = DeserializeXml<UserMismoXMLMappingDto>(inputUserMismo);

            //address information
            orderCalculationsDataObject.StreetAddress = userMismoXmlObject.SUBJECT.ADDR.STREET;
            orderCalculationsDataObject.City = userMismoXmlObject.SUBJECT.ADDR.CITY;
            orderCalculationsDataObject.State = userMismoXmlObject.SUBJECT.ADDR.STATEPROV;
            orderCalculationsDataObject.Zip = userMismoXmlObject.SUBJECT.ADDR.ZIP;

            //ESTMARKETVALUE
            orderCalculationsDataObject.AppraisedValue = userMismoXmlObject.RECONCIL.INDICATEDVALUESALES;

            //FORMINFO
            orderCalculationsDataObject.FormType = userMismoXmlObject.FORMNUM;

            //BORROWER
            orderCalculationsDataObject.BorrowerName = userMismoXmlObject.SUBJECT.BORROWER;

            return SerializeJson(orderCalculationsDataObject);
        }

        /// <summary>
        /// Returns Updated Json Dto string
        /// </summary>
        /// <param name="orderCalculationsDataDtoJsonString"></param>
        /// <param name="inputUserMismo"></param>
        /// <returns></returns>
        public static async Task<string> ExtractInformationFromGAARResponse(string orderCalculationsDataDtoJsonString, string responseGAARRoverString)
        {
            var orderCalculationsDataObject = DeserializeJson<OrderCalculationDataDto>(orderCalculationsDataDtoJsonString);
            var roverResponseXMLObject = DeserializeXml<GAARRoverResponseDto>(responseGAARRoverString);

            //GAAR Score
            orderCalculationsDataObject.GAARScore = roverResponseXMLObject.ResponseDetail.FirstOrDefault(a => a.Item == 1).GaarResult.Scores.First(a => a.Name == "Apsl.GAARScore").Value;


            return SerializeJson(orderCalculationsDataObject);
        }
    }
}
