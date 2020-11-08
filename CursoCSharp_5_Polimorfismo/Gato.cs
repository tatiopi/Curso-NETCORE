using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp_5_Polimorfismo
{
    public class Gato : Animal
    {
        public override void HacerRuido()
        {
            Console.WriteLine("El gato hace prauu");
        }
    }
}
