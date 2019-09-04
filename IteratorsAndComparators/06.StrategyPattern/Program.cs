
using System;
using System.Collections.Generic;

namespace _06.StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<Person> setByName = new SortedSet<Person>(new PersonNameLengthComparer());
            SortedSet<Person> setByAge = new SortedSet<Person>(new PersonAgeComparer());


            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                var input = Console.ReadLine().Split();

                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age);

                setByName.Add(person);
                setByAge.Add(person);
            }

            foreach (var person in setByName)
            {
                Console.WriteLine(person);
            }

            foreach (var person in setByAge)
            {
                Console.WriteLine(person);
            }
        }
    }
}
