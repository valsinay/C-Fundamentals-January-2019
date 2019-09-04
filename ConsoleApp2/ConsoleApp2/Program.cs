using System;

using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>(input);

            while (true)
            {
                string line = Console.ReadLine().ToLower();

                if (line=="end")
                {
                    break;
                }
                string[] tokens = line.Split();
                string command = tokens[0].ToLower();

                if (command=="add")
                {
                    int firstNum = int.Parse(tokens[1]);
                    int secondNum = int.Parse(tokens[2]);
                    stack.Push(firstNum);       
                    stack.Push(secondNum);
                        
                }
                else if(command=="remove")
                {
                    int removedCount = int.Parse(tokens[1]);
                    if (stack.Count<removedCount)
                    {
                        continue;
                    }

                    for (int i = 0; i < stack.Count; i++)
                    {
                        stack.Pop();
                    }
                }
            }
            var sum = stack.Sum();
                
               Console.WriteLine(sum);
        }
    }
}
