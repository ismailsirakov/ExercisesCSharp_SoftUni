using System;

namespace _03_RecursiveFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            int[] fibonacciArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                if (i < 2)
                {
                    fibonacciArray[i] = 1;
                }
                else
                {
                    fibonacciArray[i] = fibonacciArray[i - 1] + fibonacciArray[i - 2];
                }

            }

            Console.WriteLine(fibonacciArray[n - 1]);

        }
    }
}
