namespace _06.Animals
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static void Main(string[] args)
        {
            AnimalFactory factory = new AnimalFactory();
            List<Animal> animals = new List<Animal>();
            while (true)
            {
                try
                {
                    string line = Console.ReadLine();
                    if (line == "Beast!")
                    {
                        break;
                    }

                    string typeAnimal = line;
                    string[] characteristics = Console.ReadLine().Split();

                    string name = characteristics[0];
                    int age = int.Parse(characteristics[1]);
                    string gender = characteristics[2];

                    Animal animal = factory.GetAnimal(typeAnimal, name, age, gender);
                    animals.Add(animal);

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
