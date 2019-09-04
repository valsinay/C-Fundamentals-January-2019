using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var list = new List<int>();
            int number = int.MinValue;

            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());


                if (!dict.ContainsKey(currentNumber))
                {
                    dict.Add(currentNumber, 0);
                }
                dict[currentNumber]++;


            }
            foreach (var item in dict)
            {
                if (item.Value % 2 ==0)
                {
                    Console.WriteLine(item.Key);
                }
            }


        }
    }
}
