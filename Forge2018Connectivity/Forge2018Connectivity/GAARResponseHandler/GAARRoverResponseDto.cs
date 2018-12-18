using System;
using System.Collections.Generic;
using System.Text;

namespace Forge2018Connectivity.GAARResponseHandler
{
    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(ElementName = "Transaction", IsNullable = false)]
    public partial class GAARRoverResponseDto
    {

        /// <remarks/>
        public TransactionRequestDetail RequestDetail { get; set; }

        /// <remarks/>
        public TransactionDisplayDetail DisplayDetail { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Service", IsNullable = false)]
        public TransactionService[] ResponseDetail { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BillableEvent { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ErrorCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ErrorMessage { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResultMessage { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string StartTime { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EndTime { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TimeDuration { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Base { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ASYNC { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OADIInput { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ConfigVersion { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ExpandHtml { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ExpandPdf { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class TransactionRequestDetail
    {

        private string rqCustomerField;

        private string rqUtrField;

        private string rqServiceIDField;

        private object ownerEstValueField;

        private TransactionRequestDetailAsOfDate asOfDateField;

        private TransactionRequestDetailProperty[] rqPropertyListField;

        private object rqFilterListField;

        private string requestTypeField;

        /// <remarks/>
        public string RqCustomer
        {
            get
            {
                return this.rqCustomerField;
            }
            set
            {
                this.rqCustomerField = value;
            }
        }

        /// <remarks/>
        public string RqUtr
        {
            get
            {
                return this.rqUtrField;
            }
            set
            {
                this.rqUtrField = value;
            }
        }

        /// <remarks/>
        public string RqServiceID
        {
            get
            {
                return this.rqServiceIDField;
            }
            set
            {
                this.rqServiceIDField = value;
            }
        }

        /// <remarks/>
        public object OwnerEstValue
        {
            get
            {
                return this.ownerEstValueField;
            }
            set
            {
                this.ownerEstValueField = value;
            }
        }

        /// <remarks/>
        public TransactionRequestDetailAsOfDate AsOfDate
        {
            get
            {
                return this.asOfDateField;
            }
            set
            {
                this.asOfDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Property", IsNullable = false)]
        public TransactionRequestDetailProperty[] RqPropertyList
        {
            get
            {
                return this.rqPropertyListField;
            }
            set
            {
                this.rqPropertyListField = value;
            }
        }

        /// <remarks/>
        public object RqFilterList
        {
            get
            {
                return this.rqFilterListField;
            }
            set
            {
                this.rqFilterListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RequestType
        {
            get
            {
                return this.requestTypeField;
            }
            set
            {
                this.requestTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class TransactionRequestDetailAsOfDate
    {

        private string enabledField;

        private string typeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Enabled
        {
            get
            {
                return this.enabledField;
            }
            set
            {
                this.enabledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
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
    public partial class TransactionRequestDetailProperty
    {

        private string streetAddressField;

        private string cityField;

        private string stateField;

        private string zipCodeField;

        private string propertyTypeField;

        /// <remarks/>
        public string StreetAddress
        {
            get
            {
                return this.streetAddressField;
            }
            set
            {
                this.streetAddressField = value;
            }
        }

        /// <remarks/>
        public string City
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        /// <remarks/>
        public string State
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
            }
        }

        /// <remarks/>
        public string ZipCode
        {
            get
            {
                return this.zipCodeField;
            }
            set
            {
                this.zipCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PropertyType
        {
            get
            {
                return this.propertyTypeField;
            }
            set
            {
                this.propertyTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class TransactionDisplayDetail
    {

        private string nameField;

        private string xSLTField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string XSLT
        {
            get
            {
                return this.xSLTField;
            }
            set
            {
                this.xSLTField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class TransactionService
    {

        private TransactionServiceReportInfo reportInfoField;

        private TransactionServiceGaarResult gaarResultField;

        private byte itemField;

        private string displayField;

        private string dataSetField;

        private string vendorField;

        private string serviceTypeField;

        private string reportIDField;

        private string reportTypeField;

        private string billableEventField;

        private string resultField;

        private string startTimeField;

        private string endTimeField;

        private decimal timeDurationField;

        private string resultMessageField;

        /// <remarks/>
        public TransactionServiceReportInfo ReportInfo
        {
            get
            {
                return this.reportInfoField;
            }
            set
            {
                this.reportInfoField = value;
            }
        }

        /// <remarks/>
        public TransactionServiceGaarResult GaarResult
        {
            get
            {
                return this.gaarResultField;
            }
            set
            {
                this.gaarResultField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Display
        {
            get
            {
                return this.displayField;
            }
            set
            {
                this.displayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DataSet
        {
            get
            {
                return this.dataSetField;
            }
            set
            {
                this.dataSetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Vendor
        {
            get
            {
                return this.vendorField;
            }
            set
            {
                this.vendorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ServiceType
        {
            get
            {
                return this.serviceTypeField;
            }
            set
            {
                this.serviceTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ReportID
        {
            get
            {
                return this.reportIDField;
            }
            set
            {
                this.reportIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ReportType
        {
            get
            {
                return this.reportTypeField;
            }
            set
            {
                this.reportTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BillableEvent
        {
            get
            {
                return this.billableEventField;
            }
            set
            {
                this.billableEventField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Result
        {
            get
            {
                return this.resultField;
            }
            set
            {
                this.resultField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string StartTime
        {
            get
            {
                return this.startTimeField;
            }
            set
            {
                this.startTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EndTime
        {
            get
            {
                return this.endTimeField;
            }
            set
            {
                this.endTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal TimeDuration
        {
            get
            {
                return this.timeDurationField;
            }
            set
            {
                this.timeDurationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ResultMessage
        {
            get
            {
                return this.resultMessageField;
            }
            set
            {
                this.resultMessageField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class TransactionServiceReportInfo
    {

        private TransactionServiceReportInfoPDF pDFField;

        private TransactionServiceReportInfoHTML hTMLField;

        /// <remarks/>
        public TransactionServiceReportInfoPDF PDF
        {
            get
            {
                return this.pDFField;
            }
            set
            {
                this.pDFField = value;
            }
        }

        /// <remarks/>
        public TransactionServiceReportInfoHTML HTML
        {
            get
            {
                return this.hTMLField;
            }
            set
            {
                this.hTMLField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class TransactionServiceReportInfoPDF
    {

        private string uRLField;

        /// <remarks/>
        public string URL
        {
            get
            {
                return this.uRLField;
            }
            set
            {
                this.uRLField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class TransactionServiceReportInfoHTML
    {

        private string uRLField;

        /// <remarks/>
        public string URL
        {
            get
            {
                return this.uRLField;
            }
            set
            {
                this.uRLField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class TransactionServiceGaarResult
    {

        private TransactionServiceGaarResultInterviewDetail[] interviewDetailsField;

        private TransactionServiceGaarResultAddress[] addressesField;

        private TransactionServiceGaarResultVariable[] runtimeVariablesField;

        private TransactionServiceGaarResultScore[] scoresField;

        private TransactionServiceGaarResultRuleStatistics ruleStatisticsField;

        private string portIdField;

        private string docIdField;

        private decimal gaarVersionField;

        private System.DateTime resultDtField;

        private TransactionServiceGaarResultMajorForm majorFormField;

        private TransactionServiceGaarResultMinorForms minorFormsField;

        private decimal serviceDurationField;

        private TransactionServiceGaarResultAppraisalInformation appraisalInformationField;

        private string transactionNumField;

        private string filePathField;

        private string fileIdField;

        private string subjectImageUrlField;

        private string processedDateField;

        private string processedDateTimeField;

        private string platformField;

        private string mergedXmlSigField;

        private string renderForField;

        private string ruleAccessLevelField;

        private string excludeExternalRulesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("InterviewDetail", IsNullable = false)]
        public TransactionServiceGaarResultInterviewDetail[] InterviewDetails
        {
            get
            {
                return this.interviewDetailsField;
            }
            set
            {
                this.interviewDetailsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Address", IsNullable = false)]
        public TransactionServiceGaarResultAddress[] Addresses
        {
            get
            {
                return this.addressesField;
            }
            set
            {
                this.addressesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Variable", IsNullable = false)]
        public TransactionServiceGaarResultVariable[] RuntimeVariables
        {
            get
            {
                return this.runtimeVariablesField;
            }
            set
            {
                this.runtimeVariablesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Score", IsNullable = false)]
        public TransactionServiceGaarResultScore[] Scores
        {
            get
            {
                return this.scoresField;
            }
            set
            {
                this.scoresField = value;
            }
        }

        /// <remarks/>
        public TransactionServiceGaarResultRuleStatistics RuleStatistics
        {
            get
            {
                return this.ruleStatisticsField;
            }
            set
            {
                this.ruleStatisticsField = value;
            }
        }

        /// <remarks/>
        public string PortId
        {
            get
            {
                return this.portIdField;
            }
            set
            {
                this.portIdField = value;
            }
        }

        /// <remarks/>
        public string DocId
        {
            get
            {
                return this.docIdField;
            }
            set
            {
                this.docIdField = value;
            }
        }

        /// <remarks/>
        public decimal GaarVersion
        {
            get
            {
                return this.gaarVersionField;
            }
            set
            {
                this.gaarVersionField = value;
            }
        }

        /// <remarks/>
        public System.DateTime ResultDt
        {
            get
            {
                return this.resultDtField;
            }
            set
            {
                this.resultDtField = value;
            }
        }

        /// <remarks/>
        public TransactionServiceGaarResultMajorForm MajorForm
        {
            get
            {
                return this.majorFormField;
            }
            set
            {
                this.majorFormField = value;
            }
        }

        /// <remarks/>
        public TransactionServiceGaarResultMinorForms MinorForms
        {
            get
            {
                return this.minorFormsField;
            }
            set
            {
                this.minorFormsField = value;
            }
        }

        /// <remarks/>
        public decimal ServiceDuration
        {
            get
            {
                return this.serviceDurationField;
            }
            set
            {
                this.serviceDurationField = value;
            }
        }

        /// <remarks/>
        public TransactionServiceGaarResultAppraisalInformation AppraisalInformation
        {
            get
            {
                return this.appraisalInformationField;
            }
            set
            {
                this.appraisalInformationField = value;
            }
        }

        /// <remarks/>
        public string TransactionNum
        {
            get
            {
                return this.transactionNumField;
            }
            set
            {
                this.transactionNumField = value;
            }
        }

        /// <remarks/>
        public string FilePath
        {
            get
            {
                return this.filePathField;
            }
            set
            {
                this.filePathField = value;
            }
        }

        /// <remarks/>
        public string FileId
        {
            get
            {
                return this.fileIdField;
            }
            set
            {
                this.fileIdField = value;
            }
        }

        /// <remarks/>
        public string SubjectImageUrl
        {
            get
            {
                return this.subjectImageUrlField;
            }
            set
            {
                this.subjectImageUrlField = value;
            }
        }

        /// <remarks/>
        public string ProcessedDate
        {
            get
            {
                return this.processedDateField;
            }
            set
            {
                this.processedDateField = value;
            }
        }

        /// <remarks/>
        public string ProcessedDateTime
        {
            get
            {
                return this.processedDateTimeField;
            }
            set
            {
                this.processedDateTimeField = value;
            }
        }

        /// <remarks/>
        public string Platform
        {
            get
            {
                return this.platformField;
            }
            set
            {
                this.platformField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MergedXmlSig
        {
            get
            {
                return this.mergedXmlSigField;
            }
            set
            {
                this.mergedXmlSigField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RenderFor
        {
            get
            {
                return this.renderForField;
            }
            set
            {
                this.renderForField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RuleAccessLevel
        {
            get
            {
                return this.ruleAccessLevelField;
            }
            set
            {
                this.ruleAccessLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ExcludeExternalRules
        {
            get
            {
                return this.excludeExternalRulesField;
            }
            set
            {
                this.excludeExternalRulesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class TransactionServiceGaarResultInterviewDetail
    {

        private TransactionServiceGaarResultInterviewDetailMessage[] messagesField;

        private TransactionServiceGaarResultInterviewDetailObserved[] observationParamsField;

        private TransactionServiceGaarResultInterviewDetailRuleAttribute[] attributesField;

        private string[] observedValuesField;

        private string observationField;

        private bool firedField;

        private string ruleIdField;

        private string versionField;

        private byte counterField;

        private byte weightField;

        private string labelField;

        private string nodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Message", IsNullable = false)]
        public TransactionServiceGaarResultInterviewDetailMessage[] Messages
        {
            get
            {
                return this.messagesField;
            }
            set
            {
                this.messagesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Observed", IsNullable = false)]
        public TransactionServiceGaarResultInterviewDetailObserved[] ObservationParams
        {
            get
            {
                return this.observationParamsField;
            }
            set
            {
                this.observationParamsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("RuleAttribute", IsNullable = false)]
        public TransactionServiceGaarResultInterviewDetailRuleAttribute[] Attributes
        {
            get
            {
                return this.attributesField;
            }
            set
            {
                this.attributesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public string[] ObservedValues
        {
            get
            {
                return this.observedValuesField;
            }
            set
            {
                this.observedValuesField = value;
            }
        }

        /// <remarks/>
        public string Observation
        {
            get
            {
                return this.observationField;
            }
            set
            {
                this.observationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Fired
        {
            get
            {
                return this.firedField;
            }
            set
            {
                this.firedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RuleId
        {
            get
            {
                return this.ruleIdField;
            }
            set
            {
                this.ruleIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Counter
        {
            get
            {
                return this.counterField;
            }
            set
            {
                this.counterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Weight
        {
            get
            {
                return this.weightField;
            }
            set
            {
                this.weightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Label
        {
            get
            {
                return this.labelField;
            }
            set
            {
                this.labelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Node
        {
            get
            {
                return this.nodeField;
            }
            set
            {
                this.nodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class TransactionServiceGaarResultInterviewDetailMessage
    {

        private string msgTypeField;

        private string paragraphField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MsgType
        {
            get
            {
                return this.msgTypeField;
            }
            set
            {
                this.msgTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Paragraph
        {
            get
            {
                return this.paragraphField;
            }
            set
            {
                this.paragraphField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class TransactionServiceGaarResultInterviewDetailObserved
    {

        private string anchorField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Anchor
        {
            get
            {
                return this.anchorField;
            }
            set
            {
                this.anchorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    public partial class TransactionServiceGaarResultInterviewDetailRuleAttribute
    {

        private string nameField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    public partial class TransactionServiceGaarResultAddress
    {

        private string typeField;

        private string streetField;

        private string cityField;

        private string stateField;

        private string zipField;

        /// <remarks/>
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        public string Street
        {
            get
            {
                return this.streetField;
            }
            set
            {
                this.streetField = value;
            }
        }

        /// <remarks/>
        public string City
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        /// <remarks/>
        public string State
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
            }
        }

        /// <remarks/>
        public string Zip
        {
            get
            {
                return this.zipField;
            }
            set
            {
                this.zipField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class TransactionServiceGaarResultVariable
    {

        private string tokenField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Token
        {
            get
            {
                return this.tokenField;
            }
            set
            {
                this.tokenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    public partial class TransactionServiceGaarResultScore
    {

        private object traceLogField;

        private string nameField;

        private string valueField;

        private bool isScoredField;

        private string descriptionField;

        private string noteField;

        private decimal weightVersionField;

        private bool weightVersionFieldSpecified;

        /// <remarks/>
        public object TraceLog
        {
            get
            {
                return this.traceLogField;
            }
            set
            {
                this.traceLogField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsScored
        {
            get
            {
                return this.isScoredField;
            }
            set
            {
                this.isScoredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Note
        {
            get
            {
                return this.noteField;
            }
            set
            {
                this.noteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal WeightVersion
        {
            get
            {
                return this.weightVersionField;
            }
            set
            {
                this.weightVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WeightVersionSpecified
        {
            get
            {
                return this.weightVersionFieldSpecified;
            }
            set
            {
                this.weightVersionFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class TransactionServiceGaarResultRuleStatistics
    {

        private TransactionServiceGaarResultRuleStatisticsFormRuleStat formRuleStatField;

        /// <remarks/>
        public TransactionServiceGaarResultRuleStatisticsFormRuleStat FormRuleStat
        {
            get
            {
                return this.formRuleStatField;
            }
            set
            {
                this.formRuleStatField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class TransactionServiceGaarResultRuleStatisticsFormRuleStat
    {

        private ushort formNumField;

        private string versionField;

        private ushort rulesCountField;

        private string ruleSetVersionField;

        /// <remarks/>
        public ushort FormNum
        {
            get
            {
                return this.formNumField;
            }
            set
            {
                this.formNumField = value;
            }
        }

        /// <remarks/>
        public string Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        public ushort RulesCount
        {
            get
            {
                return this.rulesCountField;
            }
            set
            {
                this.rulesCountField = value;
            }
        }

        /// <remarks/>
        public string RuleSetVersion
        {
            get
            {
                return this.ruleSetVersionField;
            }
            set
            {
                this.ruleSetVersionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class TransactionServiceGaarResultMajorForm
    {

        private ushort formNumField;

        private string versionField;

        /// <remarks/>
        public ushort FormNum
        {
            get
            {
                return this.formNumField;
            }
            set
            {
                this.formNumField = value;
            }
        }

        /// <remarks/>
        public string Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class TransactionServiceGaarResultMinorForms
    {

        private TransactionServiceGaarResultMinorFormsFormInfo formInfoField;

        /// <remarks/>
        public TransactionServiceGaarResultMinorFormsFormInfo FormInfo
        {
            get
            {
                return this.formInfoField;
            }
            set
            {
                this.formInfoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class TransactionServiceGaarResultMinorFormsFormInfo
    {

        private string formNumField;

        private object versionField;

        /// <remarks/>
        public string FormNum
        {
            get
            {
                return this.formNumField;
            }
            set
            {
                this.formNumField = value;
            }
        }

        /// <remarks/>
        public object Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class TransactionServiceGaarResultAppraisalInformation
    {

        private string appraiserNameField;

        private string effectiveDateField;

        private string estimateValueField;

        private string apprLcnStateField;

        private string apprLcnNumberField;

        private string apprCertStateField;

        private string apprCertNumberField;

        private ushort sqFeetField;

        private object yearBuiltField;

        private byte bedRoomsField;

        private decimal bathsField;

        private decimal censusTractField;

        private object unitsField;

        private string aPNField;

        private string actualAgeField;

        private object bPOValueField;

        private object bPODateField;

        private object bPOPreparerNameField;

        private object bPOPreparerLcnField;

        /// <remarks/>
        public string AppraiserName
        {
            get
            {
                return this.appraiserNameField;
            }
            set
            {
                this.appraiserNameField = value;
            }
        }

        /// <remarks/>
        public string EffectiveDate
        {
            get
            {
                return this.effectiveDateField;
            }
            set
            {
                this.effectiveDateField = value;
            }
        }

        /// <remarks/>
        public string EstimateValue
        {
            get
            {
                return this.estimateValueField;
            }
            set
            {
                this.estimateValueField = value;
            }
        }

        /// <remarks/>
        public string ApprLcnState
        {
            get
            {
                return this.apprLcnStateField;
            }
            set
            {
                this.apprLcnStateField = value;
            }
        }

        /// <remarks/>
        public string ApprLcnNumber
        {
            get
            {
                return this.apprLcnNumberField;
            }
            set
            {
                this.apprLcnNumberField = value;
            }
        }

        /// <remarks/>
        public string ApprCertState
        {
            get
            {
                return this.apprCertStateField;
            }
            set
            {
                this.apprCertStateField = value;
            }
        }

        /// <remarks/>
        public string ApprCertNumber
        {
            get
            {
                return this.apprCertNumberField;
            }
            set
            {
                this.apprCertNumberField = value;
            }
        }

        /// <remarks/>
        public ushort SqFeet
        {
            get
            {
                return this.sqFeetField;
            }
            set
            {
                this.sqFeetField = value;
            }
        }

        /// <remarks/>
        public object YearBuilt
        {
            get
            {
                return this.yearBuiltField;
            }
            set
            {
                this.yearBuiltField = value;
            }
        }

        /// <remarks/>
        public byte BedRooms
        {
            get
            {
                return this.bedRoomsField;
            }
            set
            {
                this.bedRoomsField = value;
            }
        }

        /// <remarks/>
        public decimal Baths
        {
            get
            {
                return this.bathsField;
            }
            set
            {
                this.bathsField = value;
            }
        }

        /// <remarks/>
        public decimal CensusTract
        {
            get
            {
                return this.censusTractField;
            }
            set
            {
                this.censusTractField = value;
            }
        }

        /// <remarks/>
        public object Units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        public string APN
        {
            get
            {
                return this.aPNField;
            }
            set
            {
                this.aPNField = value;
            }
        }

        /// <remarks/>
        public string ActualAge
        {
            get
            {
                return this.actualAgeField;
            }
            set
            {
                this.actualAgeField = value;
            }
        }

        /// <remarks/>
        public object BPOValue
        {
            get
            {
                return this.bPOValueField;
            }
            set
            {
                this.bPOValueField = value;
            }
        }

        /// <remarks/>
        public object BPODate
        {
            get
            {
                return this.bPODateField;
            }
            set
            {
                this.bPODateField = value;
            }
        }

        /// <remarks/>
        public object BPOPreparerName
        {
            get
            {
                return this.bPOPreparerNameField;
            }
            set
            {
                this.bPOPreparerNameField = value;
            }
        }

        /// <remarks/>
        public object BPOPreparerLcn
        {
            get
            {
                return this.bPOPreparerLcnField;
            }
            set
            {
                this.bPOPreparerLcnField = value;
            }
        }
    }


}
