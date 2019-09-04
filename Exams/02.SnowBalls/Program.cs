using System;
using System.Numerics;

namespace _02.SnowBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger value = 0;
            BigInteger best = 0;
            int bestSnow = 0;
            int bestTime = 0;
            int bestQuality = 0;

            for (int i = 0; i < n; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());

                value = BigInteger.Pow(snow / time, quality);

                if (value>best)
                {
                    best = value;
                    bestSnow = snow;
                    bestTime = time;
                    bestQuality = quality;
                }
            }
            Console.WriteLine($"{bestSnow} : {bestTime} = {best} ({bestQuality})");
        }
    }
}
