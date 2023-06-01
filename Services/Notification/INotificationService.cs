using MimeKit;
namespace rbl_tracker.Services.Notification
{
    public interface INotificationService
    {
        Task<bool> SendAsync(string rcpt, BodyBuilder body,CancellationToken ct);
    }
}