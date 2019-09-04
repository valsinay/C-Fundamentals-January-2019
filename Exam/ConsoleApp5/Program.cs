using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp5
{
    public class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            string[][] matrix = new string[size][];

            string[] commands = Console.ReadLine().Split();

            int playerRow = 0;
            int playerCol = 0;
            int coalsCount = 0;

            for (int row = 0; row < matrix.Length; row++)
            {
                var chars = Console.ReadLine()
                  .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                matrix[row] = chars;

                for (int col = 0; col < matrix.Length; col++)
                {
                    if (matrix[row][col] == "s")
                    {
                        playerRow = row;
                        playerCol = col;
                    }


                }

            }

            for (int i = 0; i < commands.Length; i++)
            {
                string command = commands[i];

                int staticPlayerRow = playerRow;
                int staticPlayerCol = playerCol;


                if (command == "up")
                {
                    playerRow--;
                }
                else if (command == "down")
                {
                    playerRow++;
                }
                else if (command == "left")
                {
                    playerCol--;
                }
                else if (command == "right")
                {
                    playerCol++;
                }

                if (ValidateMethod(playerRow, playerCol, matrix))
                {
                    if (matrix[playerRow][playerCol] == "c")
                    {
                        coalsCount++;

                    }
                    else if (matrix[playerRow][playerCol] == "e")
                    {
                        Console.WriteLine($"Game over! ({playerRow}, {playerCol})");
                        return;
                    }
                    matrix[playerRow][playerCol] = "*";
                }
                else
                {
                    playerRow = staticPlayerRow;
                    playerCol = staticPlayerCol;

                }


            }

            int count = 0;

            for (int row = 0; row < matrix.Length; row++)
            {

                if (matrix[row].Contains("c"))
                {
                    count++;
                }
            }

            if (count >0)
            {
                Console.WriteLine($"{count} coals left. ({playerRow}, {playerCol})");
            }
            else
            {
                Console.WriteLine($"You collected all coals! ({playerRow}, {playerCol})");
            }
        }
        private static bool ValidateMethod(int playerRow, int playerCol, string[][] matrix)
        {
            if (playerRow >= 0 && playerRow <= matrix.Length - 1 && playerCol >= 0 && playerCol <= matrix.Length - 1)
            {
                return true;
            }
            return false;
        }
    }
}


