﻿using System;
using static System.Convert;

namespace CursoCSharp_14_conversiones_tipo
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "Hola";
            int numero = 12;

            cadena = numero.ToString();

            // Implicitos
            int numeroEntero = 345634;
            long numeroLong = numeroEntero;

            // Explicitos
            double numeroDouble = 12.56;
            int numeroEnteroDouble = (int)numeroDouble;

            Console.WriteLine(numeroEnteroDouble);
            Console.ReadLine();

           // Con clases asistentes

            double doubleValor = 8.45;
            int enteroValor = ToInt32(doubleValor);
            int conversion = Convert.ToInt32(doubleValor);

        }
    }
}
