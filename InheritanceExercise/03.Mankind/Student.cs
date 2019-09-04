using System;
using System.Linq;
using System.Text;

namespace _03.Mankind
{
    public class Student : Human
    {
        private string facultyNumber;

        public Student(string facultyNumber,string firstName, string lastName)
            : base(firstName,lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get => this.facultyNumber;

            set
            {
                if (!value.All(x=>char.IsLetterOrDigit(x))  || value.Length < 5 || value.Length >10)
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine(base.ToString());
            builder.AppendLine($"Faculty number: {this.FacultyNumber}");

            return builder.ToString().TrimEnd();
        }
    }
}
