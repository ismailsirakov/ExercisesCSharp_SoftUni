using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_DrumSet
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            List<int> startDrumSet = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> currentDrumSet = new List<int>();
            string command = Console.ReadLine();
            int hitPower = 0;

            for (int i = 0; i < startDrumSet.Count; i++)
            {
                currentDrumSet.Add(startDrumSet[i]);
            }

            while (command != "Hit it again, Gabsy!")
            {
                hitPower = int.Parse(command);

                for (int i = 0; i < currentDrumSet.Count; i++)
                {
                    currentDrumSet[i] -= hitPower;

                    if (currentDrumSet[i] <= 0)
                    {
                        if (3.0m * startDrumSet[i] <= money)
                        {
                            currentDrumSet[i] = startDrumSet[i];
                            money -= 3.0m * startDrumSet[i];
                        }
                        else
                        {
                            currentDrumSet.RemoveAt(i);
                            startDrumSet.RemoveAt(i);
                            i--;
                        }

                    }
                    

                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", currentDrumSet));
            Console.WriteLine($"Gabsy has {money:f2}lv.");
        }
    }
}
