using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace API.Services
{
    public class EmailSender : IEmailSender
    {
        private readonly ILogger _logger;
        private AuthMessageSenderOptions Options { get; } //Set with Secret Manager.

        public EmailSender(
            IOptions<AuthMessageSenderOptions> optionsAccessor,
            ILogger<EmailSender> logger)
        {
            Options = optionsAccessor.Value;
            _logger = logger;
        }


        public async Task SendEmailAsync(string toEmail, string subject, string message)
        {
            if (string.IsNullOrEmpty(Options.SendGridKey))
            {
                throw new Exception("Null SendGridKey");
            }
            await Execute(Options.SendGridKey, subject, message, toEmail);
        }

        public async Task Execute(string apiKey, string subject, string message, string toEmail)
        {
            var client = new SendGridClient(apiKey);
           
            var msg = MailHelper.CreateSingleEmail(new EmailAddress(Options.SupportEmail, "Password Link"), new EmailAddress(toEmail), subject, message, message);
            // Disable click tracking.
            // See https://sendgrid.com/docs/User_Guide/Settings/tracking.html
            msg.SetClickTracking(false, false);
            var response = await client.SendEmailAsync(msg);
            _logger.LogInformation(response.IsSuccessStatusCode 
                                ? $"Email to {toEmail} queued successfully!"
                                : $"Failure Email to {toEmail}");
        }
    }

}