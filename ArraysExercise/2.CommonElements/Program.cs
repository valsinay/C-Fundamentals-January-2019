using System;
using System.Linq;
using System.Collections;
namespace _2.CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine()
                .Split()
                .ToArray();

            string[] secondArray = Console.ReadLine()
                .Split().ToArray();

            foreach (var item in secondArray)
            {
                if (firstArray.Contains(item))
                {
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
