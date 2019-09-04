using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());

            var numbersAndLetters = Console.ReadLine().Split().Reverse();

            Queue<string> elements = new Queue<string>();

            Queue<int> guests = new Queue<int>();

            foreach (var element in numbersAndLetters)
            {
                if (char.IsLetter(element[0]))
                {
                    elements.Enqueue(element);
                }
                else
                {
                    int guest = int.Parse(element);

                    while (elements.Count>0)
                    {
                        if (guests.Sum() + guest <= capacity)
                        {
                            guests.Enqueue(guest);
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"{elements.Dequeue()} -> {string.Join(", ",guests)}");
                        }
                        guests.Clear();
                    }
                }

            }
            

        }
    }
}
