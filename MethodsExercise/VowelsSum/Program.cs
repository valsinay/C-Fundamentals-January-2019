using System;

namespace VowelsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Count(input);
        }
        public static void Count(string inputString)
        {
           
            int counter = 0;
            for (int i = 0; i < inputString.Length; i++)
            {
                char letter = inputString[i];
                
                if (letter == 'a' || letter== 'e' || letter == 'i' || letter == 'o' 
                    || letter == 'u' || letter == 'A' || letter == 'E' 
                    || letter == 'I' || letter == 'O' || letter == 'U')
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);

        }
    }
}
