using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int waves = int.Parse(Console.ReadLine());

            int[] plates = Console.ReadLine().
            Split()
            .Select(int.Parse)
            .ToArray();

            Queue<int> platesQueue = new Queue<int>(plates);

            int additionalPlate = -1;
            Stack<int> warriorStack = new Stack<int>();
            Stack<int> warriorsLeft = new Stack<int>();

            for (int i = 1; i <= waves; i++)
            {
                var warriors = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                if (i % 3 == 0)
                {
                    additionalPlate = int.Parse(Console.ReadLine());
                    platesQueue.Enqueue(additionalPlate);
                }

                if (platesQueue.Count == 0)
                {
                    break;
                }
                bool isDead = false;
               
                int plateToKill = platesQueue.Peek();
             
                foreach (var warrior in warriors.Reverse())
                {
                   
                    warriorStack.Push(warrior);
                    int attackWarrior = warriorStack.Peek();

                    while (!isDead)
                    {
                        if (attackWarrior < plateToKill)
                        {
                            isDead = true;
                            warriorStack.Pop();
                            plateToKill -= attackWarrior;
                        }
                        else if (attackWarrior == plateToKill)
                        {
                            isDead = true;
                            warriorStack.Pop();
                            platesQueue.Dequeue();
                        }
                        else if (attackWarrior > plateToKill)
                        {
                            attackWarrior -= plateToKill;
                            warriorStack.Pop();
                            warriorStack.Push(attackWarrior);
                            platesQueue.Dequeue();

                        }
                        if (platesQueue.Count == 0)
                        {
                            break;
                        }

                    }
                    isDead = false;
                }

            }

            if (platesQueue.Count == 0)
            {
                Console.WriteLine("The Trojans successfully destroyed the Spartan defense.");
                Console.WriteLine($"Warriors left: {string.Join(", ", warriorStack)}");
            }
            else
            {
                Console.WriteLine("The Spartans successfully repulsed the Trojan attack.");
                Console.WriteLine($"Plates left: {string.Join(", ", platesQueue)}");

            }
        }
    }
}
