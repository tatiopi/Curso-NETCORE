using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp_3_Encapsulacion
{
    class Point2D
    {
        public int x { get; private set; }
        public int y { get; set; }

        /*
         *  FORMA 1
         */
        //public void SetX(int value)
        //{
        //    if (value < 100)
        //    {
        //        x = value;
        //    }
        //    else
        //        throw new ArgumentOutOfRangeException();
        //}

        //public void SetY(int value)
        //{
        //    if (value < 100)
        //    {
        //        x = value;
        //        Console.WriteLine(GetX());
        //        Console.WriteLine(GetY());

        //    }
        //    else
        //        throw new ArgumentOutOfRangeException();
        //}

        /*
         * FORMA 2
         */


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
