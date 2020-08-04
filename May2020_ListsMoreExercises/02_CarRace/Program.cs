using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> timeList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();
            double leftCarTime = 0.0;
            double rightCarTime = 0.0;

            for (int i = 0; i < timeList.Count / 2; i++)
            {
                leftCarTime += timeList[i];
                if (timeList[i] == 0)
                {
                    leftCarTime *= 0.8;
                }

                rightCarTime += timeList[timeList.Count - i - 1];
                if (timeList[timeList.Count - i - 1] == 0)
                {
                    rightCarTime *= 0.8;
                }
            }

            if (leftCarTime < rightCarTime)
            {
                Console.WriteLine($"The winner is left with total time: {Math.Round(leftCarTime, 2)}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {Math.Round(rightCarTime, 2)}");
            }
        }
    }
}
