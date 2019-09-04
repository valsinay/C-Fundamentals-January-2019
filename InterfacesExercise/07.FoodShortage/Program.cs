namespace _07.FoodShortage
{
    using _05.BorderControl;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            List<IBuyer> buyers = new List<IBuyer>();

            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split();

                if (line.Length == 4)
                {
                    string name = line[0];
                    int age = int.Parse(line[1]);
                    string id = line[2];

                    DateTime birthdate = DateTime.ParseExact(line[3], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                    Citizen citizen = new Citizen(name, age, id, birthdate);
                    buyers.Add(citizen);
                }
                else
                {
                    string name = line[0];
                    int age = int.Parse(line[1]);
                    string group = line[2];

                    Rebel rebel = new Rebel(name, age, group);
                    buyers.Add(rebel);
                }
            }

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                string name = line;

                var filterBuyers = buyers.Where(x => x.Name == name)
                .ToList();

                foreach (var buyer in filterBuyers)
                {
                    buyer.BuyFood();
                }

            }
            
            int total = 0;

            foreach (var buyer in buyers)
            {
                total += buyer.Food;
            }

            Console.WriteLine(total);
        }
    }

}
