using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SnowMen
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> sequence = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();

            List<int> elementsToRemove = new List<int>();
            bool finish = false;

            while (true)
            {

                if (sequence.Count <2 || finish)
                {
                    break;
                }
                for (int i = 0; i < sequence.Count; i++)
                {
                    int attacker = sequence.IndexOf(sequence[i]);
                    int target = sequence.ElementAt(attacker);
                       
                  
                    if (target > sequence.Count-1)
                    {
                        target = target % sequence.Count;
                    }
                    if (!elementsToRemove.Contains(sequence.ElementAt(attacker)))
                    {


                        if (attacker==target)
                        {
                            //harakiri
                            Console.WriteLine($"{attacker} performed harakiri");
                            elementsToRemove.Add(sequence.ElementAt(attacker ));

                        }
                        else if (Math.Abs(target - attacker) % 2 == 0)
                        {
                            Console.WriteLine($"{attacker} x {target} -> {attacker} wins");
                            
                            elementsToRemove.Add(sequence.ElementAt(target));
                        }
                        else if (Math.Abs(target - attacker) % 2 != 0)
                        {
                            Console.WriteLine($"{attacker} x {target} -> {target} wins");
                            elementsToRemove.Add(sequence.ElementAt(attacker));
                        }
                    }
                    if (Math.Abs(sequence.Count - elementsToRemove.Count) == 1)
                    {
                        finish = true;
                        break;
                    }
                }
                foreach (var item in elementsToRemove)
                {
                    sequence.Remove(item);
                }
                elementsToRemove.Clear();
            }
        }
    }
}
