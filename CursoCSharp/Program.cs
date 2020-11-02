using System;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayDeEnteros;
            int[] arrayDeEnteros2 = new int[5];
            int[] arrayDeEnteros3 = { 1, 2, 3, 4 };

            // Matrices 
            int[,] arrayDeEnteros2Dimensiones = new int[2, 2];
            int[,] arrayDeEnteros2Dimensiones2 = { { 1, 2, 3 }, { 2, 3, 4 } };
            int[][] arrayDeEnterosEscalonados = new int[6][];

            // Escalonado : 4 elementos 
            arrayDeEnterosEscalonados[0] = new int[4] { 3, 6, 7, 2 };
            arrayDeEnterosEscalonados[1] = new int[2] { 1, 3 };

            for (int i = 0; i < arrayDeEnteros3.Length; i++)
            {
                Console.WriteLine(arrayDeEnteros3[i]);
            }

            Console.ReadLine();

            // ejercicio 
            int[] enteros1 = new int[3];
            int[,] enteros2 = new int[3, 3];
            int[,] enteros3 =  { { 1, 2, 3 }, { 1, 2, 3 } };
            int[][] enteros4 = new int[6][];
            enteros4[0] = new int[5] { 1, 3, 4, 5, 6 };

            for (int i = 0; i < arrayDeEnterosEscalonados.GetLongLength(0); i++)
            {
                for (int x = 0; x < arrayDeEnterosEscalonados.GetLongLength(1);x++)
                {
                    Console.WriteLine(arrayDeEnterosEscalonados[i][x]);
                }
            }
            
            Console.ReadLine();

        }
    }
}
