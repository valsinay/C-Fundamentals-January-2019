using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> users = new Dictionary<string, List<string>>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }
                string[] tokens = line.Split(" -> ");
                string company = tokens[0];
                string employeeId = tokens[1];

                if (!users.ContainsKey(company))
                {
                    users.Add(company, new List<string>());
                }
               
                users[company].Add(employeeId);
               
                

            }
            foreach (var item in users.OrderBy(x => x.Key))
            {
                List<string> id = item.Value;
                Console.WriteLine(item.Key);
                foreach (var kvp in id)
                {
                   
                    Console.WriteLine($"-- {kvp}");
                }

            }
        }
    }
}
