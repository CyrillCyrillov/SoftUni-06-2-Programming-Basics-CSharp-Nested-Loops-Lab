using System;

namespace Task05_Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            double nextSum = 0;
            while (true)
            {
                string destination = Console.ReadLine();
                if (destination == "End") break;
                double sum = double.Parse(Console.ReadLine());
                double savedMoney = 0;
                while (savedMoney < sum)
                {
                    nextSum = double.Parse(Console.ReadLine());
                    savedMoney += nextSum;
                }
                Console.WriteLine($"Going to {destination}!");
            }
        }
    }
}
