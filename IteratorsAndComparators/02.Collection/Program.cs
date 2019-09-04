using _02.Collection;
using System;
using System.Linq;

namespace _03.Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomStack<int> stack = new CustomStack<int>();
           
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "END")
                {
                    break;
                }

                string[] tokens = line.Split(" ",2);
                string command = tokens[0];
                if (command == "Push")
                {
                    int[] numbers = tokens[1].Split(", ").Select(int.Parse).ToArray();
                    stack.Push(numbers);

                }
                else
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (Exception msg)
                    {

                        Console.WriteLine(msg.Message);
                    }
                }
            }
            for (int i = 0; i < 2; i++)
            {
                foreach (var item in stack)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
