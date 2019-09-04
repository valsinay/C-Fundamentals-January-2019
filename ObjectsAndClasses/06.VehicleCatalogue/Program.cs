using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehichleList = new List<Vehicle>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }
                

                string[] commands = input.Split();

                string type = commands[0][0].ToString().ToUpper() + commands[0].Substring(1);
                string model = commands[1];
                string color = commands[2];
                int horsePower = int.Parse(commands[3]);

                var vehicle = new Vehicle(type, model, color, horsePower);
                vehichleList.Add(vehicle);
            }
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Close the Catalogue")
                {
                    break;
                }
               

                var filteredModels = vehichleList.Where(x => x.Model == input).First();
               

                Console.WriteLine($"Type: {filteredModels.Type}");
                Console.WriteLine($"Model: {filteredModels.Model}");
                Console.WriteLine($"Color: {filteredModels.Color}");
                Console.WriteLine($"Horsepower: {filteredModels.Horsepower}");
                
            }
            if (vehichleList.Where(x=>x.Type == "Car").Count() >0)
            {
                Console.WriteLine($"Cars have average horsepower of: {vehichleList.Where(x => x.Type == "Car").Select(x => x.Horsepower).Average():F2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: 0.00.");
            }
            if (vehichleList.Where(x => x.Type == "Truck").Count() > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {vehichleList.Where(x => x.Type == "Truck").Select(x => x.Horsepower).Average():F2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: 0.00.");
            }
        }
    }
    class Vehicle
    {
        public Vehicle(string type, string model, string color, int horsepower)
        {
            Type = type;
            Model = model;
            Color = color;
            Horsepower = horsepower;
        }

        public string Type { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int Horsepower { get; set; }
    }
}
