using System;
using System.Collections.Generic;

namespace CurspCSharp_7_clases_estaticas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

<<<<<<< HEAD

    // Se suelen usar las clases staticas en helpers o factorias
=======
>>>>>>> 847d3cf5ef13ce08f5d18565b54540ed533b25e6
    public class ClassConInstancia
    {
        public int InstanceProperty { get; set; }
        public void InstanceMethod() { Console.WriteLine($"Property Value: {InstanceProperty}")};
    }

    public static class FibonnaciNumberCalculator
    {
        public static int GetFibonacciNumber(int n)
        {
            if (n < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(n));
            }
            else if  (n < 2 ) { return n; }
            else
            {
                var numbers = new List<int> { 0, 1 };

                for (int i = 2; i<n; i++)
                {
                    numbers.Add(numbers[i - 1] + numbers[i - 2]);
                }

                return numbers[n];
            }
        }
    }
}
