    using System;
using System.Collections.Generic;

namespace _08.RawData
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
                int engineSpeed = int.Parse(line[1]);
                int enginePower = int.Parse(line[2]);
                int cargoWeight = int.Parse(line[3]);
                string cargoType = line[4];
                double tyre1Pressure = double.Parse(line[5]);
                int tyre1Age = int.Parse(line[6]);
                double tyre2Pressure = double.Parse(line[7]);
                int tyre2Age = int.Parse(line[8]);
                double tyre3Pressure = double.Parse(line[9]);
                int tyre3Age = int.Parse(line[10]);
                double tyre4Pressure = double.Parse(line[11]);
                int tyre4Age = int.Parse(line[12]);
                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);
                Tires tires = new Tires(tyre1Pressure, tyre2Pressure, tyre3Pressure, tyre4Pressure, tyre1Age
                    , tyre2Age, tyre3Age, tyre4Age);

                Car car = new Car(model, engine, cargo, tires);
                carList.Add(car);
            }
            string command = Console.ReadLine();

            foreach (var car in carList)
            {
                if (command== "fragile")
                {
                    if (car.Cargo.CargoType == "fragile" && car.Tires.TyrePressureUnder1())
                    {
                        Console.WriteLine(car.Model);
                    }
                }
                else
                {
                    if (car.Cargo.CargoType == "flamable" && car.Engine.EnginePowerOver250())
                    {
                        Console.WriteLine(car.Model);
                    }       
                }
            }
        }
    }
}
