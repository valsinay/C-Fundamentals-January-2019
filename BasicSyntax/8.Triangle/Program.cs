﻿using System;

namespace _8.Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                for (int j =1; j <= i; j++)
                {
                    Console.Write(i+ " ");
                }
                Console.WriteLine("");
               
            }
        }
    }
}
