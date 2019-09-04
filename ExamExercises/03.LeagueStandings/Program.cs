using System;
using System.Collections.Generic;
using System.Linq;
namespace _03.LeagueStandings
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();


            List<string> input = Console.ReadLine()
                .Split(new string[] { key }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            
            Console.WriteLine(string.Join("",input));
            
          
        }
    }
}
