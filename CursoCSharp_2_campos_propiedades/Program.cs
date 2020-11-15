using System;

namespace CursoCSharp_2_campos_propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Clase clase = new Clase();
            clase.Campo = 12;
            clase.Apellidos = "Lopez Serrano";
            // No he podido por que tiene PRIVATE
            //clase.Edad = 12;

            Console.WriteLine(clase.Edad);
            _ = Console.ReadLine();

        }
    }
}
