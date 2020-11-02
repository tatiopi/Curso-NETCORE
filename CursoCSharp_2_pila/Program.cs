using System;
using System.Collections;

namespace CursoCSharp_2_pila
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack pila = new Stack();
            pila.Push(1);
            pila.Push(5);
            pila.Push(10);
            pila.Push(3);

            var numero = pila.Pop();
            Console.WriteLine(numero);
            Console.ReadLine();

            // contar elementos
            int contador = pila.Count;

            // limpiar la pila
            pila.Clear();

            if (pila.Contains(10))
            {
                Console.WriteLine("Contiene un 10");
            }
        }
    }
}
