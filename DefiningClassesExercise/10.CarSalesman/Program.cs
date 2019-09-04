namespace _10.CarSalesman
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            int engineCount = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();
            for (int i = 0; i < engineCount; i++)
            {
                var line = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();
                string model = line[0];
                int power = int.Parse(line[1]);

                Engine engine = null;


                if (line.Count == 2)
                {
                    engine = new Engine(model, power);
                }
                else if (line.Count == 4)
                {
                    double displacement = double.Parse(line[2]);
                    string efficiency = line[3];
                    engine = new Engine(model, power, displacement, efficiency);
                }
                else
                {
                    bool isDisplacement = double.TryParse(line[2], out double displacement);

                    if (isDisplacement)
                    {
                        engine = new Engine(model, power, displacement);
                    }
                    else
                    {
                        string efficiency = line[2];
                        engine = new Engine(model, power, efficiency);
                    }
                }

                engines.Add(engine);
            }
            int modelsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < modelsCount; i++)
            {
                var line = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                string model = line[0];
                string engineModel = line[1];

                Engine engine = engines.Where(x => x.Model == engineModel).FirstOrDefault();

                Car car = null;

                if (line.Length == 4)
                {
                    double weight = double.Parse(line[2]);
                    string color = line[3];
                    car = new Car(model, engine, weight, color);
                }
                else if (line.Length == 2)
                {
                    car = new Car(model, engine);
                }
                else
                {
                    bool isWeight = int.TryParse(line[2], out int weight);
                    if (isWeight)
                    {
                        car = new Car(model, engine, weight);
                    }
                    else
                    {
                        string color = line[2];
                        car = new Car(model, engine, color);
                    }
                }
                cars.Add(car);
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                if (car.Engine.Displacement == -1)
                {
                    Console.WriteLine($"    Displacement: n/a");
                }
                else
                {
                    Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
                }
                Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
                if (car.Weight == -1)
                {
                    Console.WriteLine($"  Weight: n/a");
                }
                else
                {
                    Console.WriteLine($"  Weight: {car.Weight}");
                }
                Console.WriteLine($"  Color: {car.Color}");
            }
        }
    }
}
