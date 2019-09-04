using System;
using System.Collections.Generic;
using System.Text;

namespace _09.SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<string> stack = new Stack<string>();

            string text = "";

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split();

                int index = int.Parse(line[0]);
                if (index == 1)
                {
                    string charsToAdd = line[1];
                    text += charsToAdd;
                    stack.Push(text);
                }
                else if (index==2)
                {
                    int countToErase = int.Parse(line[1]);
                    text = text.Substring(0, text.Length - countToErase);
                    stack.Push(text);
                   
                }
                else if (index == 3)
                {
                    int indexToReturn = int.Parse(line[1]);
                    Console.WriteLine(text[indexToReturn-1]);
                    
                }
                else if (index==4)
                {
                    if (stack.Count>0)
                    {
                    stack.Pop();
                    text = stack.Peek();

                    }
                    else
                    {
                        text = string.Empty;
                    }
                }
            }
        }
    }
}
