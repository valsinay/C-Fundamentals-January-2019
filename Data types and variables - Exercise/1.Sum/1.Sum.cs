using System;

namespace Data_types_and_variables___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int current = input;
            int sum = 0;
            while (input>0)
            
            {
                 sum+= input % 10;
                input /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
