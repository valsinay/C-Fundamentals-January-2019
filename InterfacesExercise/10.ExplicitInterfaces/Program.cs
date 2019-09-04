using _10.ExplicitInterfaces.Contracts;
using System;

namespace _10.ExplicitInterfaces
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                string[] input = line.Split();
                string name = input[0];
                string country = input[1];
                int age = int.Parse(input[2]);

                IPerson citizen = new Citizen(name, age, country);
                IResident resident = new Citizen(name, age, country);

                Console.WriteLine(citizen.GetName());
                Console.WriteLine(resident.GetName());

            }
        }
    }
}
