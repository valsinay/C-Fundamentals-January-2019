using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int desiredHeight = int.Parse(Console.ReadLine());

            int firstHeight = desiredHeight - 30;

            int tries = 0;
            int totalJumps = 0;

            while (true)
            {
                int jump = int.Parse(Console.ReadLine());

                if (jump > desiredHeight)
                {
                    totalJumps++;
                    Console.WriteLine($"Tihomir succeeded, he jumped over {desiredHeight}cm after {totalJumps} jumps.");
                    return;

                }
                else if (jump > firstHeight)
                {
                    if (firstHeight == desiredHeight)
                    {
                        Console.WriteLine($"Tihomir succeeded, he jumped over {desiredHeight}cm after {totalJumps} jumps.");
                        return;
                    }
                    totalJumps++;
                    tries = 0;
                    firstHeight += 5;

                }

                else
                {
                    tries++;
                    totalJumps++;

                    if (tries == 3)
                    {
                        Console.WriteLine($"Tihomir failed at {firstHeight}cm after {totalJumps} jumps.");
                        return;
                    }
                }

            }

        }
    }
}
