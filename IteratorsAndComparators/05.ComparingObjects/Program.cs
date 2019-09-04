using System;
using System.Collections.Generic;

namespace _05.ComparingObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                string[] tokens = input.Split();

                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                string town = tokens[2];


                Person person = new Person(name, age, town);
                people.Add(person);
            }

            int personIndex = int.Parse(Console.ReadLine());
            Person current = people[personIndex - 1];

            int equal = 0;
            int notEqual = 0;

            for (int i = 0; i < people.Count; i++)
            {
                if (people[i].CompareTo(current) == 0)
                {
                    equal++;
                }
                else
                {
                    notEqual++;
                }
            }

            if (equal>1)
            {
                Console.WriteLine($"{equal} {notEqual} {people.Count}");
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
    }
}
