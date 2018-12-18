using System.Collections.Generic;
using System.Linq;
using CorrespondentPortal.WebApi.Infrastructure.Shared;

namespace CorrespondentPortal.WebApi.Infrastructure.HealthCheck
{
    public class HealthCheck
    {
        public List<Vital> Vitals { get; } = new List<Vital>();
        public string Description { get; }

        public HealthStatus Status
        {
            get
            {
                if (Vitals.Any(x => x.Status == HealthStatus.Critical))
                {
                    return HealthStatus.Critical;
                }

                return Vitals.Any(x => x.Status == HealthStatus.Warning) ? HealthStatus.Warning : HealthStatus.Active;
            }
        }

        public HealthCheck(string description)
        {
            Description = description;
        }

        public void AddVital(string description, HealthStatus status, string message = "")
        {
            Vitals.Add(new Vital(status, description, message));
        }

        public void AddVital(string description, HealthStatus status, IEnumerable<string> messages)
        {
            var errorMessage = messages?.Aggregate((a, b) => a + "," + b) ?? "";

            Vitals.Add(new Vital(status, description, errorMessage));
        }

        public void AddVital(Vital vital)
        {
            Vitals.Add(vital);
        }
    }
}
