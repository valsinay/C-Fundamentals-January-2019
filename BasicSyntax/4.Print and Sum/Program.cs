using System;

namespace _4.Print_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secNum = int.Parse(Console.ReadLine());
            int totalSum = 0;
            for (int i = firstNum; i <= secNum; i++)
            {

                Console.Write(i + " ");
                
                totalSum += i;
                
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {totalSum}");

        }
    }
}
