using System;
using System.Linq;
using System.Text;

namespace _08.LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new[] { " ", "\t" }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            
            int rank = 0;

            decimal totalSum = 0.0m;

            foreach (var word in input)
            {
                char firstLetter = word[0];
                double number = double.Parse((word.Substring(1, word.Length - 2)));

                if (char.IsUpper(firstLetter))
                {
                    rank = char.ToUpper(firstLetter) - 64;
                    number /= rank;
                }
                else
                {
                    rank = char.ToUpper(firstLetter) - 64;
                    number *= rank;
                }

                var lastLetter = word[word.Length - 1];
                if (char.IsUpper(lastLetter))
                {
                    rank = char.ToUpper(lastLetter) - 64;
                    number -= rank;
                }
                else
                {
                    rank = char.ToUpper(lastLetter) - 64;
                    number += rank;
                }

               totalSum += (decimal)number;
            }
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
