using SRP;
namespace ProyectoSRP
    
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Practica de SRP");
          
                Persona persona = new Persona("Jose", 30, "Calle Principal 123", "jose@example.com");

               
                persona.ImprimirDatos();

                
                Gcorreos gestorCorreos = new Gcorreos();

                
                string destinatario = "Miguel@example.com";
                string mensaje = "¡Hola! ¿Cómo estás?";
                gestorCorreos.EnviarCorreoElectronico(destinatario, mensaje);
            }
        }

    }
