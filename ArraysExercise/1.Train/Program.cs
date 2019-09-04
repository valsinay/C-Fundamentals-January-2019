using System;
using System.Linq;

namespace _1.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
             int[] array = new int[n];
            
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                sum += array[i];
            }
            for (int i = 0; i <= n-1; i++)
            {
                Console.Write(array[i] + " ");
               
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
