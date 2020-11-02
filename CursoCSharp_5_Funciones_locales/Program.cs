using System;
using System.Collections.Generic;

namespace CursoCSharp_5_Funciones_locales
{
    class Program
    {
        static void Main(string[] args)
        {
            EjemploFuncionLocal();

        }

        public static void FuncionPrincipal (int numero)
        {
            Console.WriteLine("Estamos dentro de la funcion principal " + numero);

            numero = numero + 10;

            funcionLocal(numero);

            void funcionLocal(int numeroLocal)
            {
                numeroLocal = numeroLocal * 15;
                Console.WriteLine(numeroLocal);
            }

        }

        public static void EjemploFuncionLocal()
        {
            int total = 0;
            List<int> lista = new List<int>();
            lista.Add(4);
            lista.Add(5);
            lista.Add(17);

            foreach(var numero in lista)
            {
                total = Suma(numero, total);
                Console.WriteLine(total);
            }

            Console.ReadLine();

            int Suma(int numero , int totalSuma)
            {
                return numero + totalSuma;
            }
        }

    }
}
