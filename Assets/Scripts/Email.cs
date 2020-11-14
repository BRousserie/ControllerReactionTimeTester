using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public static class Email
{
    private static void Send(string to, string subject, string body, string sender, string password)
    {
        MailMessage mail = new MailMessage();
        mail.From = new MailAddress(sender);
        mail.To.Add(to);
        mail.Subject = subject;
        mail.Body = body;
        // you can use others too.
        SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
        smtpServer.Port = 587;
        smtpServer.Credentials = new System.Net.NetworkCredential(sender, password) as ICredentialsByHost;
        smtpServer.EnableSsl = true;
        ServicePointManager.ServerCertificateValidationCallback =
            delegate(object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
            { return true; };
        smtpServer.Send(mail);
        Debug.Log("Email Sent");
    }

    public static void SendClara(string subject, string body)
    {
        Send("", subject, body, "", "");
    }
}
