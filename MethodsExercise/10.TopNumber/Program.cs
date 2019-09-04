using System;

namespace _10.TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 8; i < input; i++)
            {
                int num = i;

                bool isDivisible = CheckIfDivisibleBy8(i);
                bool hasAtLeastOneOddNum = HasAtLeastOneOddNum(i);

                if (isDivisible && hasAtLeastOneOddNum)
                {
                    Console.WriteLine(i);
                }
            }
        }
        private static bool HasAtLeastOneOddNum(int number)
        {
            while (number != 0)
            {
                int digit = number % 10;
                number /= 10;

                if (digit % 2 == 1)
                {
                    return true;
                }
            }
            return false;
        }

        private static bool CheckIfDivisibleBy8(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                int digit = number % 10;
                number /= 10;

                sum += digit;
            }
            if (sum % 8 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
