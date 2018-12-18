using System;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Logging;
using CorrespondentPortal.WebApi.Domain.Services.Configurations;
using CorrespondentPortal.WebApi.Domain.Services.InfrastructureLog;
using CorrespondentPortal.WebApi.Infrastructure.Configuration;
using CorrespondentPortal.WebApi.Infrastructure.Shared;

namespace CorrespondentPortal.WebApi.Infrastructure.Notification
{
    public class EmailNotificationBehavior : INotificationBehavior
    {
        private readonly IConfigurationService _configurationService;
        private readonly ILogger _logger;
        public EmailNotificationBehavior(IConfigurationService configurationService, ILogger<EmailNotificationBehavior> logger)
        {
            _configurationService = configurationService;
            _logger = logger;
        }
        public async Task<Operation> Send(string body)
        {
            var sendTo = _configurationService.ConfigurationSettings.HealthCheckNotificationTo.Split("|");
            var emailFrom = _configurationService.ConfigurationSettings.HealthCheckNotificationFrom;
            var environment = _configurationService.ConfigurationSettings.Environment;

            var message = new MailMessage()
            {
                From = new MailAddress(emailFrom),
                Subject = $"({environment})CorrespondentPortal Health Check in Critical State.",
                Body = body,
                IsBodyHtml = true
            };

            foreach (var address in sendTo)
            {
                message.To.Add(new MailAddress(address));
            }

            try
            {
                using (var client = new SmtpClient(_configurationService.ConfigurationSettings.SmtpServer))
                {
                    client.EnableSsl = false;
                    client.Port = 25;
                    await client.SendMailAsync(message).ConfigureAwait(false);
                }
                _logger.LogWarning($"Sent health check notification email to: {sendTo.Join(",")}");
            }
            catch (Exception e)
            {
                _logger.LogWarning("Error sending email in EmailNotificationBehavior");
                return Operation.CreateErrorOperation($"Error Sending Email {e.Message}");
            }

            return Operation.CreateSuccessfulOperation();
        }
    }
}
