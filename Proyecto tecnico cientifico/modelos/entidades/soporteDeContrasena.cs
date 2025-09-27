using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelos.entidades
{
    public class soporteDeContrasena:OlvidasteLaContraseña
    {
        public soporteDeContrasena()
        {
            Sendermail = "roberth.rodriguez0810@gmail.com";
            Password = "qyba pxis iyqh kzlm";
            Host = "smtp.gmail.com";
            Port = 587;
            Ssl = true;
            initializaSmtpCLient();
        }
    }
}
