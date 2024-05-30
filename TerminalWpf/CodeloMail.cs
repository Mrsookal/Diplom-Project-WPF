using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace TerminalWpf
{
    class CodeloMail
    {
        public static MailMessage CreateMail(string name, string emailfrom, string emailto, string subject, string body)
        {
            var from = new MailAddress(emailfrom, name);
            var to = new MailAddress(emailto);
            var mail = new MailMessage(from, to);
            mail.Subject = subject;
            mail.Body = body;
           
            return mail;

        }
        public static void SendMail(string host, int smtport, string emailfrom, string pass, MailMessage mail)
        {
            SmtpClient smtp = new SmtpClient(host, smtport);
            smtp.Credentials = new NetworkCredential(emailfrom, pass);
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            
            smtp.Send(mail);
        }
    }
}
