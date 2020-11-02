using System;
using System.Collections;
using System.Collections.Generic;

namespace CursoCSharp_1_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList
            ArrayList lista = new ArrayList();

            lista.Add(1);
            lista.Add("Batman");

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

            var elemento = lista[0];
            var elemento1 = lista[1];

            int contador = lista.Count;

            lista.Insert(2, "Superman");

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            lista.RemoveAt(1);

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            List<Object> lista2 = new List<Object>();
            lista2.Add(2);
            lista2.Add(4);
            lista2.Add(3);

            foreach (var item in lista2)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
            
        }
    }
}
