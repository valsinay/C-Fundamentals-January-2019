using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _06.AutoRepair
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Queue<string> cars = new Queue<string>(input);
            Stack<string> servedCars = new Stack<string>();


            while (cars.Any())
            {
                string[] line = Console.ReadLine().Split("-");

                if (line[0] == "End")
                {
                    break;
                }
                else if (line[0] == "Service")
                {
                    if (cars.Any())
                    {
                    servedCars.Push(cars.Peek());
                    Console.WriteLine($"Vehicle {cars.Dequeue()} got served.");
                        
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (line[0] == "CarInfo")
                {
                    string carInfo = line[1];
                    if (servedCars.Contains(carInfo))
                    {
                        Console.WriteLine("Served.");
                    }
                    else
                    {
                        Console.WriteLine("Still waiting for service.");
                    }

                }
                else if (line[0] == "History")
                {

                    Console.WriteLine(string.Join(", ", servedCars));
                }
            }
            if (cars.Any())
            {
                Console.Write($"Vehicles for service: ");
                Console.Write(string.Join(", ", cars));
                Console.WriteLine();

            }
            Console.Write("Served vehicles: ");
            Console.Write(string.Join(", ", servedCars));
            Console.WriteLine();
        }
    }
}
