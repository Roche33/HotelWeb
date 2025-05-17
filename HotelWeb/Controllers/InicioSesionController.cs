using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace HotelWeb.Controllers
{
    public class InicioSesionController : Controller
    {
        // GET: InicioSesion
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult IniciarSesion(FormCollection form)
        {

            string nombre = form["nombre"];
            ViewData["mensaje"] = "La informacion se guardo correctamente";
            return View("Index");
        }

        public ActionResult Guardar(FormCollection form)
        {
            string nombre = form["nombre"];
            ViewData["mensaje"] = "La informacion se guardo correctamente";
            return View("Index");
        }

        public ActionResult RecuperarContrasena(FormCollection form)
        {
            string correo = form["correo"];

            string smtpServer = "smtp.gmail.com";
            int smtpPort = 587;
            string correoEnvia = "misael.roche@uabc.edu.mx";
            string pass = "erlpzgacnjizlcbf";
            string recibe = correo;


            try
            {

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(correoEnvia);
                mail.To.Add(recibe);


                mail.Subject = "Cambio de contraseña";
                string htmlBody = $@"
                            <html>
                                <body style=""font-family: Arial, sans-serif; line-height: 1.6; color: #333333; max-width: 1000px; margin: 0 auto; padding: 20px;"">
                                    <div style=""background-color: #264653; color: white; padding: 10px 20px; text-align: center; border-radius: 5px 5px 0 0;"">
                                        <h1>¡Hola Compadre!</h1>
                                    </div>
                                    <div style=""padding: 20px; background-color: #f9f9f9; border-radius: 0 0 5px 5px;"">
                                        <p>Espero que este mensaje te encuentre bien. Te escribimos para informarte sobre el cambio de contraseña que haz solicitado</p>
        
                                        <p>Tu nueva contraseña es:</p>
                                        <p><strong>IUijhhv34ed</strong></p>
                                        <p>Si tienes alguna pregunta, no dudes en contactarnos.</p>
        
                                        <p>Saludos cordiales,</p>
                                        <p><strong>El equipo de Hoteles Topacios</strong></p>
                                    </div>
                                </body>

                            </html>";


                mail.Body = htmlBody;
                mail.IsBodyHtml = true;


                SmtpClient smtpCliente = new SmtpClient(smtpServer, smtpPort);
                smtpCliente.Credentials = new NetworkCredential(correoEnvia, pass);
                smtpCliente.EnableSsl = true;


                smtpCliente.Send(mail);
                ViewData["mensaje"] = $"La informacion no se guardo correctamente{correo}";

            }
            catch (Exception ex)
            {
                ViewData["mensaje"] = $"La informacion no se guardo correctamente{correo}";
            }
            return View("Index");
        }
    }
}