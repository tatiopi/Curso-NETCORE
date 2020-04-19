using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queu
{
    class Program
    {
        static void Main(string[] args)
        {
            // FIFO -> First In First Out
            Queue cola = new Queue();

            cola.Enqueue(3);
            cola.Enqueue(5);
            cola.Enqueue(1);

            // extraer - primero elemento de la cola
            var valorCola = cola.Dequeue();
            Console.WriteLine(valorCola);
            Console.ReadLine();

            valorCola = cola.Dequeue();
            Console.WriteLine(valorCola);
            Console.ReadLine();

            // Quiero ver el siguiente valor sin sacarlo
            var valor = cola.Peek();

            if (cola.Contains(1))
            {
                Console.WriteLine("lo contiene");
            }

            Console.ReadLine();

            // Limpiar la cola
            cola.Clear();

            cola.Enqueue(3);
            cola.Enqueue(5);
            cola.Enqueue(8);
            cola.Enqueue(13);

            // Numero de elementos
            int elementos = cola.Count;
            Console.WriteLine($"Contiene {elementos} elementos la cola");

            // Recorrer la cola
            foreach(var elemento in cola)
            {
                Console.WriteLine($"El elemento es {elemento}");
            }

            Console.ReadLine();

        }
    }
}
