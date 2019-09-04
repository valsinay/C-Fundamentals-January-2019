using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Person> olderThan30 = new List<Person>();

            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split();
                string name = line[0];
                int age = int.Parse(line[1]);

                Person person = new Person(name, age);
                family.AddMember(person);

                
            }
            List<Person> peopleOverThirty = family.OlderThan30().OrderBy(x => x.Name).ToList();

            Console.WriteLine(string.Join(Environment.NewLine,peopleOverThirty));
        }
    }
}
