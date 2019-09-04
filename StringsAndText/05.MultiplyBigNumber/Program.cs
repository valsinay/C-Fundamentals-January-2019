using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace _05.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger string1 = BigInteger.Parse(Console.ReadLine().TrimStart('0'));
            int string2 = int.Parse(Console.ReadLine());


            if (string1 ==0 || string2 == 0)
            {
                Console.WriteLine(0);
                return;
            }

            BigInteger result = string1 * string2;
            Console.WriteLine(result);


            //if (string1 == "0" || string2 == 0)
            //{
            //    Console.WriteLine(0);
            //    return;
            //}
            //var foo = decimal.Parse(string1);
            //var bar = decimal.Parse(string2.ToString());
            //var foobar = foo * bar;

            //var product = foobar.ToString();

            //Console.WriteLine(product);
        }
    }
}
