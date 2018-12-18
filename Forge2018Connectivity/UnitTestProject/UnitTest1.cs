using Forge2018Connectivity.GAARRequestFunctionality;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GenerateOuterXMLTest()
        {
            var requestString = GenerateGAARPostRequestFactory.CreateGAARPostRequestObject(string.Empty);
            Trace.Write(requestString);
        }
    }
}
