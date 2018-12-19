using CorrespondentPortal.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorrespondentPortal.WebApi.Controllers
{
    public class DummyCallbackUrlEndpointsController : Controller
    {
        public DummyCallbackUrlEndpointsController()
        {

        }

        [HttpGet]
        [Route("Callback/GetBankOneUrl")]
        [ApiExplorerSettings(IgnoreApi = true)]
        public ClientCallbackInfoDto GetBankOneCallbackInformation()
        {
            return new ClientCallbackInfoDto
            {
                BorrowerCreditScore = new BorrowerCreditScore
                {
                    Min = 1,
                    Max = 750,
                    Weight = 20
                },
                CRA = new Cra
                {
                    YearTerm = 15,
                    RateTerm = "Adjustable",
                    Weight = 10
                },
                DebtToIncome = new DebtToIncome
                {
                    Min = 1,
                    Max = 5,
                    Weight = 10
                },
                FannieCU = new FannieCU
                {
                    Min = 1,
                    Max = 90,
                    Weight = 10
                }, 
                FreddieLCA = new FreddieLCA
                {
                    Min = 1,
                    Max = 50,
                    Weight = 10
                },
                GaarScore = new GaarScore
                {
                    Min = 1,
                    Max = 50,
                    Weight = 10
                },
                InterestRate = new InterestRate
                {
                    Min = 10.25,
                    Max = 50.86,
                    Weight = 10
                },
                LoanAmount = new LoanAmount
                {
                    Min = 100500,
                    Max = 500000,
                    Weight = 10
                },
                LoanToValue = new LoanToValue
                {
                    Min = 1,
                    Max = 100,
                    Weight = 10
                }
            };
        }

        [HttpGet]
        [Route("Callback/GetBankOneUrl")]
        [ApiExplorerSettings(IgnoreApi = true)]
        public ClientCallbackInfoDto GetBankTwoCallbackInformation()
        {
            return new ClientCallbackInfoDto
            {

            };
        }

        [HttpGet]
        [Route("Callback/GetBankOneUrl")]
        [ApiExplorerSettings(IgnoreApi = true)]
        public ClientCallbackInfoDto GetBankThreeCallbackInformation()
        {
            return new ClientCallbackInfoDto
            {

            };
        }

        [HttpGet]
        [Route("Callback/GetBankOneUrl")]
        [ApiExplorerSettings(IgnoreApi = true)]
        public ClientCallbackInfoDto GetBankFourCallbackInformation()
        {
            return new ClientCallbackInfoDto
            {

            };
        }
    }
}
