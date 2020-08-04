using System;
using System.Linq;

namespace _04_FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] outputArray = new int[intArray.Length / 2];
            int outsideLength = outputArray.Length / 2;

            for (int i = 0; i < outputArray.Length; i++)
            {
                if (i < outputArray.Length / 2)
                {
                    outputArray[i] = intArray[outsideLength - 1 - i] + intArray[outsideLength + i];
                }
                else
                {
                    outputArray[i] = intArray[outsideLength + i] + intArray[intArray.Length + outsideLength - 1 - i];
                }
            }

            for (int i = 0; i < outputArray.Length; i++)
            {
                Console.Write(outputArray[i] + " ");
            }
        }
    }
}
