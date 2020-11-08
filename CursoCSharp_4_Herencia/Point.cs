using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp_4_Herencia
{
    class Point
    {
        public int x { get; private set; }
        public int y { get; private set; }

        public void SetX(int value)
        {
            if (value < 100)
            {
                x = value;
            }
            else
                throw new ArgumentOutOfRangeException();
        }

        public void SetY(int value)
        {
            if (value < 100)
            {
                x = value;
                Console.WriteLine(GetX());
                Console.WriteLine(GetY());

            }
            else
                throw new ArgumentOutOfRangeException();
        }

        public void SetXPrivate(int value)
        {
            if (value < 100)
            {
                x = value;
            }
            else
                throw new ArgumentOutOfRangeException();
        }


        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }

    }
}
