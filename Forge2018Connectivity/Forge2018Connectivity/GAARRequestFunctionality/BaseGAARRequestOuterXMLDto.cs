using System;
using System.Collections.Generic;
using System.Text;

namespace Forge2018Connectivity.GAARRequestFunctionality
{
    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(ElementName = "FncDataAnalytics", IsNullable = false)]
    public partial class BaseGAARRequestOuterXMLDto
    {

        /// <remarks/>
        public FncDataAnalyticsClientRequest ClientRequest { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RqCustomer { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RqServiceID { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UTR { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ASYNC { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FncDataAnalyticsClientRequest
    {

        /// <remarks/>
        public FncDataAnalyticsClientRequestAuthentication Authentication { get; set; }

        /// <remarks/>
        public FncDataAnalyticsClientRequestQueryFilters QueryFilters { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FncDataAnalyticsClientRequestAuthentication
    {

        /// <remarks/>
        public string UserID { get; set; }

        /// <remarks/>
        public string Password { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FncDataAnalyticsClientRequestQueryFilters
    {

        /// <remarks/>
        public FncDataAnalyticsClientRequestQueryFiltersSearch Search { get; set; }

        /// <remarks/>
        public FncDataAnalyticsClientRequestQueryFiltersFILTERS FILTERS { get; set; }

        /// <remarks/>
        public object Subject { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FncDataAnalyticsClientRequestQueryFiltersSearch
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AreaType { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AreaDetails { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FncDataAnalyticsClientRequestQueryFiltersFILTERS
    {

        /// <remarks/>
        public FncDataAnalyticsClientRequestQueryFiltersFILTERSADD ADD { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NAME { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FncDataAnalyticsClientRequestQueryFiltersFILTERSADD
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string KEY { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal VALUE { get; set; }
    }


}
