using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hastable = new Hashtable();

            hastable.Add("Alejandro", 1.22);
            hastable.Add("Rodrigo", 5.21);
            hastable.Add("Miriam", 9.21);

            foreach(DictionaryEntry item in hastable)
            {
                Console.WriteLine(item.Value + " " + item.Key);
            }

            var valor = hastable["Alejandro"];
            Console.WriteLine(valor);

            Console.ReadLine();

            // numero de elemento 

            var elementos = hastable.Count;

            // Contiene 

            if (hastable.ContainsKey("Alejandro"))
            {
                Console.WriteLine($"Contiene a Alejandro");
            }

            if (hastable.ContainsValue(9.21))
            {
                Console.WriteLine($"Contiene a Miriam");
            }

            // Eliminar : siemepre por la key
            hastable.Remove("Alejandro");

        }
    }
}
