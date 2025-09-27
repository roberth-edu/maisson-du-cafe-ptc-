using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;

namespace modelos.entidades
{
     public abstract class OlvidasteLaContraseña: IDisposable
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

        protected void initializaSmtpCLient()
        {
            smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential("roberth.rodriguez0810@gmail.com", "qyba pxis iyqh kzlm");
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
        }

        public bool EnviarMail(string subject, string body, List<string> recipientMail)
        {
            var mailMessage = new MailMessage();
            try
            {
                mailMessage.From = new MailAddress(sendermail);
                foreach (string mail in recipientMail)
                {
                    mailMessage.To.Add(mail);
                }
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
