using System;

namespace _01.SoftuniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployee = int.Parse(Console.ReadLine());
            int secondEmployee = int.Parse(Console.ReadLine());
            int thirdEmployee = int.Parse(Console.ReadLine());

            int numberStudents = int.Parse(Console.ReadLine());

            int count = 0;

            int numberStudentsPerHour = firstEmployee + secondEmployee + thirdEmployee;
            int answeredStudents = 0;

            while (numberStudents>0)
            {
                numberStudents = numberStudents - numberStudentsPerHour;
                count++;

                if (count % 4==0)
                {
                    count++;
                }
            }

            Console.WriteLine($"Time needed: {count}h.");
        }
    }
}
