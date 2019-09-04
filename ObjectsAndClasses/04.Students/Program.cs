using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Students> final = new List<Students>();

            for (int i = 0; i < n; i++)
            {
                string[] students = Console.ReadLine()
                    .Split();

                string firstName = students[0];
                string lastName = students[1];
                float grade = float.Parse(students[2]);

                Students student = new Students(firstName, lastName, grade);

                final.Add(student);
            }

            Console.WriteLine(string.Join(Environment.NewLine, final.OrderByDescending(x => x.Grade)));
        }
    }
    class Students
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public float Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }

        public Students(string firstName,string lastName, float grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

    }
}
