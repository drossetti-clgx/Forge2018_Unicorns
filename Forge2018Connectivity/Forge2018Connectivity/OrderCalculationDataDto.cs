using System;
using System.Collections.Generic;
using System.Text;

namespace Forge2018Connectivity
{
    public class OrderCalculationDataDto
    {
        public string GSE { get; set; }
        public object SSRFile { get; set; }
        public string BorrowerCreditScore { get; set; }
        public string CUScore { get; set; }
        public string LCAScore { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public bool CRA { get; set; }
        public string LoanProduct { get; set; }
        public decimal DebtToIncome { get; set; }
        public decimal InterestRate { get; set; }
        public decimal AppraisedValue { get; set; }
        public string FormType { get; set; }
        public string GAARScore { get; set; }
        public string LoanNumber { get; set; }
        public string LoanAmount { get; set; }
        public string BorrowerName { get; set; }
        public string LTV { get; set; }
        public string EstimatedValue { get; set; }
    }
}
