using _05.MordorsCruelPlan.Foods;

namespace _05.MordorsCruelPlan
{
    public class FoodFactory
    {
        public Food GetFood(string food)
        {
            switch (food.ToLower())
            {
                case "apple":
                    return new Apple();
                case "honeycake":
                    return new HoneyCake();
                case "cram":
                    return new Cram();
                case "lembas":
                    return new Lembas();
                case "melon":
                    return new Melon();
                case "mushrooms":
                    return new Mushrooms();
                default:
                    return null;
            }

        }


    }
}
