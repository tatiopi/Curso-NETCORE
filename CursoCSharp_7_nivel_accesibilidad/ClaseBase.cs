using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp_7_nivel_accesibilidad
{
    public class ClaseBase
    {
        // Acceder desde todos los stios
        public string Telefono { get; set; }
        // Constructor de la clase o funciones de la clase
        private int Edad { get; set; }
        // Dentro del mismo ensamblado , el emsablado en nuestro actual seria
        // CursoCSharp_7_nivel_accesibilidad
        internal string Nombre { get; set; }
        // Solamente puede acceder de la misma clase o clases derivadas
        protected string Apellidos { get; set; }
        // Solamente dentro del mismo ensamblado y ademas dentro de la misma clase o
        // clase derivada
        protected internal string Nacionalidad { get; set; }

        public ClaseBase()
        {
            Edad = 16;
            Apellidos = "Lopez";
        }

    }
}
