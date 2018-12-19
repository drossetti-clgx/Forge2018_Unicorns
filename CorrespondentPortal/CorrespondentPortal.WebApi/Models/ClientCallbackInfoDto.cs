using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorrespondentPortal.WebApi.Models
{
    public class ClientCallbackInfoDto
    {
        public LoanToValue LoanToValue { get; set; }
        public DebtToIncome DebtToIncome { get; set; }
        public GaarScore GaarScore { get; set; }
        public BorrowerCreditScore BorrowerCreditScore { get; set; }
        public FannieCU FannieCU { get; set; }
        public FreddieLCA FreddieLCA { get; set; }
        public Cra CRA { get; set; }
        public InterestRate InterestRate { get; set; }
        public LoanAmount LoanAmount { get; set; }
    }

    public class LoanToValue
    {
        public int Min { get; set; }
        public int Max { get; set; }
        public int Weight { get; set; }
    }

    public class DebtToIncome
    {
        public int Min { get; set; }
        public int Max { get; set; }
        public int Weight { get; set; }
    }

    public class GaarScore
    {
        public int Min { get; set; }
        public int Max { get; set; }
        public int Weight { get; set; }
    }

    public class BorrowerCreditScore
    {
        public int Min { get; set; }
        public int Max { get; set; }
        public int Weight { get; set; }
    }

    public class FannieCU
    {
        public int Min { get; set; }
        public int Max { get; set; }
        public int Weight { get; set; }
    }

    public class FreddieLCA
    {
        public int Min { get; set; }
        public int Max { get; set; }
        public int Weight { get; set; }
    }

    public class Cra
    {
        public int YearTerm { get; set; }
        public string RateTerm { get; set; }
        public int Weight { get; set; }
    }

    public class InterestRate
    {
        public double Min { get; set; }
        public double Max { get; set; }
        public int Weight { get; set; }
    }

    public class LoanAmount
    {
        public double Min { get; set; }
        public double Max { get; set; }
        public int Weight { get; set; }
    }
}
