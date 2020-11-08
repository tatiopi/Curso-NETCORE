using System;
using System.Collections.Generic;

namespace CursoCSharp_5_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Gato gato = new Gato();
            gato.HacerRuido();

            Perro perro = new Perro();
            perro.HacerRuido();

            Lobo lobo = new Lobo();
            lobo.HacerRuido();

            List<Animal> zoo = new List<Animal>();

            zoo.Add(gato);
            zoo.Add(perro);
            zoo.Add(lobo);

            Console.WriteLine("----------------------------------------------------------------------");

            foreach( var animal in zoo)
            {
                animal.HacerRuido();
            }

            Console.ReadLine();
        }
    }
}
