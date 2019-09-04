using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string,List<double>> students = new Dictionary<string,List< double>>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(name))
                {
                    students.Add(name, new List<double>());

                }
                students[name].Add(grade);
            }

            Dictionary<string, List<double>> filtered = new Dictionary<string, List<double>>();

            filtered = students.Where(x => x.Value.Average() >= 4.5)
                .OrderByDescending(x => x.Value.Average())
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in filtered)
            {
                List<double> grades = item.Value;
                Console.WriteLine($"{item.Key} -> {grades.Average():f2}");
            }
        }
    }
}
