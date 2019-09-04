using System;

namespace _03.WildFarm.Animals.Birds
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        public override void Eat(Food food)
        {
            string typeFood = food.GetType().Name;
            if (typeFood == "Meat")
            {
                this.Weight += food.Quantity * 0.25;
                this.FoodEaten += food.Quantity;
                return;
            }
            throw new ArgumentException($"{this.GetType().Name} does not eat {typeFood}!");
        }

        public override string ProduceSound()
        {
            return "Hoot Hoot";
        }
    }
}
