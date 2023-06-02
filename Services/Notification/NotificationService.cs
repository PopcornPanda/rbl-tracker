using MailKit.Net.Smtp;
using MailKit.Security;
using rbl_tracker.Configuration;
using Microsoft.Extensions.Options;
using MimeKit;
using MimeKit.Utils;

namespace rbl_tracker.Services.Notification
{
    public class NotificationService : INotificationService
    {
        private readonly MailSettings _settings;
        public NotificationService(IOptions<MailSettings> settings)
        {
            _settings = settings.Value;
        }

        public async Task<bool> SendAsync(string rcpt, BodyBuilder body, string subject, CancellationToken ct)
        {
            var msg = new MimeMessage();
            msg.From.Add(new MailboxAddress(_settings.DisplayName, _settings.From));
            msg.Sender = new MailboxAddress(_settings.DisplayName, _settings.From);
            msg.MessageId = MimeUtils.GenerateMessageId();
            msg.To.Add(MailboxAddress.Parse(rcpt));
            msg.Subject = subject;
            msg.Body = body.ToMessageBody();

            try
            {
                using var smtp = new SmtpClient();

                if (_settings.UseSSL)
                {
                    await smtp.ConnectAsync(_settings.Host, _settings.Port, SecureSocketOptions.SslOnConnect, ct);
                }
                else if (_settings.UseStartTls)
                {
                    await smtp.ConnectAsync(_settings.Host, _settings.Port, SecureSocketOptions.StartTls, ct);
                }
                await smtp.AuthenticateAsync(_settings.UserName, _settings.Password, ct);
                await smtp.SendAsync(msg, ct);
                await smtp.DisconnectAsync(true, ct);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}