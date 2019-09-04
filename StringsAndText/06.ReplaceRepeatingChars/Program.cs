using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
           
            List<char> chars = input.ToList();
            List<char> final = new List<char>();



            for (int i = 0; i <chars.Count; i++)
            {
                char symbol = chars[i];

                if (i == chars.Count-1)
                {
                    final.Add(chars[i]);
                    break;
                }
                if (chars[i] != chars[i+1])
                {
                    final.Add(chars[i]);
                }
            }
            Console.WriteLine(string.Join("",final));
        }
    }
}
