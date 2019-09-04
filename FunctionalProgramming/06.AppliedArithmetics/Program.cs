using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {

            Func<List<int>, List<int>> addFunc = x => x.Select(a => a += 1).ToList();
            Func<List<int>, List<int>> subtractFunc = x => x.Select(a => a -= 1).ToList();
            Func<List<int>, List<int>> multiplyFunc = x => x.Select(a => a*= 2).ToList();



            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }

                if (command == "add")
                {
                   input= addFunc(input);
                }
                else if (command=="subtract")
                {
                    input = subtractFunc(input);
                }
                else if (command == "multiply")
                {
                    input = multiplyFunc(input);

                }
                else if (command == "print")
                {
                    Console.WriteLine(string.Join(" ",input));
                }

            }
        }
    }
}
