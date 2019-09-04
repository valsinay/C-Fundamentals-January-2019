namespace _05.BorderControl
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            List<IBirthable> invaders = new List<IBirthable>();

            while (true)
            {
                var line = Console.ReadLine().Split();

                if (line[0] == "End")
                {
                    break;
                }

                if (line[0] == "Citizen")
                {
                    string name = line[1];
                    int age = int.Parse(line[2]);
                    string id = line[3];

                    DateTime birthdate = DateTime.ParseExact(line[4], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                    Citizen citizen = new Citizen(name, age, id, birthdate);
                    invaders.Add(citizen);

                }
                else if (line[0] == "Pet")
                {
                    string name = line[1];
                    DateTime birthdate = DateTime.ParseExact(line[2], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                    Pet pet = new Pet(name, birthdate);
                    invaders.Add(pet);
                }
                else
                {
                    string robotModel = line[1];
                    string id = line[2];

                    Robot robot = new Robot(robotModel, id);

                }
            }

            int birthDateToDetain = int.Parse(Console.ReadLine());

            var filterInvadersId = invaders.Where(x => x.BirthDate.Year == birthDateToDetain)
                .ToList();

            
            foreach (var invader in filterInvadersId)
            {
                DateTime birthday = invader.BirthDate;


                Console.WriteLine($"{birthday.Day:d2}/{birthday.Month:d2}/{birthday.Year:d2}");
            }
        }
    }
}
