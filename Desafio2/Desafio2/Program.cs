using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotificacionEmail notificacionEmail = new NotificacionEmail();
            notificacionEmail.direccionCorreo = "cristinajera78@gmail.com";

            NotificacionWhatsapp notificacionWhatsapp = new NotificacionWhatsapp();
            notificacionWhatsapp.numeroTelefono = "65789345";

            NotificacionSMS notificacionSms = new NotificacionSMS();
            notificacionSms.numeroTelefono = "76895435";

            notificacionEmail.Notifica();
            notificacionWhatsapp.Notifica();
            notificacionSms.Notifica();

            Console.ReadKey();
        }

        public interface INotificable
        {
            void Notifica();
        }

        public class NotificacionEmail : INotificable
        {
            
            public string direccionCorreo { get; set; }

            public void Notifica()
            {
                Console.WriteLine($"Se enviará notificación de correo electrónico a:  {direccionCorreo}");
            }
        }

        public class NotificacionWhatsapp : INotificable
        {
            public string numeroTelefono { get; set; }

            public void Notifica()
            {
                Console.WriteLine($"Se enviará notificación por WhatsApp a: {numeroTelefono}");
            }

        }

        public class NotificacionSMS : INotificable
        {
            public string numeroTelefono { get; set; }

            public void Notifica()
            {
                Console.WriteLine($"Se enviará notificación por SMS a: {numeroTelefono}");
            }
        }
    }
}
