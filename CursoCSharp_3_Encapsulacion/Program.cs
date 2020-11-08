using System;

namespace CursoCSharp_3_Encapsulacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Point2D punto = new Point2D();
            /*try
            {
                punto.SetX(2);
                punto.SetY(2);
            }
            catch(Exception e)
            {
                Console.WriteLine("Excepcion");
            }*/

            // hemos cambiado la variable x a privada
            punto.SetXPrivate(56);
            punto.y = 57;



        }
    }
}
