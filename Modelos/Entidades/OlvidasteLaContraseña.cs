using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Modelos.Entidades
{
    public abstract class OlvidasteLaContraseña : IDisposable
    {
        private SmtpClient smtpClient;
        private string sendermail;
        private string password;
        private string host;
        private int port;
        private bool ssl;

        protected string Sendermail { get => sendermail; set => sendermail = value; }
        protected string Password { get => password; set => password = value; }
        protected string Host { get => host; set => host = value; }
        protected int Port { get => port; set => port = value; }
        protected bool Ssl { get => ssl; set => ssl = value; }

        // Constructor que recibe los datos del correo
        protected OlvidasteLaContraseña(string sendermail, string password, string host = "smtp.gmail.com", int port = 587, bool ssl = true)
        {
            this.Sendermail = sendermail;
            this.Password = password;
            this.Host = host;
            this.Port = port;
            this.Ssl = ssl;
            initializaSmtpCLient();
        }

        protected void initializaSmtpCLient()
        {
            smtpClient = new SmtpClient(Host, Port)
            {
                EnableSsl = Ssl,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(Sendermail, Password),
                DeliveryMethod = SmtpDeliveryMethod.Network
            };
        }

        public bool EnviarMail(string subject, string body, List<string> recipientMail)
        {
            var mailMessage = new MailMessage();
            try
            {
                mailMessage.From = new MailAddress(Sendermail);
                foreach (string mail in recipientMail)
                    mailMessage.To.Add(mail);

                mailMessage.Subject = subject;
                mailMessage.Body = body;
                mailMessage.Priority = MailPriority.Normal;
                mailMessage.IsBodyHtml = false;

                smtpClient.Send(mailMessage);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ERROR DE EMAIL: {ex.ToString()}", "Error detallado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                mailMessage.Dispose();
            }
        }

        public void Dispose()
        {
            smtpClient?.Dispose();
        }
    }
}
