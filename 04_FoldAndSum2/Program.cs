using System;
using System.Linq;

namespace _04_FoldAndSum2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = intArray.Length / 4;
            int[] outputArray = new int[k * 2];
            int[] reversedLeftArray = new int[k];
            int[] reversedRightArray = new int[k];
            int[] midleArray = new int[k * 2];

            for (int i = 0; i < midleArray.Length; i++)
            {
                midleArray[i] = intArray[i + k];
            }

            for (int i = 0; i < k; i++)
            {
                reversedLeftArray[i] = intArray[k - 1 - i];
                reversedRightArray[i] = intArray[k * 4 - 1 - i];
                outputArray[i] = reversedLeftArray[i];
                outputArray[i + k] = reversedRightArray[i];
            }

            for (int i = 0; i < k * 2; i++)
            {
                outputArray[i] = midleArray[i] + outputArray[i];
                Console.Write(outputArray[i] + " ");
            }

        }
    }
}
