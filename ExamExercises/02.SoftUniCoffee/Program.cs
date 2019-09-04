using System;

namespace _02.SoftUniCoffee
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            decimal totalPrice = 0.0m;
            decimal singlePrice = 0.0m;

            for (int i = 0; i < input; i++)
            {
                decimal price = decimal.Parse(Console.ReadLine());
                string[] date = Console.ReadLine().Split('/');
                int quantity = int.Parse(Console.ReadLine());

                int days = DateTime.DaysInMonth(int.Parse(date[2]), int.Parse(date[1]));

                singlePrice = days * price * quantity;
                totalPrice += singlePrice;

                Console.WriteLine($"The price for the coffee is: ${singlePrice:f2}");
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}