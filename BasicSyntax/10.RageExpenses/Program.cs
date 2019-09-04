using System;

namespace _10.RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());

            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keybordPrice  = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double headsetTrash = lostGames / 2;
            double mouseTrash = lostGames / 3;
            double keybordTrash = lostGames / 6;
            double displayTrash = lostGames / 12;

            double expenses = headsetTrash * headsetPrice + mouseTrash * mousePrice + keybordPrice * keybordTrash + displayTrash * displayPrice;

            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}
