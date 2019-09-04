using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace AnonymousSHit
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());

            List<string> input = new List<string>();

            List<string> sites = new List<string>();

            decimal totalLoss = 0.0m;

            BigInteger securityToken = BigInteger.Pow(securityKey, n);

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine()
                    .Split()
                    .ToList();
                string siteName = input[0];
                double siteVisits = double.Parse(input[1]);
                decimal sitePrice = decimal.Parse(input[2]);

                decimal siteLoss = (decimal)siteVisits * sitePrice;
                totalLoss += siteLoss;

                sites.Add(siteName);
            }
            foreach (var item in sites)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total Loss: {totalLoss:f20}");
            Console.WriteLine($"Security Token: {securityToken}");
        }
    }
}
