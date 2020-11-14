using System;
using System.Collections.Generic;
using System.Text;

namespace ClaseAbstracta
{
    public abstract class Clase : ClaseAbastracta
    {
        public override int sumar(int i, int z)
        {
            return i + z;
        }

        public abstract override int Restar(int i, int z);
    }
}
