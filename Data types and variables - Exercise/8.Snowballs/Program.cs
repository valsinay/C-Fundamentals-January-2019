using System;
using System.Collections;
using System.Numerics;
namespace _8.Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int snowBalls = int.Parse(Console.ReadLine());

            int snowBallSnow = 0;
            int snowBallTime = 0;
            int snowBallQuality = 0;
            BigInteger snowBallValue = 0;
            
            
            for (int i = 0; i < snowBalls; i++)
            {
                 int currentSnowBallSnow = int.Parse(Console.ReadLine());
               int currentSnowBallTime = int.Parse(Console.ReadLine());
              int currentSnowBallQuality = int.Parse(Console.ReadLine());
                
                BigInteger currentSnowValue =BigInteger.Pow((currentSnowBallSnow/currentSnowBallTime),currentSnowBallQuality);

                if (currentSnowValue>snowBallValue )
                {
                    snowBallValue = currentSnowValue;
                    
                    snowBallSnow = currentSnowBallSnow;
                    snowBallTime = currentSnowBallTime;
                    snowBallQuality = currentSnowBallQuality;
                }
                
            }
            Console.WriteLine($"{snowBallSnow} : {snowBallTime} = {snowBallValue} ({snowBallQuality})");
        }
    }
}
