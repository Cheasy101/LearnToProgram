using Application.Interfaces;
using Microsoft.Extensions.Configuration;
using MimeKit;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;

namespace Services.EmailSender;

/// <inheritdoc cref="IEmailSender"/>
public class EmailSender(IConfiguration configuration) : IEmailSender
{
    public async Task SendEmailAsync(string to, string message, CancellationToken cancellationToken)
    {
        var emailConfiguration = configuration.GetSection("EmailSettings");

        using var emailMessage = new MimeMessage();
        emailMessage.From.Add(new MailboxAddress(emailConfiguration["FromName"], emailConfiguration["EmailAddress"]));
        emailMessage.To.Add(MailboxAddress.Parse(to));
        emailMessage.Subject = emailConfiguration["FromName"];

        var bodyBuilder = new BodyBuilder { HtmlBody = message };
        emailMessage.Body = bodyBuilder.ToMessageBody();

        using var client = new SmtpClient();

        var host = emailConfiguration["SMTPServerHost"];
        var port = int.Parse(emailConfiguration["SMTPServerPort"]!);
        var useSsl = bool.Parse(emailConfiguration["UseSsl"] ?? "true");

        await client.ConnectAsync(host, port, useSsl, cancellationToken);
        await client.AuthenticateAsync(emailConfiguration["EmailAddress"], emailConfiguration["Password"], cancellationToken);
        await client.SendAsync(emailMessage, cancellationToken);
        await client.DisconnectAsync(true, cancellationToken);
    }
}