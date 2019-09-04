using Neshto;
using System;
using System.Linq;

namespace ListyIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            ListyIterator<string> listyIterator = null;

            while (true)
            {
                string line = Console.ReadLine();

                if (line== "END")
                {
                    break;
                }

                string[] tokens = line.Split();
                string command = tokens[0];
                if (command == "Create")
                {
                    listyIterator = new ListyIterator<string>(tokens.Skip(1).ToList()); 
                }
                else if (command=="Move")
                {
                    Console.WriteLine(listyIterator.Move());
                }
                else if (command =="HasNext")
                {
                    Console.WriteLine(listyIterator.HasNext());
                }
                else if (command == "Print")
                {
                    Console.WriteLine(listyIterator.Print());
                }
                else if (command== "PrintAll")
                {
                      Console.WriteLine(string.Join(" ",listyIterator));

                    //foreach (var item in listyIterator)
                    //{
                    //    Console.Write(item + " ");
                    //}
                }
            }
        }
    }
}
