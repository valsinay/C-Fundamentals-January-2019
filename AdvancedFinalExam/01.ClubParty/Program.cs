using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ClubParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            int freeCapacity = capacity;
            var lettersAndDigits = Console.ReadLine().Split(new string[] { " " },StringSplitOptions.RemoveEmptyEntries).Reverse();

            //60
            // 1 20 b 20 20 a -> reversed == a 20 20 b 20 1
            Queue<string> hall = new Queue<string>();

            Queue<int> guests = new Queue<int>();
            foreach (var element in lettersAndDigits)
            {
                if (char.IsLetter(element[0]))
                {
                    hall.Enqueue(element);
                }

                else
                {
                    int guest = int.Parse(element);

                    while (hall.Count>0)
                    {

                        if (freeCapacity >= guest)
                        {
                            freeCapacity -= guest;
                            guests.Enqueue(guest);
                            break;
                        }
                        else
                        {
                            string hallToPrint = hall.Dequeue();
                            Console.WriteLine($"{hallToPrint} -> {string.Join(", ", guests)}");
                        }
                        guests.Clear();
                        freeCapacity = capacity;
                    }
                }
            }


        }
    }
}
