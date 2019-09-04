using System;
using System.Linq;
namespace _1.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            
              string [] array  = new string[] { "Monday" , "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int days = int.Parse(Console.ReadLine());

            if (days >= 1 && days <= 7)
            {
                Console.WriteLine(array[days - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
