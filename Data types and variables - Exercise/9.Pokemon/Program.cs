using System;

namespace _9.Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
           int pokePowerN = int.Parse(Console.ReadLine());
            int distanceM = int.Parse(Console.ReadLine());
            int exhaustionFactorY = int.Parse(Console.ReadLine());

            int poked = 0;
            int originalPower = pokePowerN;

            while (pokePowerN >= distanceM)
            {
                if (originalPower * 0.5 == pokePowerN && exhaustionFactorY >0) 
                {
                    pokePowerN/= exhaustionFactorY;
                    continue;
                }

                pokePowerN -= distanceM;
                poked++;
                
            }
            Console.WriteLine(pokePowerN);
            Console.WriteLine(poked);
        }
    }
}
