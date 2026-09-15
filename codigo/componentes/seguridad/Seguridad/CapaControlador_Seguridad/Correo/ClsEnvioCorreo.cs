using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;

namespace CapaControlador_Seguridad.Correo
{
    // Envío de correo genérico por SMTP (Gmail + Contraseña de aplicación).
    // Las credenciales se leen del App.config del ejecutable
    // (Ejecucion_Seguridad), nunca quedan escritas en el código.
    public class ClsEnvioCorreo
    {
        public void SeguridadMetEnviarCorreo(string CorreoDestino, string Asunto, string CuerpoHtml)
        {
            var Servidor = ConfigurationManager.AppSettings["SmtpServidor"];
            var Puerto = int.Parse(ConfigurationManager.AppSettings["SmtpPuerto"]);
            var Usuario = ConfigurationManager.AppSettings["SmtpUsuario"];
            var ContrasenaApp = ConfigurationManager.AppSettings["SmtpContrasenaApp"];

            var Mensaje = new MimeMessage();
            Mensaje.From.Add(MailboxAddress.Parse(Usuario));
            Mensaje.To.Add(MailboxAddress.Parse(CorreoDestino));
            Mensaje.Subject = Asunto;

            var Cuerpo = new BodyBuilder { HtmlBody = CuerpoHtml };
            // el encabezado y el pie son imágenes fijas del diseño, van
            // embebidas en el propio correo (no como link externo, porque
            // Gmail/Outlook bloquean imágenes externas por defecto)
            SeguridadMetAdjuntarImagenEmbebida(Cuerpo, "header.jpg", "encabezado");
            SeguridadMetAdjuntarImagenEmbebida(Cuerpo, "footer.jpg", "pie");
            Mensaje.Body = Cuerpo.ToMessageBody();

            using (var Cliente = new SmtpClient())
            {
                Cliente.Connect(Servidor, Puerto, SecureSocketOptions.StartTls);
                Cliente.Authenticate(Usuario, ContrasenaApp);
                Cliente.Send(Mensaje);
                Cliente.Disconnect(true);
            }
        }

        // Las imágenes van como "Embedded Resource" del proyecto
        // (Correo/Recursos/header.jpg y footer.jpg) para no depender de una
        // ruta de archivo en disco. Busca por el nombre de archivo al final
        // del recurso para no depender de escribir el namespace completo a mano.
        private void SeguridadMetAdjuntarImagenEmbebida(BodyBuilder Cuerpo, string NombreArchivo, string ContentId)
        {
            var Ensamblado = Assembly.GetExecutingAssembly();
            var NombreRecurso = Ensamblado.GetManifestResourceNames()
                .FirstOrDefault(n => n.EndsWith("." + NombreArchivo));

            if (NombreRecurso == null)
            {
                throw new FileNotFoundException($"No se encontró la imagen '{NombreArchivo}' como Embedded Resource. " +
                    "Verifica que Correo/Recursos/" + NombreArchivo + " tenga Build Action = Embedded Resource.");
            }

            using (var Flujo = Ensamblado.GetManifestResourceStream(NombreRecurso))
            {
                var Imagen = Cuerpo.LinkedResources.Add(NombreArchivo, Flujo);
                Imagen.ContentId = ContentId;
            }
        }
    }
}
