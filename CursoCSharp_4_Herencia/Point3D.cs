using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp_4_Herencia
{
    // Se trae los mentodos publicas y protegidas
    // no se puede heredar mas de una clase , a menos que sea una inrerfaz
    class Point3D : Point
    {
        public int z { get; private set; }

        public void SetZ(int value)
        {
            if (value < 100)
            {
                z = value;
            }
            else
                throw new ArgumentOutOfRangeException();
        }

        public int GetZ()
        {
            return z;
        }
    }
}
