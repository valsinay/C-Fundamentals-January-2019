using _03.WildFarm.Animals.Birds;
using _03.WildFarm.Animals.Mammals;
using _03.WildFarm.Animals.Mammals.Feline;

namespace _03.WildFarm.Animals
{
    public static class AnimalFactory
    {
        public static Animal Create(params string[] animalArgs)
        {
            string type = animalArgs[0];
            string name = animalArgs[1];
            double weight = double.Parse(animalArgs[2]);

            if (type == "Owl")
            {
                double wingSize = double.Parse(animalArgs[3]);

                return new Owl(name, weight, wingSize);
            }
            else if (type == "Hen")
            {
                double wingSize = double.Parse(animalArgs[3]);

                return new Hen(name, weight, wingSize);
            }
            else if (type == "Mouse")
            {
                string livingRegion = animalArgs[3];

                return new Mouse(name, weight, livingRegion);
            }
            else if (type == "Dog")
            {
                string livingRegion = animalArgs[3];

                return new Dog(name, weight, livingRegion);
            }
            else if (type == "Cat")
            {
                string livingRegion = animalArgs[3];
                string breed = animalArgs[4];

                return new Cat(name, weight, livingRegion, breed);
            }
            else if (type == "Tiger")
            {
                string livingRegion = animalArgs[3];
                string breed = animalArgs[4];

                return new Tiger(name, weight, livingRegion, breed);
            }
            return null;
        }
    }
}
