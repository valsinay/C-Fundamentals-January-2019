using _06.Animals.Animals;
using System;

namespace _06.Animals
{
    public class AnimalFactory
    {
        public Animal GetAnimal(string animalType, string name, int age, string gender)
        {
            switch (animalType)
            {
                case "Dog":
                    return new Dog(name, age, gender); ;
                case "Cat":
                    return new Cat(name, age, gender);
                case "Frog":
                    return new Frog(name, age, gender);
                case "Kitten":
                    return new Kitten(name, age,"Female");
                case "Tomcat":
                    return new Tomcat(name, age,"Male");
                default:
                    throw new ArgumentException("Invalid input!");
            }
        }
    }
}
