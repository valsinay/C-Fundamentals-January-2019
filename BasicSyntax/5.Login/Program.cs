using System;
using System.Linq;

namespace _5.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pass = string.Empty;

            for (int i = input.Length-1; i >= 0; i--)
            {
                pass += input[i];
            }

            int counter = 0;

            while (true)
            {
                string vhod = Console.ReadLine();
                if (vhod == pass)
                {
                    Console.WriteLine($"User {input} logged in.");
                    break;
                }
                else if (counter == 3)
                {
                    Console.WriteLine($"User {input} blocked!");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                counter++;
            }
        }
    }
}
