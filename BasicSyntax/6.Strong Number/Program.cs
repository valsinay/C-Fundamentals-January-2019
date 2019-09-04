using System;
using System.Linq;

namespace _6.Strong_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = int.Parse(Console.ReadLine());
            long temp = n;
            
            long r;
            int sum = 0;
            while (n!=0)
            {
                r = n % 10;
                n = n / 10;

                int factorial = 1;
                for (int i =2; i<=r; i++)
                {
                    factorial *= i;
                }
                sum =sum+ factorial;
                
            }
           
            if (sum==temp)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
