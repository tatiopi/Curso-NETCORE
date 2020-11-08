using System;

namespace CursoCSharp_1_Objetos_Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CuentaBancaria cuenta1 = new CuentaBancaria();
            CuentaBancaria cuenta2 = new CuentaBancaria();

            cuenta1.Saldo = 1500;
            cuenta1.Saldo = 2000;

        }
    }
}
