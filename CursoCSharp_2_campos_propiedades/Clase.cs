using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp_2_campos_propiedades
{
    class Clase
    {
        // Campos o propiedades
        public int Campo;
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get;private set; }
        public int Estado = 1;

        // Este campo solo se puede asignar en el constructor o cuando se declara
        public readonly string Identificador;

        public Clase()
        {
            Identificador = "ABCD";
            Edad = 21;
        }

        public void Metodo()
        {
            // No se puede cambiar aqui la variable READONLY
            //Identificador = "XXX";
        }

    }
}
