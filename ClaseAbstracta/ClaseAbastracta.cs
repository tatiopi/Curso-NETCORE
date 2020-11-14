using System;
using System.Collections.Generic;
using System.Text;

namespace ClaseAbstracta
{
    abstract class ClaseAbastracta
    {
        // Es proporcionar una definicion comun de una clase base 
        // que multiples clases derivadas pueden compartir 
        public abstract int sumar(int i, int z);
        public virtual int Restar(int i, int z)
        {
            return i - z;
        }
    }
}
