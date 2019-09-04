using System;

namespace _03.WildFarm.Animals.Mammals.Feline
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
        }

        public override void Eat(Food food)
        {
            string typeFood = food.GetType().Name;
            if (typeFood == "Meat")
            {
                this.Weight += food.Quantity * 1;
                this.FoodEaten += food.Quantity;
                return;
            }
            throw new ArgumentException($"{this.GetType().Name} does not eat {typeFood}!");
        }
        public override string ProduceSound()
        {
            return "ROAR!!!";
        }
    }
}
