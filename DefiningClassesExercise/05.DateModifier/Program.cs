using System;

namespace _05.DateModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startDate = DateTime.Parse(Console.ReadLine());
            DateTime endDate = DateTime.Parse(Console.ReadLine());

            TimeSpan t = startDate - endDate;
            double days = t.TotalDays;
            Console.WriteLine( Math.Abs(days));
        }
    }
}
