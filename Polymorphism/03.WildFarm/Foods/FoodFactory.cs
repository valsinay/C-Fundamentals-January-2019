using System;
using System.Collections.Generic;
using System.Text;

namespace _03.WildFarm.Foods
{
    public static class FoodFactory
    {
        public static Food Create(string[] foodArgs)
        {
            string type = foodArgs[0];
            int quantity = int.Parse(foodArgs[1]);

            if (type == "Vegetable")
            {
               return new Vegetable(quantity);
            }
            else if (type == "Fruit")
            {
                return new Fruit(quantity);
            }
            else if (type == "Meat")
            {
                return new Meat(quantity);
            }
            else if (type == "Seeds")
            {
                return new Seeds(quantity);
            }
            return null;
        }
    }
}
