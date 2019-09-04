using System;

namespace _03.WildFarm.Animals.Mammals
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        public override void Eat(Food food)
        {
            string typeFood = food.GetType().Name;
            if (typeFood == "Meat")
            {
                this.Weight += food.Quantity * 0.4;
                this.FoodEaten += food.Quantity;
                return;
            }
            throw new ArgumentException($"{this.GetType().Name} does not eat {typeFood}!");
        }

        public override string ProduceSound()
        {
            return "Woof!";
        }
    }
}
