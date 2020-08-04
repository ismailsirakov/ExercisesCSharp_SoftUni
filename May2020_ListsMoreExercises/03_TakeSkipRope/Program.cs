using System;
using System.Collections.Generic;

namespace _03_TakeSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            List<int> numbersList = new List<int>();
            List<string> nonNumList = new List<string>();
            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();
            List<string> result = new List<string>();

            for (int i = 0; i < text.Length; i++)
            {
                if (int.TryParse(text[i].ToString(), out int num))
                {
                    numbersList.Add(num);
                }
                else
                {
                    nonNumList.Add(text[i].ToString());
                }
            }

            for (int i = 0; i < numbersList.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numbersList[i]);
                }
                else
                {
                    skipList.Add(numbersList[i]);
                }
            }

            int takeCount;
            int skipCount;
            int currentIndex = 0;

            for (int i = 0; i < takeList.Count; i++)
            {
                takeCount = takeList[i];
                skipCount = skipList[i];

                for (int k = 0; k < takeCount; k++)
                {
                    if (currentIndex + k < nonNumList.Count)
                    {
                        result.Add(nonNumList[currentIndex + k]);
                    }
                }
                currentIndex += takeCount + skipCount;
            }

            Console.WriteLine(string.Join("", result));
        }
    }
}
