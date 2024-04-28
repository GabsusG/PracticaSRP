using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class Gcorreos
    {
        public void EnviarCorreoElectronico(string destinatario, string mensaje)
        {

            Console.WriteLine($"Enviando correo electrónico a {destinatario}: {mensaje}");
        }
    }
}