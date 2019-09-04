using System;

namespace _1.Baking
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());

            decimal flourPrice = decimal.Parse(Console.ReadLine());
            decimal eggPrice = decimal.Parse(Console.ReadLine());
            decimal apronPrice = decimal.Parse(Console.ReadLine());

            int freeFlour = students / 5;
            decimal moreApron = Math.Ceiling(students * 0.2m);

            decimal totalFlour = students * flourPrice - (freeFlour * flourPrice);
            decimal totalEgg = students * eggPrice * 10;
            decimal totalApron = students * apronPrice + apronPrice*moreApron;

            decimal total = totalApron + totalEgg + totalFlour;


            if (total<=budget)
            {
                Console.WriteLine($"Items purchased for {total:f2}$.");
            }
            else
            {
                Console.WriteLine($"{(total-budget):f2}$ more needed.");
            }
        }
    }
}
