using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> colors = new List<string>();

            string[] input = Console.ReadLine().Split();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var type = typeof(Signals);

                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] == Signals.Red.ToString())
                    {
                        input[j] = Signals.Green.ToString();
                    }
                    else if (input[j] == Signals.Green.ToString())
                    {
                        input[j] = Signals.Yellow.ToString();
                    }
                    else
                    {
                        input[j] = Signals.Red.ToString();
                    }
                    colors.Add(input[j]);
                }


                Console.WriteLine(string.Join(" ",colors));
                colors.Clear();
            }
        }
    }
}
