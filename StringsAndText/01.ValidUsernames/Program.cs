using System;
using System.Collections.Generic;

namespace _01.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(", ");

            List<string> legitWords = new List<string>();

          

            for (int i = 0; i < input.Length; i++)
            {

                bool isBetween3and16 = IsBetween3and16(input[i]);
                bool containsChars = ContainsChars(input[i]);

                if (isBetween3and16 && containsChars)
                {
                    legitWords.Add(input[i]);
                }
            }

            foreach (var item in legitWords)
            {
                Console.WriteLine(item);
            }
            
        }

        private static bool ContainsChars(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                char symbol = input[i];

                if (!char.IsLetterOrDigit(symbol) && !symbol.Equals('-') && !symbol.Equals('_'))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool IsBetween3and16(string input)
        {
           
                if (input.Length >=3 && input.Length <=16)
                {
                    return true;
                }
            
            return false;
        }
    }
}
