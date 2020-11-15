using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp_3_metodos
{
    class Clase
    {
        public int Campo;
        public string Nombre { get; set; }
        public readonly string Identificador = "XX";
        public Clase()
        {

        }

        // Metodo
        public void Calcular (int edad)
        {
            Console.WriteLine(edad + 15);
        }
    }
}
