using System.Collections.Generic;
using System.DirectoryServices.Protocols;
using CorrespondentPortal.WebApi.Infrastructure.HealthCheck;

namespace CorrespondentPortal.WebApi.Infrastructure.Security.Ldap
{
    public interface ILdapUtility : IHealthCheckable
    {
        IEnumerable<string> GetGroups(string username, string password);
    }
}