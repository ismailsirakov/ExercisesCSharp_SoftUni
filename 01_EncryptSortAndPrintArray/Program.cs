using System;

namespace _01_EncryptSortAndPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int stringsCount = int.Parse(Console.ReadLine());
            int[] stringsCodes = new int[stringsCount];
            string currentString;


            for (int i = 0; i < stringsCount; i++)
            {
                currentString = Console.ReadLine();

                for (int j = 0; j < currentString.Length; j++)
                {
                    switch (currentString[j])
                    {
                        case 'a':
                        case 'A':
                        case 'e':
                        case 'E':
                        case 'i':
                        case 'I':
                        case 'o':
                        case 'O':
                        case 'u':
                        case 'U':
                            stringsCodes[i] += currentString[j] * currentString.Length;
                            break;

                        default:
                            stringsCodes[i] += currentString[j] / currentString.Length;
                            break;
                    }
                }

            }

            for (int i = 0; i < stringsCodes.Length; i++)
            {
                for (int j = i + 1; j < stringsCodes.Length; j++)
                {
                    if (stringsCodes[j] < stringsCodes[i])
                    {
                        int tempNum = stringsCodes[i];
                        stringsCodes[i] = stringsCodes[j];
                        stringsCodes[j] = tempNum;

                    }
                }
            }

            for (int i = 0; i < stringsCodes.Length; i++)
            {
                Console.WriteLine(stringsCodes[i]);
            }


        }
    }
}
