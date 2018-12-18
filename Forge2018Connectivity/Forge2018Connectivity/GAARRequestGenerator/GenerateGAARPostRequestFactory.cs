using System;
using System.Collections.Generic;
using System.Text;

namespace Forge2018Connectivity.GAARRequestFunctionality
{
    public class GenerateGAARPostRequestFactory
    {
        private StringBuilder FinalGeneratedRequestString = new StringBuilder();
        private string UserMISMOString { get; set; }
        private BaseGAARRequestOuterXMLDto FNCRequestXML { get; set; }

        public GenerateGAARPostRequestFactory(string userMismo)
        {
            this.UserMISMOString = userMismo;
        }

        public static string CreateGAARPostRequestObject(string userMismo)
        {
            var factory = new GenerateGAARPostRequestFactory(userMismo);
            factory.FNCRequestXML = factory.GetFNCRequestXML();
            factory.MergeXMLStrings();
            return factory.FinalGeneratedRequestString.ToString();
        }

        private void MergeXMLStrings()
        {
            FinalGeneratedRequestString.Append(HelperMethods.SerializeXml(FNCRequestXML));
            var startingIndex = FinalGeneratedRequestString.ToString().IndexOf("<FILTERS");
            FinalGeneratedRequestString.Insert(startingIndex, UserMISMOString);
        }

        #region Default Data Generation Methods

        private BaseGAARRequestOuterXMLDto GetFNCRequestXML()
        {
            return new BaseGAARRequestOuterXMLDto
            {
                RqCustomer = "DST-SVCS",
                RqServiceID = "SID_653",
                UTR = "FNC-TEST-TRANS-FNC",
                ASYNC = string.Empty,
                ClientRequest = GetClientRequest()
            };
        }

        private FncDataAnalyticsClientRequest GetClientRequest()
        {
            return new FncDataAnalyticsClientRequest
            {
                Authentication = GetRequestAuthentication(),
                QueryFilters = GetQueryFiltersNode()
            };
        }

        private FncDataAnalyticsClientRequestAuthentication GetRequestAuthentication()
        {
            return new FncDataAnalyticsClientRequestAuthentication
            {
                UserID = "DSTSVCS",
                Password = "83EdUi2"
            };
        }

        private FncDataAnalyticsClientRequestQueryFilters GetQueryFiltersNode()
        {
            return new FncDataAnalyticsClientRequestQueryFilters
            {
                Search = GetQuerySearch(),
                FILTERS = GetQueryFilters(),
                Subject = new object()
            };
        }

        private FncDataAnalyticsClientRequestQueryFiltersSearch GetQuerySearch()
        {
            return new FncDataAnalyticsClientRequestQueryFiltersSearch
            {
                AreaType = string.Empty,
                AreaDetails = string.Empty
            };
        }

        private FncDataAnalyticsClientRequestQueryFiltersFILTERS GetQueryFilters()
        {
            return new FncDataAnalyticsClientRequestQueryFiltersFILTERS
            {
                NAME = "Comp Filter",
                ADD = GetQueryFiltersAddNode()
            };
        }

        private FncDataAnalyticsClientRequestQueryFiltersFILTERSADD GetQueryFiltersAddNode()
        {
            return new FncDataAnalyticsClientRequestQueryFiltersFILTERSADD
            {
                KEY = "RADMAX",
                VALUE = 5.00M
            };
        }

        #endregion
    }
}
