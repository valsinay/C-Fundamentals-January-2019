using System;

namespace _05.BorderControl
{
    public class Citizen : IBirthable
    {

        public Citizen(string name, int age, string id, DateTime birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.BirthDate = birthdate;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Id { get; private set; }

        public DateTime BirthDate { get; private set; }


    }
}
