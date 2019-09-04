using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = int.Parse(Console.ReadLine());

            int[] dividers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Distinct()
                .ToArray();

            var divisibleNumbers = new List<int>();

            

            for (int num = 1; num <= limit; num++)
            {
                var isDivisible = true;

                foreach (var divider in dividers)
                {
                    Predicate<int> isNotDivider = x => num % x != 0;
                    if (isNotDivider(divider))
                    {
                        isDivisible = false;
                        break;
                    }
                }
                if (isDivisible)
                {
                    divisibleNumbers.Add(num);
                }
            }
            Console.WriteLine(string.Join(" ",divisibleNumbers));

        }
    }
}
