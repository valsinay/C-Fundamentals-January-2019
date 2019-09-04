using System;

namespace _6.MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Character(input);
        }
        public static void Character(string input)
        {
            if (input.Length % 2==0)
            {
                Console.WriteLine(input.Substring((input.Length / 2) - 1, 2));
            }
            else
            {
                Console.WriteLine(input.Substring((input.Length/2),1));
            }

            
            
        }
    }
}
