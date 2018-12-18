using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CorrespondentPortal.WebApi.DTO.HeathCheck;

namespace CorrespondentPortal.WebApi.ViewModels
{
    public class HomeIndexViewModel
    {
        public string BaseUrl { get; set; }
        public GetHealthCheckResponseDto HealthCheckResponseDto { get; set; }
    }
}
