using System;

namespace _3.CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());

            Characters(first, second);
        }
        public static void Characters(char start, char end)
        {
            if (start<end)
            {
                start++;

                for (char i = start; i < end; i++)
                {
                    Console.Write(i+ " ");

                }
            }
            else
            {
                end++;

                for (int i = end; i < start; i++)
                {
                    Console.Write((char)i+" ");
                }
            }
            
            Console.WriteLine();
        }
    }
}
