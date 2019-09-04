using System;

namespace _9.Padawan_equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());

            int students = int.Parse(Console.ReadLine());
            decimal priceLightsaber = decimal.Parse(Console.ReadLine());
            decimal priceRobes = decimal.Parse(Console.ReadLine());
            decimal priceBelts = decimal.Parse(Console.ReadLine());

            int freeBelts = students / 6;
            decimal moreLightsabers = Math.Ceiling(students + students * 0.1m);

            decimal totalBelts = priceBelts * students - (freeBelts * priceBelts);
            decimal equipmentCosts = priceLightsaber*moreLightsabers+ priceRobes * students + totalBelts;

            if (money >= equipmentCosts)
            {
                Console.WriteLine($"The money is enough - it would cost {equipmentCosts:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {(equipmentCosts-money):f2}lv more.");
            }
        }
    }
}
