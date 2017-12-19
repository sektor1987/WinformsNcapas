using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class Helper
    {

        public static Boolean emailNotification(string toAd, string toName)
        {

            try
            {
                var fromAddress = new MailAddress("devtestortuzaro@gmail.com", "Municipalidad Vista Hermosa");
                var toAddress = new MailAddress(toAd, toName);
                const string fromPassword = "Dirty1987";

                SmtpClient smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };

                MailMessage myMail = new System.Net.Mail.MailMessage(fromAddress, toAddress);

                // set subject and encoding
                myMail.Subject = "Solicitud de Permiso Autorizada";
                myMail.SubjectEncoding = System.Text.Encoding.UTF8;

                // set body-message and encoding
                myMail.Body = "Estimado <b>Funcionario,</b> <br>";
                myMail.Body += "<br>Le informamos a través del presente correo, que su solicitud fue aprobada y/o autorizada.<br>";
                myMail.Body += "<br>Porfavor no responder este correo.";
                myMail.Body += "<br>Iluste Municipalidad de Vista Hermosa";

                myMail.BodyEncoding = System.Text.Encoding.UTF8;
                // text or html
                myMail.IsBodyHtml = true;

                smtp.Send(myMail);
                return true;
            }
            catch (SmtpException ex)
            {
                throw new ApplicationException
                  ("SmtpException has occured: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
