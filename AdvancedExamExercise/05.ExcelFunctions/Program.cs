using System;
using System.Linq;
using System.Text;

namespace _05.ExcelFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            string[][] table = new string[rows][];

            for (int row = 0; row < rows; row++)
            {
                string[] rowValues = Console.ReadLine()
                    .Split(", ");

                table[row] = rowValues;

            }
            string[] matrixCommands = table[0];

            string[] commands = Console.ReadLine().Split();

            if (commands[0] == "sort")
            {
                string header = commands[1];
                int index = Array.IndexOf(matrixCommands, header);

                Console.WriteLine(string.Join(" | ", matrixCommands));
                table = table.Skip(1).ToArray();
                table = table.OrderBy(x => x[index]).ToArray();
                PrintMatrix(table);
            }

            else if (commands[0] == "hide")
            {
                string header = commands[1];
                int index = Array.IndexOf(matrixCommands, header);

                table.Where((x, i) => Array.IndexOf(x, i) != index);

                for (int row = 0; row < table.Length; row++)
                {
                    Console.WriteLine(string.Join(" | ",table[row]
                        .Where((x,i)=>i!= index).ToArray()));
                }
                //for (int row = 0; row < matrixCommands.Length; row++)
                //{
                //    if (row != index)
                //    {
                //        if (row == matrixCommands.Length - 1)
                //        {
                //            Console.WriteLine(matrixCommands[row]);
                //            break;
                //        }
                //        Console.Write(matrixCommands[row] + " | ");
                //    }
                //}

                //table = table.Skip(1).ToArray();

                //for (int row = 0; row < table.Length; row++)
                //{
                //    Console.WriteLine(string.Join(" | ", table[row]
                //        .Where((x,i)=>i != index )).ToArray());
                //}
            }
            else if (commands[0] == "filter")
            {
                string header = commands[1];
                string value = commands[2];

                int index = Array.IndexOf(matrixCommands, header);

                Console.WriteLine(string.Join(" | ", matrixCommands));
                table = table.Skip(1).ToArray();

                for (int row = 0; row < table.Length; row++)
                {
                    if (table[row][index] == value)
                    {
                        Console.WriteLine(string.Join(" | " ,table[row]));
                    }
                }
            }
        }

        private static void PrintMatrix(string[][] table)
        {
            for (int row = 0; row < table.Length; row++)
            {
                Console.WriteLine(string.Join(" | ", table[row]));
            }
        }
    }
}
