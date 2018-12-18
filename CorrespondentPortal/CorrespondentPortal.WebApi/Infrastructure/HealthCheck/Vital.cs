using CorrespondentPortal.WebApi.Infrastructure.Shared;

namespace CorrespondentPortal.WebApi.Infrastructure.HealthCheck
{
    public class Vital
    {
        public HealthStatus Status { get; set; }
        public string Description { get; set; }

        private string _message;

        public string Message
        {
            get => Status + (string.IsNullOrEmpty(_message) ? "" : ": " + _message);
            set => _message = value;
        }

        public Vital(HealthStatus status, string description = "", string message = "")
        {
            Status = status;
            Description = description;
            _message = message;
        }
    }
}
