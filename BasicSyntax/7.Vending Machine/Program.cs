using System;

namespace _7.Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal coinSum = 0m;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Start")
                {
                    break;
                }

                decimal insertedCoins = decimal.Parse(command);

                if (insertedCoins == 0.1m || insertedCoins == 0.2m || insertedCoins == 0.5m ||insertedCoins == 1m || insertedCoins == 2m)
                {
                    coinSum += insertedCoins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {insertedCoins}");
                }

            }
            while (true)
            {
                string products = Console.ReadLine().ToLower();

                if (products == "end")
                {
                    break;
                }
                if (products == "nuts")
                {
                    if (coinSum < 2)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        Console.WriteLine($"Purchased {products}");
                        coinSum -= 2;
                    }
                }
                else if (products == "water")
                {
                    if (coinSum < 0.7m)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        Console.WriteLine($"Purchased {products}");
                        coinSum -= 0.7m;
                    }
                }
               else if (products == "crisps")
                {
                    if (coinSum < 1.5m)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        Console.WriteLine($"Purchased {products}");
                        coinSum -= 1.5m;
                    }
                }
                else if (products == "soda")
                {
                    if (coinSum < 0.8m)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        Console.WriteLine($"Purchased {products}");
                        coinSum -= 0.8m;
                    }

                }
                else if (products == "coke")
                {
                    if (coinSum < 1)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    else
                    {
                        Console.WriteLine($"Purchased {products}");
                        coinSum -= 1;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
            }
            Console.WriteLine($"Change: {coinSum:f2}");
        }
    }
}
