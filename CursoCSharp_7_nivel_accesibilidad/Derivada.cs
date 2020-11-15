using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp_7_nivel_accesibilidad
{
    class Derivada : ClaseBase
    {
        public Derivada()
        {
            // No podemos acceder por que la clase base tiene 
            // private en esta propiedad
            // base.Edad = 15;


        }
    }
}
