using System;
using System.Text.RegularExpressions;

namespace _07.ChoreWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeDishes = 0;
            int timeCleaning = 0;
            int timeLaundry = 0;
            int totalMinutes = 0;
            
            string dishesPattern = @"(?<=<)[a-z0-9]+(?=>)";
            string cleaningPattern = @"(?<=\[)[A-Z0-9]+(?=\])";
            string laundryPattern = @"(?<={).+(?=})";
            string numPattern = @"\d";

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "wife is happy")
                {
                    break;
                }

                Match dishesMatch = Regex.Match(line, dishesPattern);
                Match cleaningMatch = Regex.Match(line, cleaningPattern);
                Match laundryMatch = Regex.Match(line, laundryPattern);

                if (dishesMatch.Success)
                {
                    string dishesString = dishesMatch.ToString();
                    
                    MatchCollection nums = Regex.Matches(dishesString, numPattern);

                    foreach (var item in nums)
                    {
                        int num = int.Parse(item.ToString());
                        timeDishes += num;
                    }
                }
                else if (cleaningMatch.Success)
                {
                        string cleaningString = cleaningMatch.ToString();
                    
                        MatchCollection nums = Regex.Matches(cleaningString, numPattern);

                        foreach (var item in nums)
                        {
                            int num = int.Parse(item.ToString());
                            timeCleaning += num;
                        }
                }
                else if (laundryMatch.Success)
                {
                    string laundryString = laundryMatch.ToString();
                   
                    MatchCollection nums = Regex.Matches(laundryString, numPattern);

                    foreach (var item in nums)
                    {
                        int num = int.Parse(item.ToString());
                        timeLaundry += num;
                    }
                }
                totalMinutes = timeCleaning + timeDishes + timeLaundry;
            }
            Console.WriteLine($"Doing the dishes - {timeDishes} min.");
            Console.WriteLine($"Cleaning the house - {timeCleaning} min.");
            Console.WriteLine($"Doing the laundry - {timeLaundry} min.");
            Console.WriteLine($"Total - {totalMinutes} min.");
        }
    }
}
