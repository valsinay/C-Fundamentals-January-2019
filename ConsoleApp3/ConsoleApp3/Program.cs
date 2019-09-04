using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int wonGames = 0;
            int lostGames = 0;
            int drawnGames = 0;

            for (int i = 0; i < 3; i++)
            {
                string[] firstGame = Console.ReadLine().Split(":");

                int team = int.Parse(firstGame[0]);
                int otherTeam = int.Parse(firstGame[1]);

                if (team > otherTeam)
                {
                    wonGames++;
                }
                else if (team < otherTeam)
                {
                    lostGames++;
                }
                else
                {
                    drawnGames++;
                }
            }

            Console.WriteLine($"Team won {wonGames} games.");
            Console.WriteLine($"Team lost {lostGames} games.");
            Console.WriteLine($"Drawn games: {drawnGames}");
            
        }
    }
}
