using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilasOStacks
{
    class Program
    {
        static void Main(string[] args)
        {
            // LIFO : Last In First Out
            Stack pila = new Stack();

            pila.Push(1);
            pila.Push(2);
            pila.Push(3);

            var numero = pila.Pop();

            Console.WriteLine(numero);
            Console.ReadLine();

            foreach(var item in pila)
            {
                Console.WriteLine(item);
                //Console.ReadLine();
            }

            int contador = pila.Count;

            // limpiar la pila
            pila.Clear();

            if (pila.Contains(10))
            {
                Console.WriteLine('Contiene un 10');
            }

        }
    }
}
