using System;

namespace _5.AddAndSubstract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int substract = Sum(num1, num2);

            Console.WriteLine(Substract(substract,num3));

        }
        private static int Sum(int num1, int num2)
        {
            int sum = 0;
            return sum = num1 + num2;
        }
        private static int Substract(int sum1, int sum2)
        {
            return sum1 -= sum2;
        }
    }
}
