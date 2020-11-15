using System;

namespace CursoCSharp_12_Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Punto punto = new Punto(200,50);
            punto = +punto;

            Console.WriteLine($"X = {punto.X} Y = {punto.Y}");
            Console.ReadLine();

            punto = -punto;


            Console.WriteLine($"X = {punto.X} Y = {punto.Y}");
            Console.ReadLine();
        }
    }
}
