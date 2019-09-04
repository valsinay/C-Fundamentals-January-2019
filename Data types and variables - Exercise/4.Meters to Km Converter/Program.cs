using System;

namespace _4.Meters_to_Km_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double meters = double.Parse(Console.ReadLine());
            double kmToMeter = meters / 1000;
            double km = kmToMeter;

            Console.WriteLine($"{km:f2}");


        }
    }
}
