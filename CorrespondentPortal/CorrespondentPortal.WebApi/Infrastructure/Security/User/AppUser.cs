using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CorrespondentPortal.WebApi.Infrastructure.Security.User
{
    public class AppUser
    {
        public string Name { get; set; }
        public bool IsAuthenticated { get; set; }
        public List<Claim> Claims { get; set; }
        public string ErrorMessage { get; set; }
    }
}
