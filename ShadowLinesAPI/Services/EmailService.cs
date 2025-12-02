using System.Net;
using System.Net.Mail;
using Microsoft.Extensions.Options;

public class EmailService
{
    private readonly SmtpSettings _settings;

    public EmailService(IOptions<SmtpSettings> settings)
    {
        _settings = settings.Value;
    }

    public async Task EnviarEmailAsync(EmailRequest req)
    {
        using (var client = new SmtpClient(_settings.Host, _settings.Port))
        {
            client.EnableSsl = _settings.UseSsl;
            client.Credentials = new NetworkCredential(_settings.User, _settings.Password);

            var mail = new MailMessage
            {
                From = new MailAddress(_settings.User),
                Subject = req.Assunto,
                Body = req.Mensagem,
                IsBodyHtml = true
            };

            mail.To.Add(req.Para);

            await client.SendMailAsync(mail);
        }
    }
}
