using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _03.BakingFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var resultBatch = new List<int>();

            double totalSum = -1001;

            double totalAverage = -1001;
       

            int lenght = -1;

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Bake It!")
                {
                    break;
                }
                var elements = line
                 .Split(new[] { "#" }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                    .ToList();

                for (int i = 0; i < elements.Count; i++)
                {
                    double currentSum = elements.Sum();
                    double currentAverage = elements.Average();
                    int currentLength = elements.Count;

                    if (currentSum > totalSum)
                    {
                        totalSum = currentSum;
                        totalAverage = currentAverage;
                        lenght = currentLength;
                        resultBatch = elements;
                    }
                    else if (currentSum == totalSum)
                    {
                        if (currentAverage > totalAverage)
                        {
                            totalSum = currentSum;
                            totalAverage = currentAverage;
                            lenght = currentLength;
                            resultBatch = elements;
                        }
                        else if (currentAverage == totalAverage)
                        {

                            if (currentLength < lenght)
                            {
                                totalSum = currentSum;
                                totalAverage = currentAverage;
                                lenght = currentLength;
                                resultBatch = elements;
                            }

                        }
                    }
                }

            }
            Console.WriteLine($"Best Batch quality: {totalSum}");
            Console.WriteLine(string.Join(" ", resultBatch));
        }
    }
}


