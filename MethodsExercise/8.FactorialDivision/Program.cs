using System;

namespace _8.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            long result1 = FirstFactorial(num1);
            long result2 = SecondFactorial(num2);

            Console.WriteLine($"{(double)result1/result2:f2}");

        }
        
        private static long FirstFactorial(long num1)
        {
            long factorial = 1;

            for (int i = 1; i <= num1; i++)
            {
                 factorial *= i;
            }
            return factorial;
        }
        private static long SecondFactorial(long num2)
        {
            long factorial = 1;

            for (int i = 1; i <= num2; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
