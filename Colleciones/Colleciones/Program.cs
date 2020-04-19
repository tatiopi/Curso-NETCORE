using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colleciones
{
    class Program
    {
        static void Main(string[] args)
        {
            // ArrayList
            ArrayList lista = new ArrayList();
            // Tamaño actual del ArrayList
            Console.WriteLine(lista.Capacity);

            lista.Add(1);
            lista.Add("Batman");

            foreach(var item in lista)
            {
                Console.WriteLine(item);
            }

            var elemento = lista[0];
            Console.WriteLine(elemento);


            lista.Insert(1, "Superman");

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            lista.RemoveAt(0);

            Console.ReadLine();

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            // No se recomienda el uso de ArrayList
            // se recomienda por tema de rendimiento
            // el uso de List<T>

            List<int> lista2 = new List<int>();
            lista2.Add(1);
            lista2.Add(3);
            
            
        }
    }
}
