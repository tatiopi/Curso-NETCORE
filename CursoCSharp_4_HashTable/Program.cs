using System;
using System.Collections;

namespace CursoCSharp_4_HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();

            // añadir valores 
            hashtable.Add("Alejandro", 1.22);
            hashtable.Add("Rodrigo", 5.21);
            hashtable.Add("Miriam",9.62);

            foreach(DictionaryEntry item in hashtable)
            {
                Console.WriteLine(item.Value + " " + item.Key);
            }

            // Numero de elementos

            var cuantos = hashtable.Count;

            // Contiene un elemento
            if (hashtable.Contains("Alejandro"))
            {

            }


            // Eliminar un elemento
            hashtable.Remove("Alejandro");

            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine("2º " + item.Value + " " + item.Key);
            }


            Console.ReadLine();

            // Limpiar el hashtable
            hashtable.Clear();

        }
    }
}
