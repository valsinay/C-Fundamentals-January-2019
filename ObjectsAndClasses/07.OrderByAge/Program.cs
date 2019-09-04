using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Person> users = new List<Person>();
            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                string[] tokens = line.Split();

                string name = tokens[0];
                string identification = tokens[1];
                int age = int.Parse(tokens[2]);

                var user = new Person(name, identification, age);
                users.Add(user);


                // Console.WriteLine(string.Join(Environment.NewLine, $"{users.Where(x => x.Name)} with ID: {users.Where(x => x.Identificatio)} is {users.Where(x => x.Age).order);


            }
            foreach (var person in users.OrderBy(x => x.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.Identification} is {person.Age} years old.");
            }
        }
        class Person
        {
            public string Name { get; set; }
            public string Identification { get; set; }
            public int Age { get; set; }

            public Person(string name, string identification, int age)
            {
                Name = name;
                Identification = identification;
                Age = age;
            }
        }
    }
}
