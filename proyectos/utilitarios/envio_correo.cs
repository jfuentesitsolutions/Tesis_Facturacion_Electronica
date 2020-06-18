using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.IO;


namespace utilitarios
{
    public class envio_correo
    {
        private MailMessage correo;
        private MailAddress remitente;
        private SmtpClient cliente;
        private NetworkCredential credenciales;

        public envio_correo(string destinatario, string asunto, string cuerpo, string ruta_xml, string ruta_pdf)
        {
            this.correo = new MailMessage();
            correo.To.Add(destinatario);
            correo.Subject = asunto;
            correo.SubjectEncoding = System.Text.Encoding.UTF8;
            correo.Body = cuerpo;
            correo.BodyEncoding = System.Text.Encoding.UTF8;
            correo.IsBodyHtml = true;
            if (File.Exists(ruta_xml))
            {
                correo.Attachments.Add(new Attachment(ruta_xml));
            }

            if (File.Exists(ruta_pdf))
            {
                correo.Attachments.Add(new Attachment(ruta_pdf));
            }

            this.remitente = new MailAddress("vfjhovanyitsolutions@gmail.com");
            correo.From = remitente;

            this.cliente = new SmtpClient();
            this.credenciales = new NetworkCredential("vfjhovanyitsolutions@gmail.com", "Fuentes2019");

            cliente.Credentials = credenciales;
            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.Host = "smtp.gmail.com";
           
        }

        public bool enviar_correo()
        {
            try
            {
                this.cliente.Send(correo);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
