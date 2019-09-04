using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }
                string[] tokens = line.Split();

                string command = tokens[0];

                if (command == "exchange")
                {
                    int index = int.Parse(tokens[1]);
                    if (index > input.Length - 1 || index <0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    Exchange(input, index);
                    
                }
                else if (command == "max")
                {
                    string typeNumber = tokens[1];
                    int index = -1;
                    if (typeNumber == "odd")
                    {
                        index = GetMaxEvenOrOdd(input, 1);
                    }
                    else
                    {
                        index = GetMaxEvenOrOdd(input, 0);
                    }
                    if (index == -1)
                    {
                        Console.WriteLine("No matches");
                        continue;
                    }

                    Console.WriteLine(index);
                }
                else if (command == "min")
                {
                    string typeNumber = tokens[1];
                    int index = -1;
                    if (typeNumber == "odd")
                    {
                        index = GetMinEvenOrOdd(input, 1);
                    }
                    else
                    {
                        index = GetMinEvenOrOdd(input, 0);
                    }
                    if (index == -1)
                    {
                        Console.WriteLine("No matches");
                        continue;
                    }
                    Console.WriteLine(index);
                }
                else if (command == "first")
                {
                    int count = int.Parse(tokens[1]);
                    if (count > input.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    string typeNumber = tokens[2];

                    int[] result = new int[0];

                    if (typeNumber == "odd")
                    {
                        result = GetFirstCountEvenOrOdd(input, count, 1);
                    }
                    else
                    {
                        result = GetFirstCountEvenOrOdd(input, count, 0);

                    }

                    Console.WriteLine("[" + string.Join(", ", result) +"]");

                }
                else if (command == "last")
                {
                    int count = int.Parse(tokens[1]);
                    if (count > input.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    string typeNumber = tokens[2];

                    int[] result = new int[0];

                    if (typeNumber == "odd")
                    {
                        result = GetLastCountEvenOrOdd(input, count, 1);
                    }
                    else
                    {
                        result = GetLastCountEvenOrOdd(input, count, 0);

                    }

                    Console.WriteLine("[" + string.Join(", ", result) + "]");
                }
            }
            Console.WriteLine($"[{string.Join(", ",input)}]");
           
        }

        private static int[] GetLastCountEvenOrOdd(int[] input, int count, int divisionResult)
        {
            int[] arrayResult = new int[count];
            int counting = 0;

            for (int i =input.Length-1; i>=0; i--)
            {
                if (input[i] % 2 == divisionResult && counting < count)
                {
                    arrayResult[counting] = input[i];
                    counting++;
                }
            }
            if (counting >= count)
            {
                return arrayResult.Reverse().ToArray();
            }
            else
            {
                int[] temp = new int[counting];
                Array.Copy(arrayResult, temp, counting);
                return temp.Reverse().ToArray();
            }
        }

        private static int[] GetFirstCountEvenOrOdd(int[] input, int count, int divisionResult)
        {
            int[] arrayResult = new int[count];
            int counting = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 ==divisionResult && counting<count)
                {
                    arrayResult[counting] = input[i];
                    counting++;
                }
            }
            if (counting>=count)
            {
                return arrayResult;
            }
            else
            {
                int[] temp = new int[counting];
                Array.Copy(arrayResult, temp, counting);
                return temp;
            }
        }

        private static int GetMinEvenOrOdd(int[] input, int divisionResult)
        {
            int minValue = int.MaxValue;
            int index = -1;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] <= minValue && input[i] % 2 == divisionResult)
                {
                    minValue = input[i];
                    index = i;
                }
            }
            return index;
        }

        private static int GetMaxEvenOrOdd(int[] input, int divisionResult)
        {
            int maxValue = int.MinValue;
            int index = -1;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]>=maxValue && input[i] % 2 ==divisionResult)
                {
                    maxValue = input[i];
                    index = i;
                }
            }
            return index;
        }

        private static void Exchange(int[] input, int index)
        {
            for (int i = 0; i < index+1; i++)
            {
                int temp = input[0];

                for (int j = 0; j < input.Length - 1; j++)
                {
                    input[j] = input[j + 1];
                }
                input[input.Length - 1] = temp;
            }
        }
    }
}
