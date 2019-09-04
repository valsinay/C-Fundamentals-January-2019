using System;
using System.Collections.Generic;

namespace _04.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> productQuantity = new Dictionary<string, int>();
            Dictionary<string, decimal> productPrice = new Dictionary<string, decimal>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "buy")
                {
                    break;
                }

                string[] tokens = line.Split();

                string product = tokens[0];
                decimal price = decimal.Parse(tokens[1]);
                int quantity = int.Parse(tokens[2]);

                if (!productQuantity.ContainsKey(product))
                {
                    productQuantity.Add(product, 0);
                    productPrice.Add(product, 0);
                }
                productQuantity[product] += quantity;
                productPrice[product] = price;
            }
            foreach (var item in productQuantity)
            {
                string product = item.Key;
                int quantity = item.Value;
                decimal price = productPrice[product];

                decimal result = quantity * price;

                Console.WriteLine($"{product} -> {result:f2}");
            }
        }
    }
}
