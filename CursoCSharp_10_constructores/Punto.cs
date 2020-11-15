using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp_10_constructores
{
    public class Punto
    {
        private int X { get; set; }
        private int Y { get; set; }

        public Punto()
        {
            X = 0;
            Y = 0;
        }

        public Punto(int x , int y)
        {
            X = x;
            Y = y;
        }

        public Punto(int x)
        {
            X = x;
        }

    }
}
