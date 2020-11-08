using System;

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

            Console.ReadLine();
        }
    }
}
