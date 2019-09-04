using System;
using System.Text;

namespace _03.Mankind
{
    public class Human
    {
        private const int MinLengthFirstName = 4;
        private const int MinLengthLastName = 3;

        private string firstName;
        private string lastName;
      
        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get => this.firstName;

            set
            {
                CheckFirstLetterIsUpper(value, nameof(this.firstName));

                CheckLength(value, MinLengthFirstName, nameof(this.firstName));

                this.firstName = value;
            }
        }

        public string LastName
        {
            get => this.lastName;

            set
            {
               
                CheckFirstLetterIsUpper(value, nameof(this.lastName));

                CheckLength(value, MinLengthLastName, nameof(this.lastName));

                this.lastName = value;
            }
        }

        private void CheckFirstLetterIsUpper(string value, string parameter)
        {
            if (!char.IsUpper(value[0]))
            {
                throw new ArgumentException($"Expected upper case letter! Argument: {parameter}");
            }
        }

        private void CheckLength(string value, int minLength, string parameter)
        {
            if (value.Length < minLength )
            {
                throw new ArgumentException($"Expected length at least {minLength} symbols! Argument: {parameter}");
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine($"First Name: {this.FirstName}");
            builder.AppendLine($"Last Name: {this.LastName}");

            return builder.ToString().TrimEnd();
        }
    }
}
