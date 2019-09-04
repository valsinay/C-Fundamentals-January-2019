using System;
using System.Collections.Generic;

namespace _07.SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> carList = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split();
                string model = line[0];
                double fuelAmount = double.Parse(line[1]);
                double fuelConsumption = double.Parse(line[2]);
                double distance = 0;

                Car car = new Car(model, fuelAmount, fuelConsumption, distance);
                carList.Add(car);
            }


            while (true)
            {
                string line = Console.ReadLine();
                if (line=="End")
                {
                    break;
                }
                string[] tokens = line.Split();
                string command = tokens[0];

                
                if (command=="Drive")
                {
                    int index =0;

                    string carModel = tokens[1];
                    double distance = double.Parse(tokens[2]);
                    

                    for (int i = 0; i < carList.Count; i++)
                    {
                        
                        if (carList[i].Model == carModel)
                        {
                            index = i;
                            break;
                        }
                    }

                    if (carList[index].Travelling(distance))
                    {
                        carList[index].FuelAmount -= carList[index].FuelConsumption * distance;
                        carList[index].Distance += distance;
                    }
                    else
                    {
                        Console.WriteLine("Insufficient fuel for the drive");
                    }

                }
                
            }

            foreach (var car in carList)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.Distance}");
            }
        }
    }
}
