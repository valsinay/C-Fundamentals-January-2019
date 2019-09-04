using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace _09.RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();

            StringBuilder sb = new StringBuilder();
            List<string> symbols = new List<string>();
            List<string> result = new List<string>();

            var number = -2;

            for (int i = 0; i < input.Length; i++)
            {
                var currentItem = input[i];
                
                if (!char.IsDigit(currentItem) && input[i+1] != 0)
                {
                    sb.Append(currentItem.ToString());
                    symbols.Add(currentItem.ToString());
                }
                else
                {
                    if (i == input.Length - 1)
                    {
                        number = int.Parse(currentItem.ToString());
                    }
                    else
                    {
                        if (!char.IsNumber(input[i + 1]))
                        {
                            number = int.Parse(currentItem.ToString());
                        }
                        else
                        {
                            number = int.Parse(input[i] + input[i + 1].ToString());
                            i++;
                        }
                    }
                    if (number!=0)
                    {

                    }
                    for (int j = 0; j < number; j++)
                    {
                        result.Add(sb.ToString());
                    }
                    sb.Clear();
                 
                }
            }
            Console.WriteLine($"Unique symbols used: {symbols.Distinct().Count()}");
            Console.WriteLine(string.Join("",result));
        }
    }
}
