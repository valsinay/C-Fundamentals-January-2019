using System;

namespace _5.PoundToDollar
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal input = decimal.Parse(Console.ReadLine());

            decimal onePoundToDollar = (decimal)1.31 * input;
            
            Console.WriteLine($"{onePoundToDollar:f3}");


        }
    }
}
