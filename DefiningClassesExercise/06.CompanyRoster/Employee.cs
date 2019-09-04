using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _06.CompanyRoster
{
    public class Employee
    {
        [Required]
        private string name;
        [Required]
        private decimal salary;
        [Required]
        private string position;
        [Required]
        private string department;
        private string email = "n/a";
        private int age = -1;


        public Employee(string name, decimal salary, string position, string department)
        {
            this.Name = name;
            this.Salary = salary;
            this.Position = position;
            this.Department = department;
        }
        public Employee(string name, decimal salary, string position, string department, string email)
            : this(name, salary, position, department)
        {
            Email = email;
        }
        public Employee(string name, decimal salary, string position, string department, int age)
           : this(name, salary, position, department)
        {
            this.age = age;
        }
        public Employee(string name, decimal salary, string position, string department, string email, int age)
          : this(name, salary, position, department)
        {
            Email = email;
            Age = age;
        }
        public override string ToString()
        {
            return $"{name} {salary} {position} {department}";
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public decimal Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }
        public string Position
        {
            get { return this.position; }
            set { this.position = value; }
        }
        public string Department
        {
            get { return this.department; }
            set { this.department = value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age=value;}
        }

    }
}
