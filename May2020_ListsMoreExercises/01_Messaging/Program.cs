using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _01_Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string text = Console.ReadLine();
            List<string> letterList = new List<string>();
            for (int i = 0; i < text.Length; i++)
            {
                letterList.Add(text[i].ToString());
            }
            string message = "";
            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumber = numbers[i];
                while (currentNumber > 0)
                {
                    sum += currentNumber % 10;
                    currentNumber /= 10;
                }

                int index = sum % letterList.Count;
                message += letterList[index];
                letterList.RemoveAt(index);
                sum = 0;

            }

            Console.WriteLine(message);
        }
    }
}
