using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line=="end")
                {
                    break;
                }


                string[] tokens = line.Split(" : ");
                string courseName = tokens[0];

                string userName = tokens[1];
               

                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName,new List<string>());
                   
                }
                courses[courseName].Add(userName);


            }
            
            foreach (var item in courses.OrderByDescending(x=>x.Value.Count))
            {
                List<string> people = item.Value;
                Console.WriteLine($"{item.Key}: {item.Value.Count}");

                foreach (var kvp in people.OrderBy(x=>x))
                {
                    Console.WriteLine($"-- {kvp}");
                }
                
            }
           
        }
    }
}
