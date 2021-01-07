using System;

namespace Task04_Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int finishNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int combinatios = 0;
            bool isFound = false;
            for (int i = startNumber; i <= finishNumber; i++)
            {
                for (int j = startNumber; j <= finishNumber; j++)
                {
                    if (isFound) break;
                    combinatios += 1;
                    if (i + j == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{combinatios} ({i} + {j} = {magicNumber})");
                        isFound = true;
                        break;
                    }
                }
            }
            if (isFound == false)
            {
                Console.WriteLine($"{combinatios} combinations - neither equals {magicNumber}");
            }
        }
    }
}
