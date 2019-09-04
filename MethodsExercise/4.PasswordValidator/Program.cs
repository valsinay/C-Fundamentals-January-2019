using System;
using System.Linq;

namespace _4.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            bool isBetween6And10 = CheckLenght(input);

            if (!isBetween6And10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            bool onlyDigitsAndLetters = OnlyDigitsAndLetters(input);

            if (!onlyDigitsAndLetters)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            bool atLeast2Digits = AtLeast2Digits(input);
            if (!atLeast2Digits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isBetween6And10 && onlyDigitsAndLetters && atLeast2Digits )
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool AtLeast2Digits(string input)
        {
            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char digits = input[i];

                if (char.IsDigit(digits))
                {
                    count++;
                }
            }
            return count >= 2 ? true : false;
        }

        private static bool OnlyDigitsAndLetters(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                char letter = input[i];

                if (!char.IsLetterOrDigit(letter))
                {
                    return false;
                }
                
            }
            return true;
        }

        private static bool CheckLenght(string input)
        {
            return input.Length >= 6 && input.Length <= 10 ? true : false;
        }
    }
}
