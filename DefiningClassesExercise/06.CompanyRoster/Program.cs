using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.CompanyRoster
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Employee> listEmployee = new List<Employee>();
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine()
                    .Split()
                    .ToList();

                string name = line[0];
                decimal salary = decimal.Parse(line[1]);
                string position = line[2];
                string department = line[3];

                if (line.Count == 6)
                {
                    string email = line[4];
                    int age = int.Parse(line[5]);
                   
                    Employee employeeAge = new Employee(name, salary, position, department, email, age);
                    listEmployee.Add(employeeAge);
                }
                else if (line.Count == 5)
                {
                    int age;
                    bool isAge = int.TryParse(line[4], out age);
                    if (isAge)
                    {
                        age = int.Parse(line[4]);
                        Employee employeeAge = new Employee(name, salary, position, department, age);
                        listEmployee.Add(employeeAge);
                    }
                    else
                    {
                        string email = line[4];
                        Employee employeeEmail = new Employee(name, salary, position, department, email);
                        listEmployee.Add(employeeEmail);
                    }
                }
                else
                {
                    Employee employee = new Employee(name, salary, position, department);
                    listEmployee.Add(employee);
                }
            }
            var bestPaid = listEmployee
             .GroupBy(x => x.Department)
             .OrderByDescending(x => x.Select(e => e.Salary).Sum())
             .FirstOrDefault();

            Console.WriteLine($"Highest Average Salary: {bestPaid.Key}");
            foreach (var employee in bestPaid.OrderByDescending(x=>x.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2} {employee.Email} {employee.Age}");
            }
        }
    }
}
