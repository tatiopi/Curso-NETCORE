using System;
using System.Collections;

namespace CursoCSharp_3_queu
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue cola = new Queue();

            // añadir valores a la cola
            cola.Enqueue(3);
            cola.Enqueue(5);
            cola.Enqueue(1);

            //extraer valores de la cola
            var valorCola = cola.Dequeue();
            Console.WriteLine(valorCola);

            valorCola = cola.Dequeue();
            Console.WriteLine(valorCola);

            // Peek te permite coger el valor que esta al principio
            // de la cola
            var valor = cola.Peek();
            Console.WriteLine(valor);

            if (cola.Contains(1))
            {
                Console.WriteLine("Contiene el 1");
            }

            // vaciar la cola
            cola.Clear();

            // numero de elementos
            cola.Enqueue(3);
            cola.Enqueue(5);
            cola.Enqueue(1);
            Console.WriteLine(cola.Count);

            Console.ReadLine();
        }
    }
}
