using System;
using System.Collections.Generic;
using System.Text;

namespace Forge2018Connectivity.GAARRequestGenerator
{
    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(ElementName = "FORMINFO", IsNullable = false)]
    public partial class UserMismoXMLMappingDto
    {

        /// <remarks/>
        public FORMINFOSUBJECT SUBJECT { get; set; }

        /// <remarks/>
        public FORMINFOSALESCOMP SALESCOMP { get; set; }

        /// <remarks/>
        public FORMINFOIMPROVEMENTS IMPROVEMENTS { get; set; }

        /// <remarks/>
        public FORMINFOAPPRAISER APPRAISER { get; set; }

        /// <remarks/>
        public FORMINFOSITE SITE { get; set; }

        /// <remarks/>
        public FORMINFORECONCIL RECONCIL { get; set; }

        /// <remarks/>
        public FORMINFOCOSTAPPROACH COSTAPPROACH { get; set; }

        /// <remarks/>
        public FORMINFONBRHOOD NBRHOOD { get; set; }

        /// <remarks/>
        public FORMINFOPUD PUD { get; set; }

        /// <remarks/>
        public FORMINFOCOMMENT COMMENT { get; set; }

        /// <remarks/>
        public FORMINFOLENDERCLIENT LENDERCLIENT { get; set; }

        /// <remarks/>
        public FORMINFOADDENDUMS ADDENDUMS { get; set; }

        /// <remarks/>
        public FORMINFOMINORFORMINFO MINORFORMINFO { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FORMNUM { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FORMVERSION { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VENDOR { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal VERSION { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DOCID { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FILENUM { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OPTOUT { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOSUBJECT
    {

        private FORMINFOSUBJECTADDR aDDRField;

        private string cOUNTYField;

        private string hOMEOWNERASSNFEEField;

        private string tAXYEARField;

        private FORMINFOSUBJECTSALES sALESField;

        private decimal cENSUSTRACTField;

        private string nBRHOODPROJNAMEField;

        private string bORROWERField;

        private string mAPREFField;

        private FORMINFOSUBJECTLOANCHARGE lOANCHARGEField;

        private string cURRENTOCCUPANTField;

        private string pROPRIGHTSField;

        private FORMINFOSUBJECTLEGAL lEGALField;

        private decimal rETAXESField;

        private string cURRENTOWNERField;

        private string sPECIALASSESSField;

        private FORMINFOSUBJECTASSESPARCEL aSSESPARCELField;

        /// <remarks/>
        public FORMINFOSUBJECTADDR ADDR
        {
            get
            {
                return this.aDDRField;
            }
            set
            {
                this.aDDRField = value;
            }
        }

        /// <remarks/>
        public string COUNTY
        {
            get
            {
                return this.cOUNTYField;
            }
            set
            {
                this.cOUNTYField = value;
            }
        }

        /// <remarks/>
        public string HOMEOWNERASSNFEE
        {
            get
            {
                return this.hOMEOWNERASSNFEEField;
            }
            set
            {
                this.hOMEOWNERASSNFEEField = value;
            }
        }

        /// <remarks/>
        public string TAXYEAR
        {
            get
            {
                return this.tAXYEARField;
            }
            set
            {
                this.tAXYEARField = value;
            }
        }

        /// <remarks/>
        public FORMINFOSUBJECTSALES SALES
        {
            get
            {
                return this.sALESField;
            }
            set
            {
                this.sALESField = value;
            }
        }

        /// <remarks/>
        public decimal CENSUSTRACT
        {
            get
            {
                return this.cENSUSTRACTField;
            }
            set
            {
                this.cENSUSTRACTField = value;
            }
        }

        /// <remarks/>
        public string NBRHOODPROJNAME
        {
            get
            {
                return this.nBRHOODPROJNAMEField;
            }
            set
            {
                this.nBRHOODPROJNAMEField = value;
            }
        }

        /// <remarks/>
        public string BORROWER
        {
            get
            {
                return this.bORROWERField;
            }
            set
            {
                this.bORROWERField = value;
            }
        }

        /// <remarks/>
        public string MAPREF
        {
            get
            {
                return this.mAPREFField;
            }
            set
            {
                this.mAPREFField = value;
            }
        }

        /// <remarks/>
        public FORMINFOSUBJECTLOANCHARGE LOANCHARGE
        {
            get
            {
                return this.lOANCHARGEField;
            }
            set
            {
                this.lOANCHARGEField = value;
            }
        }

        /// <remarks/>
        public string CURRENTOCCUPANT
        {
            get
            {
                return this.cURRENTOCCUPANTField;
            }
            set
            {
                this.cURRENTOCCUPANTField = value;
            }
        }

        /// <remarks/>
        public string PROPRIGHTS
        {
            get
            {
                return this.pROPRIGHTSField;
            }
            set
            {
                this.pROPRIGHTSField = value;
            }
        }

        /// <remarks/>
        public FORMINFOSUBJECTLEGAL LEGAL
        {
            get
            {
                return this.lEGALField;
            }
            set
            {
                this.lEGALField = value;
            }
        }

        /// <remarks/>
        public decimal RETAXES
        {
            get
            {
                return this.rETAXESField;
            }
            set
            {
                this.rETAXESField = value;
            }
        }

        /// <remarks/>
        public string CURRENTOWNER
        {
            get
            {
                return this.cURRENTOWNERField;
            }
            set
            {
                this.cURRENTOWNERField = value;
            }
        }

        /// <remarks/>
        public string SPECIALASSESS
        {
            get
            {
                return this.sPECIALASSESSField;
            }
            set
            {
                this.sPECIALASSESSField = value;
            }
        }

        /// <remarks/>
        public FORMINFOSUBJECTASSESPARCEL ASSESPARCEL
        {
            get
            {
                return this.aSSESPARCELField;
            }
            set
            {
                this.aSSESPARCELField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOSUBJECTADDR
    {

        /// <remarks/>
        public string CITY { get; set; }

        /// <remarks/>
        public string STATEPROV { get; set; }

        /// <remarks/>
        public string ZIP { get; set; }

        /// <remarks/>
        public string STREET { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOSUBJECTSALES
    {

        private string pRICEField;

        private string dATEField;

        /// <remarks/>
        public string PRICE
        {
            get
            {
                return this.pRICEField;
            }
            set
            {
                this.pRICEField = value;
            }
        }

        /// <remarks/>
        public string DATE
        {
            get
            {
                return this.dATEField;
            }
            set
            {
                this.dATEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOSUBJECTLOANCHARGE
    {

        private string dESCRIPTIONField;

        /// <remarks/>
        public string DESCRIPTION
        {
            get
            {
                return this.dESCRIPTIONField;
            }
            set
            {
                this.dESCRIPTIONField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOSUBJECTLEGAL
    {

        private string dESCRIPTIONField;

        /// <remarks/>
        public string DESCRIPTION
        {
            get
            {
                return this.dESCRIPTIONField;
            }
            set
            {
                this.dESCRIPTIONField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOSUBJECTASSESPARCEL
    {

        private string nUMField;

        /// <remarks/>
        public string NUM
        {
            get
            {
                return this.nUMField;
            }
            set
            {
                this.nUMField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOSALESCOMP
    {

        private FORMINFOSALESCOMPSUBJECT sUBJECTField;

        private string cOMMENTSALESCOMPAREField;

        private string aNALYSISCURRENTAGREEField;

        private FORMINFOSALESCOMPCOMPS[] cOMPSField;

        /// <remarks/>
        public FORMINFOSALESCOMPSUBJECT SUBJECT
        {
            get
            {
                return this.sUBJECTField;
            }
            set
            {
                this.sUBJECTField = value;
            }
        }

        /// <remarks/>
        public string COMMENTSALESCOMPARE
        {
            get
            {
                return this.cOMMENTSALESCOMPAREField;
            }
            set
            {
                this.cOMMENTSALESCOMPAREField = value;
            }
        }

        /// <remarks/>
        public string ANALYSISCURRENTAGREE
        {
            get
            {
                return this.aNALYSISCURRENTAGREEField;
            }
            set
            {
                this.aNALYSISCURRENTAGREEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("COMPS")]
        public FORMINFOSALESCOMPCOMPS[] COMPS
        {
            get
            {
                return this.cOMPSField;
            }
            set
            {
                this.cOMPSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOSALESCOMPSUBJECT
    {

        private string aGEYRSField;

        private string sITEField;

        private string vIEWField;

        private FORMINFOSALESCOMPSUBJECTABOVEGRADE aBOVEGRADEField;

        private FORMINFOSALESCOMPSUBJECTADDR aDDRField;

        private ushort lIVINGSQFTField;

        private string lOCATIONField;

        private string cONDITIONField;

        private string fENCEPOOLField;

        private string sALESPRICEField;

        private string dATAField;

        private string vERIFICATIONField;

        private decimal pRICEGROSSLIVINGField;

        private string gARAGEField;

        private string lEASEFEEField;

        private string dESIGNSTYLEField;

        private string hEATINGCOOLField;

        private string pORCHPATIOField;

        private string fIREPLACEField;

        private FORMINFOSALESCOMPSUBJECTPRIORSALE pRIORSALEField;

        private string bASEMENTField;

        private string bASEMENTFINISHField;

        private string eNERGYEFFField;

        private string fUNCTIONALField;

        private string cONSTRUCTField;

        /// <remarks/>
        public string AGEYRS
        {
            get
            {
                return this.aGEYRSField;
            }
            set
            {
                this.aGEYRSField = value;
            }
        }

        /// <remarks/>
        public string SITE
        {
            get
            {
                return this.sITEField;
            }
            set
            {
                this.sITEField = value;
            }
        }

        /// <remarks/>
        public string VIEW
        {
            get
            {
                return this.vIEWField;
            }
            set
            {
                this.vIEWField = value;
            }
        }

        /// <remarks/>
        public FORMINFOSALESCOMPSUBJECTABOVEGRADE ABOVEGRADE
        {
            get
            {
                return this.aBOVEGRADEField;
            }
            set
            {
                this.aBOVEGRADEField = value;
            }
        }

        /// <remarks/>
        public FORMINFOSALESCOMPSUBJECTADDR ADDR
        {
            get
            {
                return this.aDDRField;
            }
            set
            {
                this.aDDRField = value;
            }
        }

        /// <remarks/>
        public ushort LIVINGSQFT
        {
            get
            {
                return this.lIVINGSQFTField;
            }
            set
            {
                this.lIVINGSQFTField = value;
            }
        }

        /// <remarks/>
        public string LOCATION
        {
            get
            {
                return this.lOCATIONField;
            }
            set
            {
                this.lOCATIONField = value;
            }
        }

        /// <remarks/>
        public string CONDITION
        {
            get
            {
                return this.cONDITIONField;
            }
            set
            {
                this.cONDITIONField = value;
            }
        }

        /// <remarks/>
        public string FENCEPOOL
        {
            get
            {
                return this.fENCEPOOLField;
            }
            set
            {
                this.fENCEPOOLField = value;
            }
        }

        /// <remarks/>
        public string SALESPRICE
        {
            get
            {
                return this.sALESPRICEField;
            }
            set
            {
                this.sALESPRICEField = value;
            }
        }

        /// <remarks/>
        public string DATA
        {
            get
            {
                return this.dATAField;
            }
            set
            {
                this.dATAField = value;
            }
        }

        /// <remarks/>
        public string VERIFICATION
        {
            get
            {
                return this.vERIFICATIONField;
            }
            set
            {
                this.vERIFICATIONField = value;
            }
        }

        /// <remarks/>
        public decimal PRICEGROSSLIVING
        {
            get
            {
                return this.pRICEGROSSLIVINGField;
            }
            set
            {
                this.pRICEGROSSLIVINGField = value;
            }
        }

        /// <remarks/>
        public string GARAGE
        {
            get
            {
                return this.gARAGEField;
            }
            set
            {
                this.gARAGEField = value;
            }
        }

        /// <remarks/>
        public string LEASEFEE
        {
            get
            {
                return this.lEASEFEEField;
            }
            set
            {
                this.lEASEFEEField = value;
            }
        }

        /// <remarks/>
        public string DESIGNSTYLE
        {
            get
            {
                return this.dESIGNSTYLEField;
            }
            set
            {
                this.dESIGNSTYLEField = value;
            }
        }

        /// <remarks/>
        public string HEATINGCOOL
        {
            get
            {
                return this.hEATINGCOOLField;
            }
            set
            {
                this.hEATINGCOOLField = value;
            }
        }

        /// <remarks/>
        public string PORCHPATIO
        {
            get
            {
                return this.pORCHPATIOField;
            }
            set
            {
                this.pORCHPATIOField = value;
            }
        }

        /// <remarks/>
        public string FIREPLACE
        {
            get
            {
                return this.fIREPLACEField;
            }
            set
            {
                this.fIREPLACEField = value;
            }
        }

        /// <remarks/>
        public FORMINFOSALESCOMPSUBJECTPRIORSALE PRIORSALE
        {
            get
            {
                return this.pRIORSALEField;
            }
            set
            {
                this.pRIORSALEField = value;
            }
        }

        /// <remarks/>
        public string BASEMENT
        {
            get
            {
                return this.bASEMENTField;
            }
            set
            {
                this.bASEMENTField = value;
            }
        }

        /// <remarks/>
        public string BASEMENTFINISH
        {
            get
            {
                return this.bASEMENTFINISHField;
            }
            set
            {
                this.bASEMENTFINISHField = value;
            }
        }

        /// <remarks/>
        public string ENERGYEFF
        {
            get
            {
                return this.eNERGYEFFField;
            }
            set
            {
                this.eNERGYEFFField = value;
            }
        }

        /// <remarks/>
        public string FUNCTIONAL
        {
            get
            {
                return this.fUNCTIONALField;
            }
            set
            {
                this.fUNCTIONALField = value;
            }
        }

        /// <remarks/>
        public string CONSTRUCT
        {
            get
            {
                return this.cONSTRUCTField;
            }
            set
            {
                this.cONSTRUCTField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOSALESCOMPSUBJECTABOVEGRADE
    {

        private decimal bATHField;

        private byte bEDROOMSField;

        private byte rOOMTOTField;

        /// <remarks/>
        public decimal BATH
        {
            get
            {
                return this.bATHField;
            }
            set
            {
                this.bATHField = value;
            }
        }

        /// <remarks/>
        public byte BEDROOMS
        {
            get
            {
                return this.bEDROOMSField;
            }
            set
            {
                this.bEDROOMSField = value;
            }
        }

        /// <remarks/>
        public byte ROOMTOT
        {
            get
            {
                return this.rOOMTOTField;
            }
            set
            {
                this.rOOMTOTField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOSALESCOMPSUBJECTADDR
    {

        private string sTREETField;

        private string cITYField;

        /// <remarks/>
        public string STREET
        {
            get
            {
                return this.sTREETField;
            }
            set
            {
                this.sTREETField = value;
            }
        }

        /// <remarks/>
        public string CITY
        {
            get
            {
                return this.cITYField;
            }
            set
            {
                this.cITYField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOSALESCOMPSUBJECTPRIORSALE
    {

        private string dATEField;

        private string pRICEField;

        /// <remarks/>
        public string DATE
        {
            get
            {
                return this.dATEField;
            }
            set
            {
                this.dATEField = value;
            }
        }

        /// <remarks/>
        public string PRICE
        {
            get
            {
                return this.pRICEField;
            }
            set
            {
                this.pRICEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOSALESCOMPCOMPS
    {

        private FORMINFOSALESCOMPCOMPSAGEYRS aGEYRSField;

        private FORMINFOSALESCOMPCOMPSSITE sITEField;

        private FORMINFOSALESCOMPCOMPSVIEW vIEWField;

        private FORMINFOSALESCOMPCOMPSABOVEGRADE aBOVEGRADEField;

        private FORMINFOSALESCOMPCOMPSADDR aDDRField;

        private FORMINFOSALESCOMPCOMPSLIVINGSQFT lIVINGSQFTField;

        private FORMINFOSALESCOMPCOMPSLOCATION lOCATIONField;

        private FORMINFOSALESCOMPCOMPSCONDITION cONDITIONField;

        private FORMINFOSALESCOMPCOMPSFENCEPOOL fENCEPOOLField;

        private string pROXIMITYField;

        private string sALESPRICEField;

        private FORMINFOSALESCOMPCOMPSNETADJUST nETADJUSTField;

        private string dATAField;

        private string vERIFICATIONField;

        private decimal pRICEGROSSLIVINGField;

        private FORMINFOSALESCOMPCOMPSGARAGE gARAGEField;

        private FORMINFOSALESCOMPCOMPSLEASEFEE lEASEFEEField;

        private uint aDJUSTSALESPRICEField;

        private FORMINFOSALESCOMPCOMPSDESIGNSTYLE dESIGNSTYLEField;

        private FORMINFOSALESCOMPCOMPSHEATINGCOOL hEATINGCOOLField;

        private decimal aDJUSTSALESNETField;

        private FORMINFOSALESCOMPCOMPSPORCHPATIO pORCHPATIOField;

        private FORMINFOSALESCOMPCOMPSFIREPLACE fIREPLACEField;

        private FORMINFOSALESCOMPCOMPSPRIORSALE pRIORSALEField;

        private FORMINFOSALESCOMPCOMPSBASEMENT bASEMENTField;

        private FORMINFOSALESCOMPCOMPSBASEMENTFINISH bASEMENTFINISHField;

        private FORMINFOSALESCOMPCOMPSSALE sALEField;

        private FORMINFOSALESCOMPCOMPSENERGYEFF eNERGYEFFField;

        private FORMINFOSALESCOMPCOMPSFUNCTIONAL fUNCTIONALField;

        private FORMINFOSALESCOMPCOMPSCONSTRUCT cONSTRUCTField;

        private FORMINFOSALESCOMPCOMPSCONCESSIONS cONCESSIONSField;

        private decimal aDJUSTSALESGROSSField;

        private byte cOMPNUMField;

        /// <remarks/>
        public FORMINFOSALESCOMPCOMPSAGEYRS AGEYRS
        {
            get
            {
                return this.aGEYRSField;
            }
            set
            {
                this.aGEYRSField = value;
            }
        }

        /// <remarks/>
        public FORMINFOSALESCOMPCOMPSSITE SITE
        {
            get
            {
                return this.sITEField;
            }
            set
            {
                this.sITEField = value;
            }
        }

        /// <remarks/>
        public FORMINFOSALESCOMPCOMPSVIEW VIEW
        {
            get
            {
                return this.vIEWField;
            }
            set
            {
                this.vIEWField = value;
            }
        }

        /// <remarks/>
        public FORMINFOSALESCOMPCOMPSABOVEGRADE ABOVEGRADE
        {
            get
            {
                return this.aBOVEGRADEField;
            }
            set
            {
                this.aBOVEGRADEField = value;
            }
        }

        /// <remarks/>
        public FORMINFOSALESCOMPCOMPSADDR ADDR
        {
            get
            {
                return this.aDDRField;
            }
            set
            {
                this.aDDRField = value;
            }
        }

        /// <remarks/>
        public FORMINFOSALESCOMPCOMPSLIVINGSQFT LIVINGSQFT
        {
            get
            {
                return this.lIVINGSQFTField;
            }
            set
            {
                this.lIVINGSQFTField = value;
            }
        }

        /// <remarks/>
        public FORMINFOSALESCOMPCOMPSLOCATION LOCATION
        {
            get
            {
                return this.lOCATIONField;
            }
            set
            {
                this.lOCATIONField = value;
            }
        }

        /// <remarks/>
        public FORMINFOSALESCOMPCOMPSCONDITION CONDITION
        {
            get
            {
                return this.cONDITIONField;
            }
            set
            {
                this.cONDITIONField = value;
            }
        }

        /// <remarks/>
        public FORMINFOSALESCOMPCOMPSFENCEPOOL FENCEPOOL
        {
            get
            {
                return this.fENCEPOOLField;
            }
            set
            {
                this.fENCEPOOLField = value;
            }
        }

        /// <remarks/>
        public string PROXIMITY
        {
            get
            {
                return this.pROXIMITYField;
            }
            set
            {
                this.pROXIMITYField = value;
            }
        }

        /// <remarks/>
        public string SALESPRICE
        {
            get
            {
                return this.sALESPRICEField;
            }
            set
            {
                this.sALESPRICEField = value;
            }
        }

        /// <remarks/>
        public FORMINFOSALESCOMPCOMPSNETADJUST NETADJUST
        {
            get
            {
                return this.nETADJUSTField;
            }
            set
            {
                this.nETADJUSTField = value;
            }
        }

        /// <remarks/>
        public string DATA
        {
            get
            {
                return this.dATAField;
            }
            set
            {
                this.dATAField = value;
            }
        }

        /// <remarks/>
        public string VERIFICATION
        {
            get
            {
                return this.vERIFICATIONField;
            }
            set
            {
                this.vERIFICATIONField = value;
            }
        }

        /// <remarks/>
        public decimal PRICEGROSSLIVING
        {
            get
            {
                return this.pRICEGROSSLIVINGField;
            }
            set
            {
                this.pRICEGROSSLIVINGField = value;
            }
        }

        /// <remarks/>
        public FORMINFOSALESCOMPCOMPSGARAGE GARAGE
        {
            get
            {
                return this.gARAGEField;
            }
            set
            {
                this.gARAGEField = value;
            }
        }

        /// <remarks/>
        public FORMINFOSALESCOMPCOMPSLEASEFEE LEASEFEE
        {
            get
            {
                return this.lEASEFEEField;
            }
            set
            {
                this.lEASEFEEField = value;
            }
        }

        /// <remarks/>
        public uint ADJUSTSALESPRICE
        {
            get
            {
                return this.aDJUSTSALESPRICEField;
            }
            set
            {
                this.aDJUSTSALESPRICEField = value;
            }
        }

        /// <remarks/>
        public FORMINFOSALESCOMPCOMPSDESIGNSTYLE DESIGNSTYLE
        {
            get
            {
                return this.dESIGNSTYLEField;
            }
            set
            {
                this.dESIGNSTYLEField = value;
            }
        }

        /// <remarks/>
        public FORMINFOSALESCOMPCOMPSHEATINGCOOL HEATINGCOOL
        {
            get
            {
                return this.hEATINGCOOLField;
            }
            set
            {
                this.hEATINGCOOLField = value;
            }
        }

        /// <remarks/>
        public decimal ADJUSTSALESNET
        {
            get
            {
                return this.aDJUSTSALESNETField;
            }
            set
            {
                this.aDJUSTSALESNETField = value;
            }
        }

        /// <remarks/>
        public FORMINFOSALESCOMPCOMPSPORCHPATIO PORCHPATIO
        {
            get
            {
                return this.pORCHPATIOField;
            }
            set
            {
                this.pORCHPATIOField = value;
            }
        }

        /// <remarks/>
        public FORMINFOSALESCOMPCOMPSFIREPLACE FIREPLACE
        {
            get
            {
                return this.fIREPLACEField;
            }
            set
            {
                this.fIREPLACEField = value;
            }
        }

        /// <remarks/>
        public FORMINFOSALESCOMPCOMPSPRIORSALE PRIORSALE
        {
            get
            {
                return this.pRIORSALEField;
            }
            set
            {
                this.pRIORSALEField = value;
            }
        }

        /// <remarks/>
        public FORMINFOSALESCOMPCOMPSBASEMENT BASEMENT
        {
            get
            {
                return this.bASEMENTField;
            }
            set
            {
                this.bASEMENTField = value;
            }
        }

        /// <remarks/>
        public FORMINFOSALESCOMPCOMPSBASEMENTFINISH BASEMENTFINISH
        {
            get
            {
                return this.bASEMENTFINISHField;
            }
            set
            {
                this.bASEMENTFINISHField = value;
            }
        }

        /// <remarks/>
        public FORMINFOSALESCOMPCOMPSSALE SALE
        {
            get
            {
                return this.sALEField;
            }
            set
            {
                this.sALEField = value;
            }
        }

        /// <remarks/>
        public FORMINFOSALESCOMPCOMPSENERGYEFF ENERGYEFF
        {
            get
            {
                return this.eNERGYEFFField;
            }
            set
            {
                this.eNERGYEFFField = value;
            }
        }

        /// <remarks/>
        public FORMINFOSALESCOMPCOMPSFUNCTIONAL FUNCTIONAL
        {
            get
            {
                return this.fUNCTIONALField;
            }
            set
            {
                this.fUNCTIONALField = value;
            }
        }

        /// <remarks/>
        public FORMINFOSALESCOMPCOMPSCONSTRUCT CONSTRUCT
        {
            get
            {
                return this.cONSTRUCTField;
            }
            set
            {
                this.cONSTRUCTField = value;
            }
        }

        /// <remarks/>
        public FORMINFOSALESCOMPCOMPSCONCESSIONS CONCESSIONS
        {
            get
            {
                return this.cONCESSIONSField;
            }
            set
            {
                this.cONCESSIONSField = value;
            }
        }

        /// <remarks/>
        public decimal ADJUSTSALESGROSS
        {
            get
            {
                return this.aDJUSTSALESGROSSField;
            }
            set
            {
                this.aDJUSTSALESGROSSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte COMPNUM
        {
            get
            {
                return this.cOMPNUMField;
            }
            set
            {
                this.cOMPNUMField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOSALESCOMPCOMPSAGEYRS
    {

        private byte aGEYRSField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte AGEYRS
        {
            get
            {
                return this.aGEYRSField;
            }
            set
            {
                this.aGEYRSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOSALESCOMPCOMPSSITE
    {

        private string dESCRIPTIONField;

        private string aDJUSTField;

        /// <remarks/>
        public string DESCRIPTION
        {
            get
            {
                return this.dESCRIPTIONField;
            }
            set
            {
                this.dESCRIPTIONField = value;
            }
        }

        /// <remarks/>
        public string ADJUST
        {
            get
            {
                return this.aDJUSTField;
            }
            set
            {
                this.aDJUSTField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOSALESCOMPCOMPSVIEW
    {

        private string dESCRIPTIONField;

        /// <remarks/>
        public string DESCRIPTION
        {
            get
            {
                return this.dESCRIPTIONField;
            }
            set
            {
                this.dESCRIPTIONField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOSALESCOMPCOMPSABOVEGRADE
    {

        private byte bATHField;

        private byte bEDROOMSField;

        private short aDJUSTField;

        private byte rOOMTOTField;

        /// <remarks/>
        public byte BATH
        {
            get
            {
                return this.bATHField;
            }
            set
            {
                this.bATHField = value;
            }
        }

        /// <remarks/>
        public byte BEDROOMS
        {
            get
            {
                return this.bEDROOMSField;
            }
            set
            {
                this.bEDROOMSField = value;
            }
        }

        /// <remarks/>
        public short ADJUST
        {
            get
            {
                return this.aDJUSTField;
            }
            set
            {
                this.aDJUSTField = value;
            }
        }

        /// <remarks/>
        public byte ROOMTOT
        {
            get
            {
                return this.rOOMTOTField;
            }
            set
            {
                this.rOOMTOTField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOSALESCOMPCOMPSADDR
    {

        private string sTREETField;

        private string cITYField;

        /// <remarks/>
        public string STREET
        {
            get
            {
                return this.sTREETField;
            }
            set
            {
                this.sTREETField = value;
            }
        }

        /// <remarks/>
        public string CITY
        {
            get
            {
                return this.cITYField;
            }
            set
            {
                this.cITYField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOSALESCOMPCOMPSLIVINGSQFT
    {

        private string sQFTField;

        private ushort aDJUSTField;

        /// <remarks/>
        public string SQFT
        {
            get
            {
                return this.sQFTField;
            }
            set
            {
                this.sQFTField = value;
            }
        }

        /// <remarks/>
        public ushort ADJUST
        {
            get
            {
                return this.aDJUSTField;
            }
            set
            {
                this.aDJUSTField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOSALESCOMPCOMPSLOCATION
    {

        private string dESCRIPTIONField;

        private short aDJUSTField;

        /// <remarks/>
        public string DESCRIPTION
        {
            get
            {
                return this.dESCRIPTIONField;
            }
            set
            {
                this.dESCRIPTIONField = value;
            }
        }

        /// <remarks/>
        public short ADJUST
        {
            get
            {
                return this.aDJUSTField;
            }
            set
            {
                this.aDJUSTField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOSALESCOMPCOMPSCONDITION
    {

        private string dESCRIPTIONField;

        private short aDJUSTField;

        private bool aDJUSTFieldSpecified;

        /// <remarks/>
        public string DESCRIPTION
        {
            get
            {
                return this.dESCRIPTIONField;
            }
            set
            {
                this.dESCRIPTIONField = value;
            }
        }

        /// <remarks/>
        public short ADJUST
        {
            get
            {
                return this.aDJUSTField;
            }
            set
            {
                this.aDJUSTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ADJUSTSpecified
        {
            get
            {
                return this.aDJUSTFieldSpecified;
            }
            set
            {
                this.aDJUSTFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOSALESCOMPCOMPSFENCEPOOL
    {

        private string dESCRIPTIONField;

        /// <remarks/>
        public string DESCRIPTION
        {
            get
            {
                return this.dESCRIPTIONField;
            }
            set
            {
                this.dESCRIPTIONField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOSALESCOMPCOMPSNETADJUST
    {

        private string pOSNEGField;

        private ushort tOTField;

        /// <remarks/>
        public string POSNEG
        {
            get
            {
                return this.pOSNEGField;
            }
            set
            {
                this.pOSNEGField = value;
            }
        }

        /// <remarks/>
        public ushort TOT
        {
            get
            {
                return this.tOTField;
            }
            set
            {
                this.tOTField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOSALESCOMPCOMPSGARAGE
    {

        private string dESCRIPTIONField;

        private short aDJUSTField;

        /// <remarks/>
        public string DESCRIPTION
        {
            get
            {
                return this.dESCRIPTIONField;
            }
            set
            {
                this.dESCRIPTIONField = value;
            }
        }

        /// <remarks/>
        public short ADJUST
        {
            get
            {
                return this.aDJUSTField;
            }
            set
            {
                this.aDJUSTField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOSALESCOMPCOMPSLEASEFEE
    {

        private string dESCRIPTIONField;

        /// <remarks/>
        public string DESCRIPTION
        {
            get
            {
                return this.dESCRIPTIONField;
            }
            set
            {
                this.dESCRIPTIONField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOSALESCOMPCOMPSDESIGNSTYLE
    {

        private string dESCRIPTIONField;

        private short aDJUSTField;

        private bool aDJUSTFieldSpecified;

        /// <remarks/>
        public string DESCRIPTION
        {
            get
            {
                return this.dESCRIPTIONField;
            }
            set
            {
                this.dESCRIPTIONField = value;
            }
        }

        /// <remarks/>
        public short ADJUST
        {
            get
            {
                return this.aDJUSTField;
            }
            set
            {
                this.aDJUSTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ADJUSTSpecified
        {
            get
            {
                return this.aDJUSTFieldSpecified;
            }
            set
            {
                this.aDJUSTFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOSALESCOMPCOMPSHEATINGCOOL
    {

        private string dESCRIPTIONField;

        /// <remarks/>
        public string DESCRIPTION
        {
            get
            {
                return this.dESCRIPTIONField;
            }
            set
            {
                this.dESCRIPTIONField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOSALESCOMPCOMPSPORCHPATIO
    {

        private string dESCRIPTIONField;

        /// <remarks/>
        public string DESCRIPTION
        {
            get
            {
                return this.dESCRIPTIONField;
            }
            set
            {
                this.dESCRIPTIONField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOSALESCOMPCOMPSFIREPLACE
    {

        private string dESCRIPTIONField;

        private short aDJUSTField;

        private bool aDJUSTFieldSpecified;

        /// <remarks/>
        public string DESCRIPTION
        {
            get
            {
                return this.dESCRIPTIONField;
            }
            set
            {
                this.dESCRIPTIONField = value;
            }
        }

        /// <remarks/>
        public short ADJUST
        {
            get
            {
                return this.aDJUSTField;
            }
            set
            {
                this.aDJUSTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ADJUSTSpecified
        {
            get
            {
                return this.aDJUSTFieldSpecified;
            }
            set
            {
                this.aDJUSTFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOSALESCOMPCOMPSPRIORSALE
    {

        private string dATEField;

        private string pRICEField;

        private string dATAField;

        /// <remarks/>
        public string DATE
        {
            get
            {
                return this.dATEField;
            }
            set
            {
                this.dATEField = value;
            }
        }

        /// <remarks/>
        public string PRICE
        {
            get
            {
                return this.pRICEField;
            }
            set
            {
                this.pRICEField = value;
            }
        }

        /// <remarks/>
        public string DATA
        {
            get
            {
                return this.dATAField;
            }
            set
            {
                this.dATAField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOSALESCOMPCOMPSBASEMENT
    {

        private string dESCRIPTIONField;

        /// <remarks/>
        public string DESCRIPTION
        {
            get
            {
                return this.dESCRIPTIONField;
            }
            set
            {
                this.dESCRIPTIONField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOSALESCOMPCOMPSBASEMENTFINISH
    {

        private string dESCRIPTIONField;

        private short aDJUSTField;

        private bool aDJUSTFieldSpecified;

        /// <remarks/>
        public string DESCRIPTION
        {
            get
            {
                return this.dESCRIPTIONField;
            }
            set
            {
                this.dESCRIPTIONField = value;
            }
        }

        /// <remarks/>
        public short ADJUST
        {
            get
            {
                return this.aDJUSTField;
            }
            set
            {
                this.aDJUSTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ADJUSTSpecified
        {
            get
            {
                return this.aDJUSTFieldSpecified;
            }
            set
            {
                this.aDJUSTFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOSALESCOMPCOMPSSALE
    {

        private string dATEField;

        private ushort aDJUSTField;

        /// <remarks/>
        public string DATE
        {
            get
            {
                return this.dATEField;
            }
            set
            {
                this.dATEField = value;
            }
        }

        /// <remarks/>
        public ushort ADJUST
        {
            get
            {
                return this.aDJUSTField;
            }
            set
            {
                this.aDJUSTField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOSALESCOMPCOMPSENERGYEFF
    {

        private string dESCRIPTIONField;

        /// <remarks/>
        public string DESCRIPTION
        {
            get
            {
                return this.dESCRIPTIONField;
            }
            set
            {
                this.dESCRIPTIONField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOSALESCOMPCOMPSFUNCTIONAL
    {

        private string dESCRIPTIONField;

        /// <remarks/>
        public string DESCRIPTION
        {
            get
            {
                return this.dESCRIPTIONField;
            }
            set
            {
                this.dESCRIPTIONField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOSALESCOMPCOMPSCONSTRUCT
    {

        private string dESCRIPTIONField;

        /// <remarks/>
        public string DESCRIPTION
        {
            get
            {
                return this.dESCRIPTIONField;
            }
            set
            {
                this.dESCRIPTIONField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOSALESCOMPCOMPSCONCESSIONS
    {

        private FORMINFOSALESCOMPCOMPSCONCESSIONSSALES sALESField;

        private FORMINFOSALESCOMPCOMPSCONCESSIONSFINANCE fINANCEField;

        /// <remarks/>
        public FORMINFOSALESCOMPCOMPSCONCESSIONSSALES SALES
        {
            get
            {
                return this.sALESField;
            }
            set
            {
                this.sALESField = value;
            }
        }

        /// <remarks/>
        public FORMINFOSALESCOMPCOMPSCONCESSIONSFINANCE FINANCE
        {
            get
            {
                return this.fINANCEField;
            }
            set
            {
                this.fINANCEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOSALESCOMPCOMPSCONCESSIONSSALES
    {

        private string dESCRIPTIONField;

        /// <remarks/>
        public string DESCRIPTION
        {
            get
            {
                return this.dESCRIPTIONField;
            }
            set
            {
                this.dESCRIPTIONField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOSALESCOMPCOMPSCONCESSIONSFINANCE
    {

        private string dESCRIPTIONField;

        /// <remarks/>
        public string DESCRIPTION
        {
            get
            {
                return this.dESCRIPTIONField;
            }
            set
            {
                this.dESCRIPTIONField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOIMPROVEMENTS
    {

        private FORMINFOIMPROVEMENTSAMENITIES aMENITIESField;

        private FORMINFOIMPROVEMENTSCARSTORAGE cARSTORAGEField;

        private FORMINFOIMPROVEMENTSGENERAL gENERALField;

        private FORMINFOIMPROVEMENTSHEATING hEATINGField;

        private FORMINFOIMPROVEMENTSINTERIOR iNTERIORField;

        private FORMINFOIMPROVEMENTSROOMS rOOMSField;

        private FORMINFOIMPROVEMENTSBASEMENT bASEMENTField;

        private FORMINFOIMPROVEMENTSCOOLING cOOLINGField;

        private FORMINFOIMPROVEMENTSFOUNDATION fOUNDATIONField;

        private FORMINFOIMPROVEMENTSINSULATION iNSULATIONField;

        private FORMINFOIMPROVEMENTSEXTERIOR eXTERIORField;

        private FORMINFOIMPROVEMENTSKITCHENEQUIP kITCHENEQUIPField;

        private FORMINFOIMPROVEMENTSATTIC aTTICField;

        private FORMINFOIMPROVEMENTSABOVEGRADE aBOVEGRADEField;

        /// <remarks/>
        public FORMINFOIMPROVEMENTSAMENITIES AMENITIES
        {
            get
            {
                return this.aMENITIESField;
            }
            set
            {
                this.aMENITIESField = value;
            }
        }

        /// <remarks/>
        public FORMINFOIMPROVEMENTSCARSTORAGE CARSTORAGE
        {
            get
            {
                return this.cARSTORAGEField;
            }
            set
            {
                this.cARSTORAGEField = value;
            }
        }

        /// <remarks/>
        public FORMINFOIMPROVEMENTSGENERAL GENERAL
        {
            get
            {
                return this.gENERALField;
            }
            set
            {
                this.gENERALField = value;
            }
        }

        /// <remarks/>
        public FORMINFOIMPROVEMENTSHEATING HEATING
        {
            get
            {
                return this.hEATINGField;
            }
            set
            {
                this.hEATINGField = value;
            }
        }

        /// <remarks/>
        public FORMINFOIMPROVEMENTSINTERIOR INTERIOR
        {
            get
            {
                return this.iNTERIORField;
            }
            set
            {
                this.iNTERIORField = value;
            }
        }

        /// <remarks/>
        public FORMINFOIMPROVEMENTSROOMS ROOMS
        {
            get
            {
                return this.rOOMSField;
            }
            set
            {
                this.rOOMSField = value;
            }
        }

        /// <remarks/>
        public FORMINFOIMPROVEMENTSBASEMENT BASEMENT
        {
            get
            {
                return this.bASEMENTField;
            }
            set
            {
                this.bASEMENTField = value;
            }
        }

        /// <remarks/>
        public FORMINFOIMPROVEMENTSCOOLING COOLING
        {
            get
            {
                return this.cOOLINGField;
            }
            set
            {
                this.cOOLINGField = value;
            }
        }

        /// <remarks/>
        public FORMINFOIMPROVEMENTSFOUNDATION FOUNDATION
        {
            get
            {
                return this.fOUNDATIONField;
            }
            set
            {
                this.fOUNDATIONField = value;
            }
        }

        /// <remarks/>
        public FORMINFOIMPROVEMENTSINSULATION INSULATION
        {
            get
            {
                return this.iNSULATIONField;
            }
            set
            {
                this.iNSULATIONField = value;
            }
        }

        /// <remarks/>
        public FORMINFOIMPROVEMENTSEXTERIOR EXTERIOR
        {
            get
            {
                return this.eXTERIORField;
            }
            set
            {
                this.eXTERIORField = value;
            }
        }

        /// <remarks/>
        public FORMINFOIMPROVEMENTSKITCHENEQUIP KITCHENEQUIP
        {
            get
            {
                return this.kITCHENEQUIPField;
            }
            set
            {
                this.kITCHENEQUIPField = value;
            }
        }

        /// <remarks/>
        public FORMINFOIMPROVEMENTSATTIC ATTIC
        {
            get
            {
                return this.aTTICField;
            }
            set
            {
                this.aTTICField = value;
            }
        }

        /// <remarks/>
        public FORMINFOIMPROVEMENTSABOVEGRADE ABOVEGRADE
        {
            get
            {
                return this.aBOVEGRADEField;
            }
            set
            {
                this.aBOVEGRADEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOIMPROVEMENTSAMENITIES
    {

        private FORMINFOIMPROVEMENTSAMENITIESFENCE fENCEField;

        private FORMINFOIMPROVEMENTSAMENITIESPATIO pATIOField;

        private FORMINFOIMPROVEMENTSAMENITIESPORCH pORCHField;

        private FORMINFOIMPROVEMENTSAMENITIESFIREPLACE fIREPLACEField;

        /// <remarks/>
        public FORMINFOIMPROVEMENTSAMENITIESFENCE FENCE
        {
            get
            {
                return this.fENCEField;
            }
            set
            {
                this.fENCEField = value;
            }
        }

        /// <remarks/>
        public FORMINFOIMPROVEMENTSAMENITIESPATIO PATIO
        {
            get
            {
                return this.pATIOField;
            }
            set
            {
                this.pATIOField = value;
            }
        }

        /// <remarks/>
        public FORMINFOIMPROVEMENTSAMENITIESPORCH PORCH
        {
            get
            {
                return this.pORCHField;
            }
            set
            {
                this.pORCHField = value;
            }
        }

        /// <remarks/>
        public FORMINFOIMPROVEMENTSAMENITIESFIREPLACE FIREPLACE
        {
            get
            {
                return this.fIREPLACEField;
            }
            set
            {
                this.fIREPLACEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOIMPROVEMENTSAMENITIESFENCE
    {

        private string dESCRIPTIONField;

        private string fENCEField;

        /// <remarks/>
        public string DESCRIPTION
        {
            get
            {
                return this.dESCRIPTIONField;
            }
            set
            {
                this.dESCRIPTIONField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FENCE
        {
            get
            {
                return this.fENCEField;
            }
            set
            {
                this.fENCEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOIMPROVEMENTSAMENITIESPATIO
    {

        private string dESCRIPTIONField;

        private string pATIOField;

        /// <remarks/>
        public string DESCRIPTION
        {
            get
            {
                return this.dESCRIPTIONField;
            }
            set
            {
                this.dESCRIPTIONField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PATIO
        {
            get
            {
                return this.pATIOField;
            }
            set
            {
                this.pATIOField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOIMPROVEMENTSAMENITIESPORCH
    {

        private string dESCRIPTIONField;

        private string pORCHField;

        /// <remarks/>
        public string DESCRIPTION
        {
            get
            {
                return this.dESCRIPTIONField;
            }
            set
            {
                this.dESCRIPTIONField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PORCH
        {
            get
            {
                return this.pORCHField;
            }
            set
            {
                this.pORCHField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOIMPROVEMENTSAMENITIESFIREPLACE
    {

        private byte nUMField;

        private string fIREPLACEField;

        /// <remarks/>
        public byte NUM
        {
            get
            {
                return this.nUMField;
            }
            set
            {
                this.nUMField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FIREPLACE
        {
            get
            {
                return this.fIREPLACEField;
            }
            set
            {
                this.fIREPLACEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOIMPROVEMENTSCARSTORAGE
    {

        private FORMINFOIMPROVEMENTSCARSTORAGEGARAGE gARAGEField;

        private string dRIVEWAYField;

        /// <remarks/>
        public FORMINFOIMPROVEMENTSCARSTORAGEGARAGE GARAGE
        {
            get
            {
                return this.gARAGEField;
            }
            set
            {
                this.gARAGEField = value;
            }
        }

        /// <remarks/>
        public string DRIVEWAY
        {
            get
            {
                return this.dRIVEWAYField;
            }
            set
            {
                this.dRIVEWAYField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOIMPROVEMENTSCARSTORAGEGARAGE
    {

        private FORMINFOIMPROVEMENTSCARSTORAGEGARAGECARS cARSField;

        private FORMINFOIMPROVEMENTSCARSTORAGEGARAGEATTACHED aTTACHEDField;

        /// <remarks/>
        public FORMINFOIMPROVEMENTSCARSTORAGEGARAGECARS CARS
        {
            get
            {
                return this.cARSField;
            }
            set
            {
                this.cARSField = value;
            }
        }

        /// <remarks/>
        public FORMINFOIMPROVEMENTSCARSTORAGEGARAGEATTACHED ATTACHED
        {
            get
            {
                return this.aTTACHEDField;
            }
            set
            {
                this.aTTACHEDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOIMPROVEMENTSCARSTORAGEGARAGECARS
    {

        private byte nUMField;

        /// <remarks/>
        public byte NUM
        {
            get
            {
                return this.nUMField;
            }
            set
            {
                this.nUMField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOIMPROVEMENTSCARSTORAGEGARAGEATTACHED
    {

        private FORMINFOIMPROVEMENTSCARSTORAGEGARAGEATTACHEDCARS cARSField;

        /// <remarks/>
        public FORMINFOIMPROVEMENTSCARSTORAGEGARAGEATTACHEDCARS CARS
        {
            get
            {
                return this.cARSField;
            }
            set
            {
                this.cARSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOIMPROVEMENTSCARSTORAGEGARAGEATTACHEDCARS
    {

        private string nUMField;

        /// <remarks/>
        public string NUM
        {
            get
            {
                return this.nUMField;
            }
            set
            {
                this.nUMField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOIMPROVEMENTSGENERAL
    {

        private string tYPEField;

        private string dESIGNSTYLEField;

        private byte aGEYRSField;

        private byte eFFECTIVEAGEYRSField;

        private FORMINFOIMPROVEMENTSGENERALUNITS uNITSField;

        private FORMINFOIMPROVEMENTSGENERALSTORIES sTORIESField;

        private string eXISTINGField;

        /// <remarks/>
        public string TYPE
        {
            get
            {
                return this.tYPEField;
            }
            set
            {
                this.tYPEField = value;
            }
        }

        /// <remarks/>
        public string DESIGNSTYLE
        {
            get
            {
                return this.dESIGNSTYLEField;
            }
            set
            {
                this.dESIGNSTYLEField = value;
            }
        }

        /// <remarks/>
        public byte AGEYRS
        {
            get
            {
                return this.aGEYRSField;
            }
            set
            {
                this.aGEYRSField = value;
            }
        }

        /// <remarks/>
        public byte EFFECTIVEAGEYRS
        {
            get
            {
                return this.eFFECTIVEAGEYRSField;
            }
            set
            {
                this.eFFECTIVEAGEYRSField = value;
            }
        }

        /// <remarks/>
        public FORMINFOIMPROVEMENTSGENERALUNITS UNITS
        {
            get
            {
                return this.uNITSField;
            }
            set
            {
                this.uNITSField = value;
            }
        }

        /// <remarks/>
        public FORMINFOIMPROVEMENTSGENERALSTORIES STORIES
        {
            get
            {
                return this.sTORIESField;
            }
            set
            {
                this.sTORIESField = value;
            }
        }

        /// <remarks/>
        public string EXISTING
        {
            get
            {
                return this.eXISTINGField;
            }
            set
            {
                this.eXISTINGField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOIMPROVEMENTSGENERALUNITS
    {

        private byte nUMField;

        /// <remarks/>
        public byte NUM
        {
            get
            {
                return this.nUMField;
            }
            set
            {
                this.nUMField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOIMPROVEMENTSGENERALSTORIES
    {

        private byte nUMField;

        /// <remarks/>
        public byte NUM
        {
            get
            {
                return this.nUMField;
            }
            set
            {
                this.nUMField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOIMPROVEMENTSHEATING
    {

        private string fUELField;

        private string tYPEField;

        private string cONDITIONField;

        /// <remarks/>
        public string FUEL
        {
            get
            {
                return this.fUELField;
            }
            set
            {
                this.fUELField = value;
            }
        }

        /// <remarks/>
        public string TYPE
        {
            get
            {
                return this.tYPEField;
            }
            set
            {
                this.tYPEField = value;
            }
        }

        /// <remarks/>
        public string CONDITION
        {
            get
            {
                return this.cONDITIONField;
            }
            set
            {
                this.cONDITIONField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOIMPROVEMENTSINTERIOR
    {

        private string tRIMFINISHField;

        private string dOORSField;

        private string wALLSField;

        private string fLOORSField;

        private string bATHFLOORField;

        private string bATHWAINSCOTField;

        /// <remarks/>
        public string TRIMFINISH
        {
            get
            {
                return this.tRIMFINISHField;
            }
            set
            {
                this.tRIMFINISHField = value;
            }
        }

        /// <remarks/>
        public string DOORS
        {
            get
            {
                return this.dOORSField;
            }
            set
            {
                this.dOORSField = value;
            }
        }

        /// <remarks/>
        public string WALLS
        {
            get
            {
                return this.wALLSField;
            }
            set
            {
                this.wALLSField = value;
            }
        }

        /// <remarks/>
        public string FLOORS
        {
            get
            {
                return this.fLOORSField;
            }
            set
            {
                this.fLOORSField = value;
            }
        }

        /// <remarks/>
        public string BATHFLOOR
        {
            get
            {
                return this.bATHFLOORField;
            }
            set
            {
                this.bATHFLOORField = value;
            }
        }

        /// <remarks/>
        public string BATHWAINSCOT
        {
            get
            {
                return this.bATHWAINSCOTField;
            }
            set
            {
                this.bATHWAINSCOTField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOIMPROVEMENTSROOMS
    {

        private FORMINFOIMPROVEMENTSROOMSLEVELONE lEVELONEField;

        private FORMINFOIMPROVEMENTSROOMSLEVELTWO lEVELTWOField;

        private FORMINFOIMPROVEMENTSROOMSUNLABELEDLEVEL uNLABELEDLEVELField;

        private FORMINFOIMPROVEMENTSROOMSBASEMENT bASEMENTField;

        /// <remarks/>
        public FORMINFOIMPROVEMENTSROOMSLEVELONE LEVELONE
        {
            get
            {
                return this.lEVELONEField;
            }
            set
            {
                this.lEVELONEField = value;
            }
        }

        /// <remarks/>
        public FORMINFOIMPROVEMENTSROOMSLEVELTWO LEVELTWO
        {
            get
            {
                return this.lEVELTWOField;
            }
            set
            {
                this.lEVELTWOField = value;
            }
        }

        /// <remarks/>
        public FORMINFOIMPROVEMENTSROOMSUNLABELEDLEVEL UNLABELEDLEVEL
        {
            get
            {
                return this.uNLABELEDLEVELField;
            }
            set
            {
                this.uNLABELEDLEVELField = value;
            }
        }

        /// <remarks/>
        public FORMINFOIMPROVEMENTSROOMSBASEMENT BASEMENT
        {
            get
            {
                return this.bASEMENTField;
            }
            set
            {
                this.bASEMENTField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOIMPROVEMENTSROOMSLEVELONE
    {

        private ushort aREASQFTField;

        private decimal bATHSField;

        private string oTHERField;

        private byte dININGField;

        private byte lIVINGField;

        private byte kITCHENField;

        private byte bEDROOMSField;

        private byte fAMILYROOMField;

        /// <remarks/>
        public ushort AREASQFT
        {
            get
            {
                return this.aREASQFTField;
            }
            set
            {
                this.aREASQFTField = value;
            }
        }

        /// <remarks/>
        public decimal BATHS
        {
            get
            {
                return this.bATHSField;
            }
            set
            {
                this.bATHSField = value;
            }
        }

        /// <remarks/>
        public string OTHER
        {
            get
            {
                return this.oTHERField;
            }
            set
            {
                this.oTHERField = value;
            }
        }

        /// <remarks/>
        public byte DINING
        {
            get
            {
                return this.dININGField;
            }
            set
            {
                this.dININGField = value;
            }
        }

        /// <remarks/>
        public byte LIVING
        {
            get
            {
                return this.lIVINGField;
            }
            set
            {
                this.lIVINGField = value;
            }
        }

        /// <remarks/>
        public byte KITCHEN
        {
            get
            {
                return this.kITCHENField;
            }
            set
            {
                this.kITCHENField = value;
            }
        }

        /// <remarks/>
        public byte BEDROOMS
        {
            get
            {
                return this.bEDROOMSField;
            }
            set
            {
                this.bEDROOMSField = value;
            }
        }

        /// <remarks/>
        public byte FAMILYROOM
        {
            get
            {
                return this.fAMILYROOMField;
            }
            set
            {
                this.fAMILYROOMField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOIMPROVEMENTSROOMSLEVELTWO
    {

        private byte aREASQFTField;

        /// <remarks/>
        public byte AREASQFT
        {
            get
            {
                return this.aREASQFTField;
            }
            set
            {
                this.aREASQFTField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOIMPROVEMENTSROOMSUNLABELEDLEVEL
    {

        private decimal aREASQFTField;

        /// <remarks/>
        public decimal AREASQFT
        {
            get
            {
                return this.aREASQFTField;
            }
            set
            {
                this.aREASQFTField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOIMPROVEMENTSROOMSBASEMENT
    {

        private byte aREASQFTField;

        /// <remarks/>
        public byte AREASQFT
        {
            get
            {
                return this.aREASQFTField;
            }
            set
            {
                this.aREASQFTField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOIMPROVEMENTSBASEMENT
    {

        private string fLOORField;

        private string wALLSField;

        private string cEILINGField;

        private byte aREASQFTField;

        private string oUTSIDEENTRYField;

        private string fINISHEDField;

        /// <remarks/>
        public string FLOOR
        {
            get
            {
                return this.fLOORField;
            }
            set
            {
                this.fLOORField = value;
            }
        }

        /// <remarks/>
        public string WALLS
        {
            get
            {
                return this.wALLSField;
            }
            set
            {
                this.wALLSField = value;
            }
        }

        /// <remarks/>
        public string CEILING
        {
            get
            {
                return this.cEILINGField;
            }
            set
            {
                this.cEILINGField = value;
            }
        }

        /// <remarks/>
        public byte AREASQFT
        {
            get
            {
                return this.aREASQFTField;
            }
            set
            {
                this.aREASQFTField = value;
            }
        }

        /// <remarks/>
        public string OUTSIDEENTRY
        {
            get
            {
                return this.oUTSIDEENTRYField;
            }
            set
            {
                this.oUTSIDEENTRYField = value;
            }
        }

        /// <remarks/>
        public string FINISHED
        {
            get
            {
                return this.fINISHEDField;
            }
            set
            {
                this.fINISHEDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOIMPROVEMENTSCOOLING
    {

        private string oTHERField;

        private string cENTRALField;

        private string cONDITIONField;

        /// <remarks/>
        public string OTHER
        {
            get
            {
                return this.oTHERField;
            }
            set
            {
                this.oTHERField = value;
            }
        }

        /// <remarks/>
        public string CENTRAL
        {
            get
            {
                return this.cENTRALField;
            }
            set
            {
                this.cENTRALField = value;
            }
        }

        /// <remarks/>
        public string CONDITION
        {
            get
            {
                return this.cONDITIONField;
            }
            set
            {
                this.cONDITIONField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOIMPROVEMENTSFOUNDATION
    {

        private string sLABField;

        private string bASEMENTField;

        private string dAMPNESSField;

        private string sUMPPUMPField;

        private string sETTLEMENTField;

        private string cRAWLSPACEField;

        private string iNFESTATIONField;

        /// <remarks/>
        public string SLAB
        {
            get
            {
                return this.sLABField;
            }
            set
            {
                this.sLABField = value;
            }
        }

        /// <remarks/>
        public string BASEMENT
        {
            get
            {
                return this.bASEMENTField;
            }
            set
            {
                this.bASEMENTField = value;
            }
        }

        /// <remarks/>
        public string DAMPNESS
        {
            get
            {
                return this.dAMPNESSField;
            }
            set
            {
                this.dAMPNESSField = value;
            }
        }

        /// <remarks/>
        public string SUMPPUMP
        {
            get
            {
                return this.sUMPPUMPField;
            }
            set
            {
                this.sUMPPUMPField = value;
            }
        }

        /// <remarks/>
        public string SETTLEMENT
        {
            get
            {
                return this.sETTLEMENTField;
            }
            set
            {
                this.sETTLEMENTField = value;
            }
        }

        /// <remarks/>
        public string CRAWLSPACE
        {
            get
            {
                return this.cRAWLSPACEField;
            }
            set
            {
                this.cRAWLSPACEField = value;
            }
        }

        /// <remarks/>
        public string INFESTATION
        {
            get
            {
                return this.iNFESTATIONField;
            }
            set
            {
                this.iNFESTATIONField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOIMPROVEMENTSINSULATION
    {

        private FORMINFOIMPROVEMENTSINSULATIONWALLS wALLSField;

        private FORMINFOIMPROVEMENTSINSULATIONROOF rOOFField;

        private FORMINFOIMPROVEMENTSINSULATIONCEILING cEILINGField;

        /// <remarks/>
        public FORMINFOIMPROVEMENTSINSULATIONWALLS WALLS
        {
            get
            {
                return this.wALLSField;
            }
            set
            {
                this.wALLSField = value;
            }
        }

        /// <remarks/>
        public FORMINFOIMPROVEMENTSINSULATIONROOF ROOF
        {
            get
            {
                return this.rOOFField;
            }
            set
            {
                this.rOOFField = value;
            }
        }

        /// <remarks/>
        public FORMINFOIMPROVEMENTSINSULATIONCEILING CEILING
        {
            get
            {
                return this.cEILINGField;
            }
            set
            {
                this.cEILINGField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOIMPROVEMENTSINSULATIONWALLS
    {

        private string tYPEField;

        private string wALLSField;

        /// <remarks/>
        public string TYPE
        {
            get
            {
                return this.tYPEField;
            }
            set
            {
                this.tYPEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string WALLS
        {
            get
            {
                return this.wALLSField;
            }
            set
            {
                this.wALLSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOIMPROVEMENTSINSULATIONROOF
    {

        private string rOOFField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ROOF
        {
            get
            {
                return this.rOOFField;
            }
            set
            {
                this.rOOFField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOIMPROVEMENTSINSULATIONCEILING
    {

        private string tYPEField;

        private string cEILINGField;

        /// <remarks/>
        public string TYPE
        {
            get
            {
                return this.tYPEField;
            }
            set
            {
                this.tYPEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CEILING
        {
            get
            {
                return this.cEILINGField;
            }
            set
            {
                this.cEILINGField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOIMPROVEMENTSEXTERIOR
    {

        private string wALLSField;

        private string mANUFACTUREDHOUSEField;

        private string fOUNDATIONField;

        private string wINDOWTYPEField;

        private string rOOFSURFACEField;

        private string sTORMSCREENSField;

        private string gUTTERDWNSPTSField;

        /// <remarks/>
        public string WALLS
        {
            get
            {
                return this.wALLSField;
            }
            set
            {
                this.wALLSField = value;
            }
        }

        /// <remarks/>
        public string MANUFACTUREDHOUSE
        {
            get
            {
                return this.mANUFACTUREDHOUSEField;
            }
            set
            {
                this.mANUFACTUREDHOUSEField = value;
            }
        }

        /// <remarks/>
        public string FOUNDATION
        {
            get
            {
                return this.fOUNDATIONField;
            }
            set
            {
                this.fOUNDATIONField = value;
            }
        }

        /// <remarks/>
        public string WINDOWTYPE
        {
            get
            {
                return this.wINDOWTYPEField;
            }
            set
            {
                this.wINDOWTYPEField = value;
            }
        }

        /// <remarks/>
        public string ROOFSURFACE
        {
            get
            {
                return this.rOOFSURFACEField;
            }
            set
            {
                this.rOOFSURFACEField = value;
            }
        }

        /// <remarks/>
        public string STORMSCREENS
        {
            get
            {
                return this.sTORMSCREENSField;
            }
            set
            {
                this.sTORMSCREENSField = value;
            }
        }

        /// <remarks/>
        public string GUTTERDWNSPTS
        {
            get
            {
                return this.gUTTERDWNSPTSField;
            }
            set
            {
                this.gUTTERDWNSPTSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOIMPROVEMENTSKITCHENEQUIP
    {

        private string dISPOSALField;

        private string dISHWASHERField;

        /// <remarks/>
        public string DISPOSAL
        {
            get
            {
                return this.dISPOSALField;
            }
            set
            {
                this.dISPOSALField = value;
            }
        }

        /// <remarks/>
        public string DISHWASHER
        {
            get
            {
                return this.dISHWASHERField;
            }
            set
            {
                this.dISHWASHERField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOIMPROVEMENTSATTIC
    {

        private string sCUTTLEField;

        /// <remarks/>
        public string SCUTTLE
        {
            get
            {
                return this.sCUTTLEField;
            }
            set
            {
                this.sCUTTLEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOIMPROVEMENTSABOVEGRADE
    {

        private byte bEDROOMSField;

        private decimal aREASQFTField;

        private decimal bATHSField;

        private byte rOOMSField;

        /// <remarks/>
        public byte BEDROOMS
        {
            get
            {
                return this.bEDROOMSField;
            }
            set
            {
                this.bEDROOMSField = value;
            }
        }

        /// <remarks/>
        public decimal AREASQFT
        {
            get
            {
                return this.aREASQFTField;
            }
            set
            {
                this.aREASQFTField = value;
            }
        }

        /// <remarks/>
        public decimal BATHS
        {
            get
            {
                return this.bATHSField;
            }
            set
            {
                this.bATHSField = value;
            }
        }

        /// <remarks/>
        public byte ROOMS
        {
            get
            {
                return this.rOOMSField;
            }
            set
            {
                this.rOOMSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOAPPRAISER
    {

        private string nAMEField;

        private FORMINFOAPPRAISERCOMPANY cOMPANYField;

        private FORMINFOAPPRAISERADDR aDDRField;

        private string pHONEField;

        private string eMAILField;

        private FORMINFOAPPRAISERSIGNED sIGNEDField;

        private FORMINFOAPPRAISERSTATELIC sTATELICField;

        private FORMINFOAPPRAISERSTATECERT sTATECERTField;

        private FORMINFOAPPRAISERLICCERTEXP lICCERTEXPField;

        /// <remarks/>
        public string NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }

        /// <remarks/>
        public FORMINFOAPPRAISERCOMPANY COMPANY
        {
            get
            {
                return this.cOMPANYField;
            }
            set
            {
                this.cOMPANYField = value;
            }
        }

        /// <remarks/>
        public FORMINFOAPPRAISERADDR ADDR
        {
            get
            {
                return this.aDDRField;
            }
            set
            {
                this.aDDRField = value;
            }
        }

        /// <remarks/>
        public string PHONE
        {
            get
            {
                return this.pHONEField;
            }
            set
            {
                this.pHONEField = value;
            }
        }

        /// <remarks/>
        public string EMAIL
        {
            get
            {
                return this.eMAILField;
            }
            set
            {
                this.eMAILField = value;
            }
        }

        /// <remarks/>
        public FORMINFOAPPRAISERSIGNED SIGNED
        {
            get
            {
                return this.sIGNEDField;
            }
            set
            {
                this.sIGNEDField = value;
            }
        }

        /// <remarks/>
        public FORMINFOAPPRAISERSTATELIC STATELIC
        {
            get
            {
                return this.sTATELICField;
            }
            set
            {
                this.sTATELICField = value;
            }
        }

        /// <remarks/>
        public FORMINFOAPPRAISERSTATECERT STATECERT
        {
            get
            {
                return this.sTATECERTField;
            }
            set
            {
                this.sTATECERTField = value;
            }
        }

        /// <remarks/>
        public FORMINFOAPPRAISERLICCERTEXP LICCERTEXP
        {
            get
            {
                return this.lICCERTEXPField;
            }
            set
            {
                this.lICCERTEXPField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOAPPRAISERCOMPANY
    {

        private string nAMEField;

        /// <remarks/>
        public string NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOAPPRAISERADDR
    {

        private string sTREETField;

        private string cITYField;

        private string sTATEPROVField;

        private uint zIPField;

        /// <remarks/>
        public string STREET
        {
            get
            {
                return this.sTREETField;
            }
            set
            {
                this.sTREETField = value;
            }
        }

        /// <remarks/>
        public string CITY
        {
            get
            {
                return this.cITYField;
            }
            set
            {
                this.cITYField = value;
            }
        }

        /// <remarks/>
        public string STATEPROV
        {
            get
            {
                return this.sTATEPROVField;
            }
            set
            {
                this.sTATEPROVField = value;
            }
        }

        /// <remarks/>
        public uint ZIP
        {
            get
            {
                return this.zIPField;
            }
            set
            {
                this.zIPField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOAPPRAISERSIGNED
    {

        private string dATEField;

        /// <remarks/>
        public string DATE
        {
            get
            {
                return this.dATEField;
            }
            set
            {
                this.dATEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOAPPRAISERSTATELIC
    {

        private string nUMField;

        private string sTATEPROVField;

        /// <remarks/>
        public string NUM
        {
            get
            {
                return this.nUMField;
            }
            set
            {
                this.nUMField = value;
            }
        }

        /// <remarks/>
        public string STATEPROV
        {
            get
            {
                return this.sTATEPROVField;
            }
            set
            {
                this.sTATEPROVField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOAPPRAISERSTATECERT
    {

        private string nUMField;

        private string sTATEPROVField;

        /// <remarks/>
        public string NUM
        {
            get
            {
                return this.nUMField;
            }
            set
            {
                this.nUMField = value;
            }
        }

        /// <remarks/>
        public string STATEPROV
        {
            get
            {
                return this.sTATEPROVField;
            }
            set
            {
                this.sTATEPROVField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOAPPRAISERLICCERTEXP
    {

        private string dATEField;

        /// <remarks/>
        public string DATE
        {
            get
            {
                return this.dATEField;
            }
            set
            {
                this.dATEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOSITE
    {

        private string aREAField;

        private string sIZEField;

        private string vIEWField;

        private string dRAINAGEField;

        private string sHAPEField;

        private string cOMMENTSAPPARENTField;

        private string dRIVEWAYSURFACEField;

        private FORMINFOSITEFEMA fEMAField;

        private FORMINFOSITEOFFSIGHTIMPROVE oFFSIGHTIMPROVEField;

        private string dIMENSIONSField;

        private string tOPOGRAPHYField;

        private string lANDSCAPINGField;

        private FORMINFOSITEUTILITIES uTILITIESField;

        private FORMINFOSITEZONING zONINGField;

        private string cORNERLOTField;

        private FORMINFOSITEHIGHESTBESTUSE hIGHESTBESTUSEField;

        private string aPPARENTEASEMENTSField;

        /// <remarks/>
        public string AREA
        {
            get
            {
                return this.aREAField;
            }
            set
            {
                this.aREAField = value;
            }
        }

        /// <remarks/>
        public string SIZE
        {
            get
            {
                return this.sIZEField;
            }
            set
            {
                this.sIZEField = value;
            }
        }

        /// <remarks/>
        public string VIEW
        {
            get
            {
                return this.vIEWField;
            }
            set
            {
                this.vIEWField = value;
            }
        }

        /// <remarks/>
        public string DRAINAGE
        {
            get
            {
                return this.dRAINAGEField;
            }
            set
            {
                this.dRAINAGEField = value;
            }
        }

        /// <remarks/>
        public string SHAPE
        {
            get
            {
                return this.sHAPEField;
            }
            set
            {
                this.sHAPEField = value;
            }
        }

        /// <remarks/>
        public string COMMENTSAPPARENT
        {
            get
            {
                return this.cOMMENTSAPPARENTField;
            }
            set
            {
                this.cOMMENTSAPPARENTField = value;
            }
        }

        /// <remarks/>
        public string DRIVEWAYSURFACE
        {
            get
            {
                return this.dRIVEWAYSURFACEField;
            }
            set
            {
                this.dRIVEWAYSURFACEField = value;
            }
        }

        /// <remarks/>
        public FORMINFOSITEFEMA FEMA
        {
            get
            {
                return this.fEMAField;
            }
            set
            {
                this.fEMAField = value;
            }
        }

        /// <remarks/>
        public FORMINFOSITEOFFSIGHTIMPROVE OFFSIGHTIMPROVE
        {
            get
            {
                return this.oFFSIGHTIMPROVEField;
            }
            set
            {
                this.oFFSIGHTIMPROVEField = value;
            }
        }

        /// <remarks/>
        public string DIMENSIONS
        {
            get
            {
                return this.dIMENSIONSField;
            }
            set
            {
                this.dIMENSIONSField = value;
            }
        }

        /// <remarks/>
        public string TOPOGRAPHY
        {
            get
            {
                return this.tOPOGRAPHYField;
            }
            set
            {
                this.tOPOGRAPHYField = value;
            }
        }

        /// <remarks/>
        public string LANDSCAPING
        {
            get
            {
                return this.lANDSCAPINGField;
            }
            set
            {
                this.lANDSCAPINGField = value;
            }
        }

        /// <remarks/>
        public FORMINFOSITEUTILITIES UTILITIES
        {
            get
            {
                return this.uTILITIESField;
            }
            set
            {
                this.uTILITIESField = value;
            }
        }

        /// <remarks/>
        public FORMINFOSITEZONING ZONING
        {
            get
            {
                return this.zONINGField;
            }
            set
            {
                this.zONINGField = value;
            }
        }

        /// <remarks/>
        public string CORNERLOT
        {
            get
            {
                return this.cORNERLOTField;
            }
            set
            {
                this.cORNERLOTField = value;
            }
        }

        /// <remarks/>
        public FORMINFOSITEHIGHESTBESTUSE HIGHESTBESTUSE
        {
            get
            {
                return this.hIGHESTBESTUSEField;
            }
            set
            {
                this.hIGHESTBESTUSEField = value;
            }
        }

        /// <remarks/>
        public string APPARENTEASEMENTS
        {
            get
            {
                return this.aPPARENTEASEMENTSField;
            }
            set
            {
                this.aPPARENTEASEMENTSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOSITEFEMA
    {

        private string zONEField;

        private FORMINFOSITEFEMAMAP mAPField;

        private string fLOODHAZARDField;

        /// <remarks/>
        public string ZONE
        {
            get
            {
                return this.zONEField;
            }
            set
            {
                this.zONEField = value;
            }
        }

        /// <remarks/>
        public FORMINFOSITEFEMAMAP MAP
        {
            get
            {
                return this.mAPField;
            }
            set
            {
                this.mAPField = value;
            }
        }

        /// <remarks/>
        public string FLOODHAZARD
        {
            get
            {
                return this.fLOODHAZARDField;
            }
            set
            {
                this.fLOODHAZARDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOSITEFEMAMAP
    {

        private string dATEField;

        private string nUMField;

        /// <remarks/>
        public string DATE
        {
            get
            {
                return this.dATEField;
            }
            set
            {
                this.dATEField = value;
            }
        }

        /// <remarks/>
        public string NUM
        {
            get
            {
                return this.nUMField;
            }
            set
            {
                this.nUMField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOSITEOFFSIGHTIMPROVE
    {

        private FORMINFOSITEOFFSIGHTIMPROVEALLEY aLLEYField;

        private FORMINFOSITEOFFSIGHTIMPROVESTREET sTREETField;

        private FORMINFOSITEOFFSIGHTIMPROVESIDEWALK sIDEWALKField;

        private FORMINFOSITEOFFSIGHTIMPROVESTREETLIGHT sTREETLIGHTField;

        private FORMINFOSITEOFFSIGHTIMPROVECURBGUTTER cURBGUTTERField;

        /// <remarks/>
        public FORMINFOSITEOFFSIGHTIMPROVEALLEY ALLEY
        {
            get
            {
                return this.aLLEYField;
            }
            set
            {
                this.aLLEYField = value;
            }
        }

        /// <remarks/>
        public FORMINFOSITEOFFSIGHTIMPROVESTREET STREET
        {
            get
            {
                return this.sTREETField;
            }
            set
            {
                this.sTREETField = value;
            }
        }

        /// <remarks/>
        public FORMINFOSITEOFFSIGHTIMPROVESIDEWALK SIDEWALK
        {
            get
            {
                return this.sIDEWALKField;
            }
            set
            {
                this.sIDEWALKField = value;
            }
        }

        /// <remarks/>
        public FORMINFOSITEOFFSIGHTIMPROVESTREETLIGHT STREETLIGHT
        {
            get
            {
                return this.sTREETLIGHTField;
            }
            set
            {
                this.sTREETLIGHTField = value;
            }
        }

        /// <remarks/>
        public FORMINFOSITEOFFSIGHTIMPROVECURBGUTTER CURBGUTTER
        {
            get
            {
                return this.cURBGUTTERField;
            }
            set
            {
                this.cURBGUTTERField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOSITEOFFSIGHTIMPROVEALLEY
    {

        private string tYPEField;

        /// <remarks/>
        public string TYPE
        {
            get
            {
                return this.tYPEField;
            }
            set
            {
                this.tYPEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOSITEOFFSIGHTIMPROVESTREET
    {

        private string tYPEField;

        private string pUBLICPRIVATEField;

        /// <remarks/>
        public string TYPE
        {
            get
            {
                return this.tYPEField;
            }
            set
            {
                this.tYPEField = value;
            }
        }

        /// <remarks/>
        public string PUBLICPRIVATE
        {
            get
            {
                return this.pUBLICPRIVATEField;
            }
            set
            {
                this.pUBLICPRIVATEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOSITEOFFSIGHTIMPROVESIDEWALK
    {

        private string tYPEField;

        /// <remarks/>
        public string TYPE
        {
            get
            {
                return this.tYPEField;
            }
            set
            {
                this.tYPEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOSITEOFFSIGHTIMPROVESTREETLIGHT
    {

        private string tYPEField;

        private string pUBLICPRIVATEField;

        /// <remarks/>
        public string TYPE
        {
            get
            {
                return this.tYPEField;
            }
            set
            {
                this.tYPEField = value;
            }
        }

        /// <remarks/>
        public string PUBLICPRIVATE
        {
            get
            {
                return this.pUBLICPRIVATEField;
            }
            set
            {
                this.pUBLICPRIVATEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOSITEOFFSIGHTIMPROVECURBGUTTER
    {

        private string tYPEField;

        private string pUBLICPRIVATEField;

        /// <remarks/>
        public string TYPE
        {
            get
            {
                return this.tYPEField;
            }
            set
            {
                this.tYPEField = value;
            }
        }

        /// <remarks/>
        public string PUBLICPRIVATE
        {
            get
            {
                return this.pUBLICPRIVATEField;
            }
            set
            {
                this.pUBLICPRIVATEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOSITEUTILITIES
    {

        private FORMINFOSITEUTILITIESWATER wATERField;

        private FORMINFOSITEUTILITIESGAS gASField;

        private FORMINFOSITEUTILITIESELECTRIC eLECTRICField;

        private FORMINFOSITEUTILITIESSANITARYSEWER sANITARYSEWERField;

        private FORMINFOSITEUTILITIESSTORMSEWER sTORMSEWERField;

        /// <remarks/>
        public FORMINFOSITEUTILITIESWATER WATER
        {
            get
            {
                return this.wATERField;
            }
            set
            {
                this.wATERField = value;
            }
        }

        /// <remarks/>
        public FORMINFOSITEUTILITIESGAS GAS
        {
            get
            {
                return this.gASField;
            }
            set
            {
                this.gASField = value;
            }
        }

        /// <remarks/>
        public FORMINFOSITEUTILITIESELECTRIC ELECTRIC
        {
            get
            {
                return this.eLECTRICField;
            }
            set
            {
                this.eLECTRICField = value;
            }
        }

        /// <remarks/>
        public FORMINFOSITEUTILITIESSANITARYSEWER SANITARYSEWER
        {
            get
            {
                return this.sANITARYSEWERField;
            }
            set
            {
                this.sANITARYSEWERField = value;
            }
        }

        /// <remarks/>
        public FORMINFOSITEUTILITIESSTORMSEWER STORMSEWER
        {
            get
            {
                return this.sTORMSEWERField;
            }
            set
            {
                this.sTORMSEWERField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOSITEUTILITIESWATER
    {

        private string pUBLICField;

        /// <remarks/>
        public string PUBLIC
        {
            get
            {
                return this.pUBLICField;
            }
            set
            {
                this.pUBLICField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOSITEUTILITIESGAS
    {

        private string pUBLICField;

        /// <remarks/>
        public string PUBLIC
        {
            get
            {
                return this.pUBLICField;
            }
            set
            {
                this.pUBLICField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOSITEUTILITIESELECTRIC
    {

        private string pUBLICField;

        /// <remarks/>
        public string PUBLIC
        {
            get
            {
                return this.pUBLICField;
            }
            set
            {
                this.pUBLICField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOSITEUTILITIESSANITARYSEWER
    {

        private string pUBLICField;

        /// <remarks/>
        public string PUBLIC
        {
            get
            {
                return this.pUBLICField;
            }
            set
            {
                this.pUBLICField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOSITEUTILITIESSTORMSEWER
    {

        private string pUBLICField;

        /// <remarks/>
        public string PUBLIC
        {
            get
            {
                return this.pUBLICField;
            }
            set
            {
                this.pUBLICField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOSITEZONING
    {

        private string cOMPLIANCEField;

        private string sPECIFICField;

        /// <remarks/>
        public string COMPLIANCE
        {
            get
            {
                return this.cOMPLIANCEField;
            }
            set
            {
                this.cOMPLIANCEField = value;
            }
        }

        /// <remarks/>
        public string SPECIFIC
        {
            get
            {
                return this.sPECIFICField;
            }
            set
            {
                this.sPECIFICField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOSITEHIGHESTBESTUSE
    {

        private string hIGHESTBESTUSEField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string HIGHESTBESTUSE
        {
            get
            {
                return this.hIGHESTBESTUSEField;
            }
            set
            {
                this.hIGHESTBESTUSEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFORECONCIL
    {

        private FORMINFORECONCILESTMARKETVALUE eSTMARKETVALUEField;

        private string aPPRAISALMADEField;

        private string iNDICATEDVALUESALESField;

        private FORMINFORECONCILINDICATEDVALUEINCOME iNDICATEDVALUEINCOMEField;

        private string cONDITIONAPPRAISALField;

        private string fINALRECONField;

        private string fORMREVISEDField;

        /// <remarks/>
        public FORMINFORECONCILESTMARKETVALUE ESTMARKETVALUE
        {
            get
            {
                return this.eSTMARKETVALUEField;
            }
            set
            {
                this.eSTMARKETVALUEField = value;
            }
        }

        /// <remarks/>
        public string APPRAISALMADE
        {
            get
            {
                return this.aPPRAISALMADEField;
            }
            set
            {
                this.aPPRAISALMADEField = value;
            }
        }

        /// <remarks/>
        public string INDICATEDVALUESALES
        {
            get
            {
                return this.iNDICATEDVALUESALESField;
            }
            set
            {
                this.iNDICATEDVALUESALESField = value;
            }
        }

        /// <remarks/>
        public FORMINFORECONCILINDICATEDVALUEINCOME INDICATEDVALUEINCOME
        {
            get
            {
                return this.iNDICATEDVALUEINCOMEField;
            }
            set
            {
                this.iNDICATEDVALUEINCOMEField = value;
            }
        }

        /// <remarks/>
        public string CONDITIONAPPRAISAL
        {
            get
            {
                return this.cONDITIONAPPRAISALField;
            }
            set
            {
                this.cONDITIONAPPRAISALField = value;
            }
        }

        /// <remarks/>
        public string FINALRECON
        {
            get
            {
                return this.fINALRECONField;
            }
            set
            {
                this.fINALRECONField = value;
            }
        }

        /// <remarks/>
        public string FORMREVISED
        {
            get
            {
                return this.fORMREVISEDField;
            }
            set
            {
                this.fORMREVISEDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFORECONCILESTMARKETVALUE
    {

        private string dATEField;

        private string aMTField;

        /// <remarks/>
        public string DATE
        {
            get
            {
                return this.dATEField;
            }
            set
            {
                this.dATEField = value;
            }
        }

        /// <remarks/>
        public string AMT
        {
            get
            {
                return this.aMTField;
            }
            set
            {
                this.aMTField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFORECONCILINDICATEDVALUEINCOME
    {

        private string tOTField;

        private string rENTMULTIPLIERField;

        private string eSTMARKETRENTField;

        /// <remarks/>
        public string TOT
        {
            get
            {
                return this.tOTField;
            }
            set
            {
                this.tOTField = value;
            }
        }

        /// <remarks/>
        public string RENTMULTIPLIER
        {
            get
            {
                return this.rENTMULTIPLIERField;
            }
            set
            {
                this.rENTMULTIPLIERField = value;
            }
        }

        /// <remarks/>
        public string ESTMARKETRENT
        {
            get
            {
                return this.eSTMARKETRENTField;
            }
            set
            {
                this.eSTMARKETRENTField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOCOSTAPPROACH
    {

        private FORMINFOCOSTAPPROACHDWELLINGTHREE dWELLINGTHREEField;

        private string cOMMENTSONCOSTField;

        private uint iNDICATEDVALUECOSTField;

        private ushort dEPRECIATEDVALUEIMPROVEField;

        private FORMINFOCOSTAPPROACHDWELLINGONE dWELLINGONEField;

        private FORMINFOCOSTAPPROACHDWELLINGTWO dWELLINGTWOField;

        private FORMINFOCOSTAPPROACHDEPRECIATION dEPRECIATIONField;

        private ushort aSISVALUEField;

        private ushort eSTSITEVALUEField;

        private FORMINFOCOSTAPPROACHGARAGE gARAGEField;

        private uint tOTESTCOSTNEWField;

        /// <remarks/>
        public FORMINFOCOSTAPPROACHDWELLINGTHREE DWELLINGTHREE
        {
            get
            {
                return this.dWELLINGTHREEField;
            }
            set
            {
                this.dWELLINGTHREEField = value;
            }
        }

        /// <remarks/>
        public string COMMENTSONCOST
        {
            get
            {
                return this.cOMMENTSONCOSTField;
            }
            set
            {
                this.cOMMENTSONCOSTField = value;
            }
        }

        /// <remarks/>
        public uint INDICATEDVALUECOST
        {
            get
            {
                return this.iNDICATEDVALUECOSTField;
            }
            set
            {
                this.iNDICATEDVALUECOSTField = value;
            }
        }

        /// <remarks/>
        public ushort DEPRECIATEDVALUEIMPROVE
        {
            get
            {
                return this.dEPRECIATEDVALUEIMPROVEField;
            }
            set
            {
                this.dEPRECIATEDVALUEIMPROVEField = value;
            }
        }

        /// <remarks/>
        public FORMINFOCOSTAPPROACHDWELLINGONE DWELLINGONE
        {
            get
            {
                return this.dWELLINGONEField;
            }
            set
            {
                this.dWELLINGONEField = value;
            }
        }

        /// <remarks/>
        public FORMINFOCOSTAPPROACHDWELLINGTWO DWELLINGTWO
        {
            get
            {
                return this.dWELLINGTWOField;
            }
            set
            {
                this.dWELLINGTWOField = value;
            }
        }

        /// <remarks/>
        public FORMINFOCOSTAPPROACHDEPRECIATION DEPRECIATION
        {
            get
            {
                return this.dEPRECIATIONField;
            }
            set
            {
                this.dEPRECIATIONField = value;
            }
        }

        /// <remarks/>
        public ushort ASISVALUE
        {
            get
            {
                return this.aSISVALUEField;
            }
            set
            {
                this.aSISVALUEField = value;
            }
        }

        /// <remarks/>
        public ushort ESTSITEVALUE
        {
            get
            {
                return this.eSTSITEVALUEField;
            }
            set
            {
                this.eSTSITEVALUEField = value;
            }
        }

        /// <remarks/>
        public FORMINFOCOSTAPPROACHGARAGE GARAGE
        {
            get
            {
                return this.gARAGEField;
            }
            set
            {
                this.gARAGEField = value;
            }
        }

        /// <remarks/>
        public uint TOTESTCOSTNEW
        {
            get
            {
                return this.tOTESTCOSTNEWField;
            }
            set
            {
                this.tOTESTCOSTNEWField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOCOSTAPPROACHDWELLINGTHREE
    {

        private ushort aMTTOTField;

        private string dESCRIPTIONField;

        /// <remarks/>
        public ushort AMTTOT
        {
            get
            {
                return this.aMTTOTField;
            }
            set
            {
                this.aMTTOTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DESCRIPTION
        {
            get
            {
                return this.dESCRIPTIONField;
            }
            set
            {
                this.dESCRIPTIONField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOCOSTAPPROACHDWELLINGONE
    {

        private uint aMTTOTField;

        private ushort sQFTField;

        private decimal sQFTAMTField;

        /// <remarks/>
        public uint AMTTOT
        {
            get
            {
                return this.aMTTOTField;
            }
            set
            {
                this.aMTTOTField = value;
            }
        }

        /// <remarks/>
        public ushort SQFT
        {
            get
            {
                return this.sQFTField;
            }
            set
            {
                this.sQFTField = value;
            }
        }

        /// <remarks/>
        public decimal SQFTAMT
        {
            get
            {
                return this.sQFTAMTField;
            }
            set
            {
                this.sQFTAMTField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOCOSTAPPROACHDWELLINGTWO
    {

        private byte aMTTOTField;

        private byte sQFTField;

        private string dESCRIPTIONField;

        /// <remarks/>
        public byte AMTTOT
        {
            get
            {
                return this.aMTTOTField;
            }
            set
            {
                this.aMTTOTField = value;
            }
        }

        /// <remarks/>
        public byte SQFT
        {
            get
            {
                return this.sQFTField;
            }
            set
            {
                this.sQFTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DESCRIPTION
        {
            get
            {
                return this.dESCRIPTIONField;
            }
            set
            {
                this.dESCRIPTIONField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOCOSTAPPROACHDEPRECIATION
    {

        private ushort tOTField;

        private ushort pHYSICALField;

        /// <remarks/>
        public ushort TOT
        {
            get
            {
                return this.tOTField;
            }
            set
            {
                this.tOTField = value;
            }
        }

        /// <remarks/>
        public ushort PHYSICAL
        {
            get
            {
                return this.pHYSICALField;
            }
            set
            {
                this.pHYSICALField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOCOSTAPPROACHGARAGE
    {

        private ushort aMTTOTField;

        private ushort sQFTField;

        private decimal sQFTAMTField;

        /// <remarks/>
        public ushort AMTTOT
        {
            get
            {
                return this.aMTTOTField;
            }
            set
            {
                this.aMTTOTField = value;
            }
        }

        /// <remarks/>
        public ushort SQFT
        {
            get
            {
                return this.sQFTField;
            }
            set
            {
                this.sQFTField = value;
            }
        }

        /// <remarks/>
        public decimal SQFTAMT
        {
            get
            {
                return this.sQFTAMTField;
            }
            set
            {
                this.sQFTAMTField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFONBRHOOD
    {

        private FORMINFONBRHOODSINGLEFAM sINGLEFAMField;

        private string nBRHOODBOUNDARIESField;

        private FORMINFONBRHOODLANDUSE lANDUSEField;

        private string fACTORSMARKETABILITYField;

        private FORMINFONBRHOODOCCUPANCY oCCUPANCYField;

        private string mARKETCONDITIONSField;

        private string dEMANDSUPPLYField;

        private string gROWTHRATEField;

        private string bUILTUPField;

        private string pROPVALUESField;

        private string lOCATIONField;

        private string mARKETINGTIMEField;

        private string lANDUSECHANGEField;

        /// <remarks/>
        public FORMINFONBRHOODSINGLEFAM SINGLEFAM
        {
            get
            {
                return this.sINGLEFAMField;
            }
            set
            {
                this.sINGLEFAMField = value;
            }
        }

        /// <remarks/>
        public string NBRHOODBOUNDARIES
        {
            get
            {
                return this.nBRHOODBOUNDARIESField;
            }
            set
            {
                this.nBRHOODBOUNDARIESField = value;
            }
        }

        /// <remarks/>
        public FORMINFONBRHOODLANDUSE LANDUSE
        {
            get
            {
                return this.lANDUSEField;
            }
            set
            {
                this.lANDUSEField = value;
            }
        }

        /// <remarks/>
        public string FACTORSMARKETABILITY
        {
            get
            {
                return this.fACTORSMARKETABILITYField;
            }
            set
            {
                this.fACTORSMARKETABILITYField = value;
            }
        }

        /// <remarks/>
        public FORMINFONBRHOODOCCUPANCY OCCUPANCY
        {
            get
            {
                return this.oCCUPANCYField;
            }
            set
            {
                this.oCCUPANCYField = value;
            }
        }

        /// <remarks/>
        public string MARKETCONDITIONS
        {
            get
            {
                return this.mARKETCONDITIONSField;
            }
            set
            {
                this.mARKETCONDITIONSField = value;
            }
        }

        /// <remarks/>
        public string DEMANDSUPPLY
        {
            get
            {
                return this.dEMANDSUPPLYField;
            }
            set
            {
                this.dEMANDSUPPLYField = value;
            }
        }

        /// <remarks/>
        public string GROWTHRATE
        {
            get
            {
                return this.gROWTHRATEField;
            }
            set
            {
                this.gROWTHRATEField = value;
            }
        }

        /// <remarks/>
        public string BUILTUP
        {
            get
            {
                return this.bUILTUPField;
            }
            set
            {
                this.bUILTUPField = value;
            }
        }

        /// <remarks/>
        public string PROPVALUES
        {
            get
            {
                return this.pROPVALUESField;
            }
            set
            {
                this.pROPVALUESField = value;
            }
        }

        /// <remarks/>
        public string LOCATION
        {
            get
            {
                return this.lOCATIONField;
            }
            set
            {
                this.lOCATIONField = value;
            }
        }

        /// <remarks/>
        public string MARKETINGTIME
        {
            get
            {
                return this.mARKETINGTIMEField;
            }
            set
            {
                this.mARKETINGTIMEField = value;
            }
        }

        /// <remarks/>
        public string LANDUSECHANGE
        {
            get
            {
                return this.lANDUSECHANGEField;
            }
            set
            {
                this.lANDUSECHANGEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFONBRHOODSINGLEFAM
    {

        private FORMINFONBRHOODSINGLEFAMAGE aGEField;

        private FORMINFONBRHOODSINGLEFAMPRICE pRICEField;

        /// <remarks/>
        public FORMINFONBRHOODSINGLEFAMAGE AGE
        {
            get
            {
                return this.aGEField;
            }
            set
            {
                this.aGEField = value;
            }
        }

        /// <remarks/>
        public FORMINFONBRHOODSINGLEFAMPRICE PRICE
        {
            get
            {
                return this.pRICEField;
            }
            set
            {
                this.pRICEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFONBRHOODSINGLEFAMAGE
    {

        private byte lOWField;

        private byte hIGHField;

        private string pREDOMINANTField;

        /// <remarks/>
        public byte LOW
        {
            get
            {
                return this.lOWField;
            }
            set
            {
                this.lOWField = value;
            }
        }

        /// <remarks/>
        public byte HIGH
        {
            get
            {
                return this.hIGHField;
            }
            set
            {
                this.hIGHField = value;
            }
        }

        /// <remarks/>
        public string PREDOMINANT
        {
            get
            {
                return this.pREDOMINANTField;
            }
            set
            {
                this.pREDOMINANTField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFONBRHOODSINGLEFAMPRICE
    {

        private byte lOWField;

        private byte hIGHField;

        private string pREDOMINANTField;

        /// <remarks/>
        public byte LOW
        {
            get
            {
                return this.lOWField;
            }
            set
            {
                this.lOWField = value;
            }
        }

        /// <remarks/>
        public byte HIGH
        {
            get
            {
                return this.hIGHField;
            }
            set
            {
                this.hIGHField = value;
            }
        }

        /// <remarks/>
        public string PREDOMINANT
        {
            get
            {
                return this.pREDOMINANTField;
            }
            set
            {
                this.pREDOMINANTField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFONBRHOODLANDUSE
    {

        private byte cOMMERCIALField;

        private byte mULTIFAMField;

        private byte tWOFOURFAMField;

        private byte oNEFAMField;

        /// <remarks/>
        public byte COMMERCIAL
        {
            get
            {
                return this.cOMMERCIALField;
            }
            set
            {
                this.cOMMERCIALField = value;
            }
        }

        /// <remarks/>
        public byte MULTIFAM
        {
            get
            {
                return this.mULTIFAMField;
            }
            set
            {
                this.mULTIFAMField = value;
            }
        }

        /// <remarks/>
        public byte TWOFOURFAM
        {
            get
            {
                return this.tWOFOURFAMField;
            }
            set
            {
                this.tWOFOURFAMField = value;
            }
        }

        /// <remarks/>
        public byte ONEFAM
        {
            get
            {
                return this.oNEFAMField;
            }
            set
            {
                this.oNEFAMField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFONBRHOODOCCUPANCY
    {

        private FORMINFONBRHOODOCCUPANCYOWNER oWNERField;

        private string vACANTAField;

        /// <remarks/>
        public FORMINFONBRHOODOCCUPANCYOWNER OWNER
        {
            get
            {
                return this.oWNERField;
            }
            set
            {
                this.oWNERField = value;
            }
        }

        /// <remarks/>
        public string VACANTA
        {
            get
            {
                return this.vACANTAField;
            }
            set
            {
                this.vACANTAField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFONBRHOODOCCUPANCYOWNER
    {

        private string oWNERField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OWNER
        {
            get
            {
                return this.oWNERField;
            }
            set
            {
                this.oWNERField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOPUD
    {

        private FORMINFOPUDUNITS uNITSField;

        private string eLEMENTSRECREATIONALField;

        private string dEVELOPBUILDCONTROLField;

        /// <remarks/>
        public FORMINFOPUDUNITS UNITS
        {
            get
            {
                return this.uNITSField;
            }
            set
            {
                this.uNITSField = value;
            }
        }

        /// <remarks/>
        public string ELEMENTSRECREATIONAL
        {
            get
            {
                return this.eLEMENTSRECREATIONALField;
            }
            set
            {
                this.eLEMENTSRECREATIONALField = value;
            }
        }

        /// <remarks/>
        public string DEVELOPBUILDCONTROL
        {
            get
            {
                return this.dEVELOPBUILDCONTROLField;
            }
            set
            {
                this.dEVELOPBUILDCONTROLField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOPUDUNITS
    {

        private string nUMField;

        private string fORSALEField;

        /// <remarks/>
        public string NUM
        {
            get
            {
                return this.nUMField;
            }
            set
            {
                this.nUMField = value;
            }
        }

        /// <remarks/>
        public string FORSALE
        {
            get
            {
                return this.fORSALEField;
            }
            set
            {
                this.fORSALEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOCOMMENT
    {

        private string aDDITIONALFEATURESField;

        private string aDVERSECONDITIONSField;

        private string cONDITIONIMPROVEField;

        /// <remarks/>
        public string ADDITIONALFEATURES
        {
            get
            {
                return this.aDDITIONALFEATURESField;
            }
            set
            {
                this.aDDITIONALFEATURESField = value;
            }
        }

        /// <remarks/>
        public string ADVERSECONDITIONS
        {
            get
            {
                return this.aDVERSECONDITIONSField;
            }
            set
            {
                this.aDVERSECONDITIONSField = value;
            }
        }

        /// <remarks/>
        public string CONDITIONIMPROVE
        {
            get
            {
                return this.cONDITIONIMPROVEField;
            }
            set
            {
                this.cONDITIONIMPROVEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOLENDERCLIENT
    {

        private string nAMEField;

        private FORMINFOLENDERCLIENTADDR aDDRField;

        /// <remarks/>
        public string NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }

        /// <remarks/>
        public FORMINFOLENDERCLIENTADDR ADDR
        {
            get
            {
                return this.aDDRField;
            }
            set
            {
                this.aDDRField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOLENDERCLIENTADDR
    {

        private string sTREETField;

        /// <remarks/>
        public string STREET
        {
            get
            {
                return this.sTREETField;
            }
            set
            {
                this.sTREETField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOADDENDUMS
    {

        private FORMINFOADDENDUMSADDENDA[] aDDENDAField;

        private FORMINFOADDENDUMSPHOTO[] aDDITIONALPHOTOSField;

        private FORMINFOADDENDUMSPLATMAP pLATMAPField;

        private FORMINFOADDENDUMSCOMPPHOTO[] cOMPPHOTOField;

        private FORMINFOADDENDUMSSUBJECTPHOTO sUBJECTPHOTOField;

        private FORMINFOADDENDUMSLOCATIONMAP lOCATIONMAPField;

        private FORMINFOADDENDUMSFLOORPLAN fLOORPLANField;

        private FORMINFOADDENDUMSSIGNATURE sIGNATUREField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ADDENDA")]
        public FORMINFOADDENDUMSADDENDA[] ADDENDA
        {
            get
            {
                return this.aDDENDAField;
            }
            set
            {
                this.aDDENDAField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("PHOTO", IsNullable = false)]
        public FORMINFOADDENDUMSPHOTO[] ADDITIONALPHOTOS
        {
            get
            {
                return this.aDDITIONALPHOTOSField;
            }
            set
            {
                this.aDDITIONALPHOTOSField = value;
            }
        }

        /// <remarks/>
        public FORMINFOADDENDUMSPLATMAP PLATMAP
        {
            get
            {
                return this.pLATMAPField;
            }
            set
            {
                this.pLATMAPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("COMPPHOTO")]
        public FORMINFOADDENDUMSCOMPPHOTO[] COMPPHOTO
        {
            get
            {
                return this.cOMPPHOTOField;
            }
            set
            {
                this.cOMPPHOTOField = value;
            }
        }

        /// <remarks/>
        public FORMINFOADDENDUMSSUBJECTPHOTO SUBJECTPHOTO
        {
            get
            {
                return this.sUBJECTPHOTOField;
            }
            set
            {
                this.sUBJECTPHOTOField = value;
            }
        }

        /// <remarks/>
        public FORMINFOADDENDUMSLOCATIONMAP LOCATIONMAP
        {
            get
            {
                return this.lOCATIONMAPField;
            }
            set
            {
                this.lOCATIONMAPField = value;
            }
        }

        /// <remarks/>
        public FORMINFOADDENDUMSFLOORPLAN FLOORPLAN
        {
            get
            {
                return this.fLOORPLANField;
            }
            set
            {
                this.fLOORPLANField = value;
            }
        }

        /// <remarks/>
        public FORMINFOADDENDUMSSIGNATURE SIGNATURE
        {
            get
            {
                return this.sIGNATUREField;
            }
            set
            {
                this.sIGNATUREField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOADDENDUMSADDENDA
    {

        private string nAMEField;

        private string vALUEField;

        private byte aDDENDANUMField;

        /// <remarks/>
        public string NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }

        /// <remarks/>
        public string VALUE
        {
            get
            {
                return this.vALUEField;
            }
            set
            {
                this.vALUEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ADDENDANUM
        {
            get
            {
                return this.aDDENDANUMField;
            }
            set
            {
                this.aDDENDANUMField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOADDENDUMSPHOTO
    {

        private string fILENAMEField;

        private string fILETYPEField;

        private FORMINFOADDENDUMSPHOTODESCRIPTION dESCRIPTIONField;

        private byte nUMField;

        /// <remarks/>
        public string FILENAME
        {
            get
            {
                return this.fILENAMEField;
            }
            set
            {
                this.fILENAMEField = value;
            }
        }

        /// <remarks/>
        public string FILETYPE
        {
            get
            {
                return this.fILETYPEField;
            }
            set
            {
                this.fILETYPEField = value;
            }
        }

        /// <remarks/>
        public FORMINFOADDENDUMSPHOTODESCRIPTION DESCRIPTION
        {
            get
            {
                return this.dESCRIPTIONField;
            }
            set
            {
                this.dESCRIPTIONField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte NUM
        {
            get
            {
                return this.nUMField;
            }
            set
            {
                this.nUMField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOADDENDUMSPHOTODESCRIPTION
    {

        private byte nUMField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte NUM
        {
            get
            {
                return this.nUMField;
            }
            set
            {
                this.nUMField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOADDENDUMSPLATMAP
    {

        private string fILENAMEField;

        private string fILETYPEField;

        private string nAMEField;

        /// <remarks/>
        public string FILENAME
        {
            get
            {
                return this.fILENAMEField;
            }
            set
            {
                this.fILENAMEField = value;
            }
        }

        /// <remarks/>
        public string FILETYPE
        {
            get
            {
                return this.fILETYPEField;
            }
            set
            {
                this.fILETYPEField = value;
            }
        }

        /// <remarks/>
        public string NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOADDENDUMSCOMPPHOTO
    {

        private string fILENAMEField;

        private string fILETYPEField;

        private byte cOMPNUMField;

        /// <remarks/>
        public string FILENAME
        {
            get
            {
                return this.fILENAMEField;
            }
            set
            {
                this.fILENAMEField = value;
            }
        }

        /// <remarks/>
        public string FILETYPE
        {
            get
            {
                return this.fILETYPEField;
            }
            set
            {
                this.fILETYPEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte COMPNUM
        {
            get
            {
                return this.cOMPNUMField;
            }
            set
            {
                this.cOMPNUMField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOADDENDUMSSUBJECTPHOTO
    {

        private FORMINFOADDENDUMSSUBJECTPHOTOREARVIEW rEARVIEWField;

        private FORMINFOADDENDUMSSUBJECTPHOTOFRONTVIEW fRONTVIEWField;

        private FORMINFOADDENDUMSSUBJECTPHOTOSTREETVIEW sTREETVIEWField;

        /// <remarks/>
        public FORMINFOADDENDUMSSUBJECTPHOTOREARVIEW REARVIEW
        {
            get
            {
                return this.rEARVIEWField;
            }
            set
            {
                this.rEARVIEWField = value;
            }
        }

        /// <remarks/>
        public FORMINFOADDENDUMSSUBJECTPHOTOFRONTVIEW FRONTVIEW
        {
            get
            {
                return this.fRONTVIEWField;
            }
            set
            {
                this.fRONTVIEWField = value;
            }
        }

        /// <remarks/>
        public FORMINFOADDENDUMSSUBJECTPHOTOSTREETVIEW STREETVIEW
        {
            get
            {
                return this.sTREETVIEWField;
            }
            set
            {
                this.sTREETVIEWField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOADDENDUMSSUBJECTPHOTOREARVIEW
    {

        private string fILENAMEField;

        private string fILETYPEField;

        /// <remarks/>
        public string FILENAME
        {
            get
            {
                return this.fILENAMEField;
            }
            set
            {
                this.fILENAMEField = value;
            }
        }

        /// <remarks/>
        public string FILETYPE
        {
            get
            {
                return this.fILETYPEField;
            }
            set
            {
                this.fILETYPEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOADDENDUMSSUBJECTPHOTOFRONTVIEW
    {

        private string fILENAMEField;

        private string fILETYPEField;

        /// <remarks/>
        public string FILENAME
        {
            get
            {
                return this.fILENAMEField;
            }
            set
            {
                this.fILENAMEField = value;
            }
        }

        /// <remarks/>
        public string FILETYPE
        {
            get
            {
                return this.fILETYPEField;
            }
            set
            {
                this.fILETYPEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOADDENDUMSSUBJECTPHOTOSTREETVIEW
    {

        private string fILENAMEField;

        private string fILETYPEField;

        /// <remarks/>
        public string FILENAME
        {
            get
            {
                return this.fILENAMEField;
            }
            set
            {
                this.fILENAMEField = value;
            }
        }

        /// <remarks/>
        public string FILETYPE
        {
            get
            {
                return this.fILETYPEField;
            }
            set
            {
                this.fILETYPEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOADDENDUMSLOCATIONMAP
    {

        private string fILENAMEField;

        private string fILETYPEField;

        private string nAMEField;

        /// <remarks/>
        public string FILENAME
        {
            get
            {
                return this.fILENAMEField;
            }
            set
            {
                this.fILENAMEField = value;
            }
        }

        /// <remarks/>
        public string FILETYPE
        {
            get
            {
                return this.fILETYPEField;
            }
            set
            {
                this.fILETYPEField = value;
            }
        }

        /// <remarks/>
        public string NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOADDENDUMSFLOORPLAN
    {

        private string nAMEField;

        private string fILENAMEField;

        private string fILETYPEField;

        private byte nUMField;

        /// <remarks/>
        public string NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }

        /// <remarks/>
        public string FILENAME
        {
            get
            {
                return this.fILENAMEField;
            }
            set
            {
                this.fILENAMEField = value;
            }
        }

        /// <remarks/>
        public string FILETYPE
        {
            get
            {
                return this.fILETYPEField;
            }
            set
            {
                this.fILETYPEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte NUM
        {
            get
            {
                return this.nUMField;
            }
            set
            {
                this.nUMField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOADDENDUMSSIGNATURE
    {

        private FORMINFOADDENDUMSSIGNATUREAPPRAISER aPPRAISERField;

        /// <remarks/>
        public FORMINFOADDENDUMSSIGNATUREAPPRAISER APPRAISER
        {
            get
            {
                return this.aPPRAISERField;
            }
            set
            {
                this.aPPRAISERField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOADDENDUMSSIGNATUREAPPRAISER
    {

        private string fILENAMEField;

        private string fILETYPEField;

        /// <remarks/>
        public string FILENAME
        {
            get
            {
                return this.fILENAMEField;
            }
            set
            {
                this.fILENAMEField = value;
            }
        }

        /// <remarks/>
        public string FILETYPE
        {
            get
            {
                return this.fILETYPEField;
            }
            set
            {
                this.fILETYPEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FORMINFOMINORFORMINFO
    {

        private string fORMNUMField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FORMNUM
        {
            get
            {
                return this.fORMNUMField;
            }
            set
            {
                this.fORMNUMField = value;
            }
        }
    }


}
