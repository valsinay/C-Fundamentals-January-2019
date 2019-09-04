using System;

namespace _03.WildFarm.Animals.Mammals.Feline
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
        }

        public override void Eat(Food food)
        {
            string typeFood = food.GetType().Name;

            if (typeFood == "Meat" || typeFood == "Vegetable")
            {
                this.Weight += food.Quantity * 0.3;
                this.FoodEaten += food.Quantity;
                return;
            }
            throw new ArgumentException($"{this.GetType().Name} does not eat {typeFood}!");
        }

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
