namespace _05.BorderControl
{
    using System;

    public class Pet : IBirthable
    {
        public Pet(string name, DateTime birthdate)
        {
            this.Name = name;
            this.BirthDate = birthdate;
        }
        public string Name { get; private set; }

        public DateTime BirthDate { get; private set; }

    }
}
