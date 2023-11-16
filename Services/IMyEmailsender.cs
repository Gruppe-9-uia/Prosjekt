namespace Prosjekt.Services
{
    public interface IMyEmailsender
    {
        public Task SendEmailAsync(string email, string subject, string message);
    }
}
