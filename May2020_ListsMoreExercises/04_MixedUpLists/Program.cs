using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_MixedUpLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList1 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> numList2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> mixedList = new List<int>();
            int length = Math.Min(numList1.Count, numList2.Count);


            for (int i = 0; i < length; i++)
            {
                mixedList.Add(numList1[i]);
                mixedList.Add(numList2[numList2.Count - 1 - i]);
            }

            int minNum;
            int maxNum;

            if (numList1.Count > numList2.Count)
            {
                minNum = Math.Min(numList1[numList1.Count - 2], numList1[numList1.Count - 1]);
                maxNum = Math.Max(numList1[numList1.Count - 2], numList1[numList1.Count - 1]);
            }
            else
            {
                minNum = Math.Min(numList2[0], numList2[1]);
                maxNum = Math.Max(numList2[0], numList2[1]);
            }

            mixedList.Sort();

            foreach (var item in mixedList)
            {
                if (item > minNum && item < maxNum)
                {
                    Console.Write(item + " ");
                }
            }

        }
    }
}
