using Forge2018Connectivity;
using Forge2018Connectivity.GAARRequestFunctionality;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GenerateXMLTest()
        {
            var requestString = GenerateGAARPostRequestFactory.CreateGAARPostRequestObject(File.ReadAllText("MismoXML.xml"));
            Trace.Write(requestString);
        }

        [TestMethod, DeploymentItem(@"MismoXML.xml")]
        public async Task PostGeneratedXMLTest()
        {
            var requestString = GenerateGAARPostRequestFactory.CreateGAARPostRequestObject(File.ReadAllText("MismoXML.xml"));
            var response = await HelperMethods.PostRequestToGAARRover(requestString);
            Trace.Write(response);
        }

        [TestMethod, DeploymentItem(@"MismoXML.xml")]
        public async Task ExtractInformationFromMISMOTest()
        {
            var fileText = File.ReadAllText("MismoXML.xml");
            var jsonString = HelperMethods.ExtractInformationFromAppraisalMISMO(HelperMethods.SerializeJson(new OrderCalculationDataDto()), fileText);
            Trace.Write(jsonString);
        }

        [TestMethod, DeploymentItem(@"MismoXML.xml")]
        public async Task ExtractInformationFromGAARResponseTest()
        {
            var requestString = GenerateGAARPostRequestFactory.CreateGAARPostRequestObject(File.ReadAllText("MismoXML.xml"));
            var response = await HelperMethods.PostRequestToGAARRover(requestString);
            var jsonString = HelperMethods.ExtractInformationFromGAARResponse(HelperMethods.SerializeJson(new OrderCalculationDataDto()), response);
            Trace.Write(jsonString);
        }
    }
}

