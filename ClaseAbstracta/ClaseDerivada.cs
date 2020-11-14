using ClaseAbstracta;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp_5_clase_abstracta
{
    public class ClaseDerivada : Clase
    {
        public override int Restar(int i, int z)
        {
            return i - z;
        }
    }
}
