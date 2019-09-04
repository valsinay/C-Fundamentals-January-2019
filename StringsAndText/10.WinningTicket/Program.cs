using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
            .Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            int count = 0;
            char symbol = ' ';

            for (int i = 0; i < input.Length; i++)
            {
                string ticket = input[i];

                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                string leftSide = ticket.Substring(0, 10);
                string rightSide = ticket.Substring(10);

                for (int j = 6; j <=10; j++)
                {
                    if (leftSide.Contains(new string('@', j)) && rightSide.Contains(new string('@', j)))
                    {
                        count = j;
                        symbol = '@';
                    }
                    else if (leftSide.Contains(new string('$', j)) && rightSide.Contains(new string('$', j)))
                    {
                        count = j;
                        symbol = '$';
                    }
                    else if (leftSide.Contains(new string('^', j)) && rightSide.Contains(new string('^', j)))
                    {
                        count = j;
                        symbol = '^';
                    }
                    else if (leftSide.Contains(new string('#', j)) && rightSide.Contains(new string('#', j)))
                    {
                        count = j;
                        symbol = '#';
                    }
                }
                if (count<6)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }
                
                else if (count == 10)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - {count}{symbol} Jackpot!");
                }
                else 
                {
                    Console.Write($"ticket \"{ticket}\" - {count}{symbol}");
                }
            }
        }
    }
}
