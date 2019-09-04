using System;

namespace _1.SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            Sum(num1, num2, num3);
        }
        static public void Sum(int num1, int num2, int num3)
        {
            int firstMin = Math.Min(num1, num2);
            int min = Math.Min(firstMin, num3);

            Console.WriteLine(min);
        }
    }
}
