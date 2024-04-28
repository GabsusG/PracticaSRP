namespace SRP
{
    public class Persona
    {
        private string nombre;
        private int edad;
        private string direccion;
        private string correoElectronico;

        public Persona(string nombre, int edad, string direccion, string correoElectronico)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.direccion = direccion;
            this.correoElectronico = correoElectronico;
        }

        public void ImprimirDatos()
        {
            Console.WriteLine($" Nombre: {nombre}");
            Console.WriteLine($" Edad: {edad}");
            Console.WriteLine($" Dirección: {direccion}");
            Console.WriteLine($" Correo electrónico: {correoElectronico}");
        }


    }
}
