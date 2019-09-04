using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int newMin = minutes + 30;

            
            if (newMin >59)
            {
                hours++;
                newMin -= 60;
            }
            if (hours>23)
            {
                hours -= 24;

            }

            Console.WriteLine($"{hours:D2}:{newMin:D2}");

        }
    }
}
