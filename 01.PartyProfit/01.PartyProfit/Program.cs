using System;
using System.Collections.Generic;

namespace _01.PartyProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> kasichka = new List<int>();

            int party = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());


            int sum = 0;

            for (int i = 1; i <= days; i++)
            {

                sum += 50;

                if (i % 10 == 0)
                {
                    party -= 2;
                }
                if (i % 15 == 0)
                {
                    party += 5;
                }

                if (i % 3 == 0)
                {
                    sum -= 3 * party;
                }
                if (i % 5 == 0)
                {
                    sum += 20 * party;

                }
                if (i % 5 == 0 && i % 3 == 0)
                {
                    sum -= 2 * party;
                }

                sum -= 2 * party;
            }

            double finish = Math.Floor((double)sum / party);
            Console.WriteLine($"{party} companions received {finish} coins each.");
        }
    }
}
