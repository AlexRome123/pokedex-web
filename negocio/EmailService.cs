using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class EmailService
    {
        private MailMessage Email;
        private SmtpClient server;

        public EmailService()
        {
            server = new SmtpClient();
            server.Credentials = new NetworkCredential("7bbfcc3a86f330", "29728e935aa63c");
            server.EnableSsl = true;
            server.Port = 587;
            server.Host = "sandbox.smtp.mailtrap.io";
        }
        public void armarCorreo(string emailDestino,string asunto, string cuerpo)
        {
            Email= new MailMessage();
            Email.From = new MailAddress("noResponder@pokedexWeb.com");
            Email.To.Add(emailDestino);
            Email.Subject = asunto;
            //Email.IsBodyHtml = true;
            Email.Body = cuerpo;
        }
        public void enviarMail()
        {
            try
            {
                server.Send(Email);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
