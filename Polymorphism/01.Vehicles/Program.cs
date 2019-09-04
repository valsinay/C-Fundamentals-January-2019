using System;

namespace _01.Vehicles
{
    public class Program
    {
        static void Main(string[] args)
        {

            string[] carInput = Console.ReadLine().Split();
            double carFuelQuantity = double.Parse(carInput[1]);
            double carFuelConsumption = double.Parse(carInput[2]);
            int tankCapacity = int.Parse(carInput[3]);

            string[] truckInput = Console.ReadLine().Split();
            double truckFuelQuantity = double.Parse(truckInput[1]);
            double truckFuelConsumption = double.Parse(truckInput[2]);
            int truckTankCapacity = int.Parse(truckInput[3]);

            string[] busInput = Console.ReadLine().Split();
            double busFuelQuantity = double.Parse(busInput[1]);
            double busFuelConsumption = double.Parse(busInput[2]);
            int busTankCapacity = int.Parse(busInput[3]);


            Car car = new Car(carFuelQuantity, carFuelConsumption, tankCapacity);
            Truck truck = new Truck(truckFuelQuantity, truckFuelConsumption, truckTankCapacity);
            Bus bus = new Bus(busFuelQuantity, busFuelConsumption, busTankCapacity);

            int n = int.Parse(Console.ReadLine());

            Execution(car, truck, bus, n);

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);

        }

        private static void Execution(Car car, Truck truck, Bus bus, int n)
        {
            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split();
                string command = commands[0];
                string typeVehicle = commands[1];

                if (command =="Drive")
                {
                    double distance = double.Parse(commands[2]);

                    if (typeVehicle == "Car")
                    {
                        Console.WriteLine(car.Drive(distance));
                    }
                    else if (typeVehicle == "Truck")
                    {
                        Console.WriteLine(truck.Drive(distance));
                    }
                    else
                    {
                        Console.WriteLine(bus.Drive(distance));
                    }
                }
                else if (command == "Refuel")
                {
                    try
                    {
                        double refuelQuantity = double.Parse(commands[2]);

                        if (typeVehicle == "Car")
                        {
                            car.Refuel(refuelQuantity);
                        }
                        else if (typeVehicle == "Truck")
                        {
                            truck.Refuel(refuelQuantity);
                        }
                        else
                        {
                            bus.Refuel(refuelQuantity);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                   
                }
                else
                {
                    double distance = double.Parse(commands[2]);
                    Console.WriteLine(bus.DriveEmpty(distance));
                }
                
            }
        }
    }
}
