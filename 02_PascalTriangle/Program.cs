using System;
using System.Globalization;

namespace _02_PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            int[,] pascalTriangleNumbers = new int[n, n];
            string[,] pascalTriangleString = new string[n, n];

            pascalTriangleNumbers[0, 0] = 1;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    if (col == 0)
                    {
                        pascalTriangleNumbers[row, col] = 1;
                    }
                    else
                    {
                        pascalTriangleNumbers[row, col] = pascalTriangleNumbers[row - 1, col] + pascalTriangleNumbers[row - 1, col - 1];
                    }

                }

            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (pascalTriangleNumbers[i, j] == 0)
                    {
                        pascalTriangleString[i, j] = " ";
                    }
                    else
                    {
                        pascalTriangleString[i, j] = pascalTriangleNumbers[i, j].ToString();
                    }

                }

            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(pascalTriangleString[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
