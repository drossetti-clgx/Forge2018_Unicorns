using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorrespondentPortal.WebApi.DTO
{
    public class LoanSubmissionViewModel
    {
        public List<DropdownDto> LoanProductOptions { get; set; }
        public List<DropdownDto> LoanRateOptions { get; set; }
        public List<DropdownDto> CraLoanOptions { get; set; }
    }

    public class DropdownDto
    {
        public string Value { get; set; }
        public string Description { get; set; }
    }
}
