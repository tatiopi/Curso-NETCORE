using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp_5_Polimorfismo
{
    class Perro : Animal
    {
        public override void HacerRuido()
        {
            Console.WriteLine("El perro hace guauuu");
        }
    }
}
