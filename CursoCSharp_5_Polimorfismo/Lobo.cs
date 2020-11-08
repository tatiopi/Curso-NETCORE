using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp_5_Polimorfismo
{
    class Lobo : Animal
    {
        public override void HacerRuido()
        {
            Console.WriteLine("El lobo hace auuuuuu");
        }
    }
}
