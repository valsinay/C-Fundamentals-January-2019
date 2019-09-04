using System;
using System.Linq;

namespace _02.Tron
{
    public class Program
    {
        public static bool isDead = false;
        public static bool isInMatrix = false;

        static void Main(string[] args)
        {



            int size = int.Parse(Console.ReadLine());

            char[][] matrix = new char[size][];

            int firstPlayerRow = -1;
            int firstPlayerCol = -1;
            int secondPlayerRow = -1;
            int secondPlayerCol = -1;

            for (int i = 0; i < size; i++)
            {
                char[] chars = Console.ReadLine().ToCharArray();

                matrix[i] = chars;

            }

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix.Length; col++)
                {
                    if (matrix[row][col] == 'f')
                    {
                        firstPlayerRow = row;
                        firstPlayerCol = col;
                    }
                    else if (matrix[row][col] == 's')
                    {
                        secondPlayerRow = row;
                        secondPlayerCol = col;

                    }
                }
            }

            while (true)
            {
                string[] commands = Console.ReadLine().Split();
                string firstPlayerCommand = commands[0];
                string secondPlayerCommand = commands[1];

                switch (firstPlayerCommand)
                {
                    case "down":
                        if (firstPlayerRow+1 > matrix.Length-1)
                        {
                            matrix[0][firstPlayerCol] = 'f';
                            break;
                        }
                        CheckFirstDead(matrix, firstPlayerRow + 1, firstPlayerCol);
                        if (isDead)
                        {
                            matrix[firstPlayerRow + 1][firstPlayerCol] = 'x';
                            break;

                        }
                        
                        matrix[firstPlayerRow + 1][firstPlayerCol] = 'f';
                        firstPlayerRow++;
                        break;

                    case "up":
                        if (firstPlayerRow-1 <0)
                        {
                            CheckFirstDead(matrix, firstPlayerRow , firstPlayerCol);
                            if (isDead)
                            {
                                matrix[firstPlayerRow - 1][firstPlayerCol] = 'x';
                                break;

                            }
                            matrix[matrix.Length - 1][firstPlayerCol] = 'f';
                            break;
                        }
                        //CheckFirstDead(matrix, firstPlayerRow - 1, firstPlayerCol);
                        //if (isDead)
                        //{
                        //    matrix[firstPlayerRow - 1][firstPlayerCol] = 'x';
                        //    break;

                        //}
                        matrix[firstPlayerRow - 1][firstPlayerCol] = 'f';
                        firstPlayerRow--;
                        break;

                    case "left":
                        if (firstPlayerCol-1 <0)
                        {
                            matrix[firstPlayerRow][matrix.Length-1] = 'f';
                            break;
                        }
                        CheckFirstDead(matrix, firstPlayerRow, firstPlayerCol - 1);
                        if (isDead)
                        {
                            matrix[firstPlayerRow][firstPlayerCol - 1] = 'x';
                            break;

                        }
                        matrix[firstPlayerRow][firstPlayerCol - 1] = 'f';
                        firstPlayerCol--;
                        break;

                    case "right":
                       
                        if (firstPlayerCol+1 > matrix[firstPlayerRow].Length-1)
                        {
                            matrix[firstPlayerRow][0] = 'f';
                            break;

                        }
                        CheckFirstDead(matrix, firstPlayerRow, firstPlayerCol + 1);
                        if (isDead)
                        {
                            matrix[firstPlayerRow][firstPlayerCol + 1] = 'x';
                            break;

                        }
                        matrix[firstPlayerRow][firstPlayerCol + 1] = 'f';
                        firstPlayerCol++;
                        break;
                        
                }
                
                if (isDead)
                {
                    foreach (var item in matrix)
                    {
                        Console.WriteLine(string.Join("", item));

                    }
                    return;
                }
                

                switch (secondPlayerCommand)
                {
                    case "down":
                        if (secondPlayerRow + 1 > matrix.Length - 1)
                        {
                            matrix[0][secondPlayerCol] = 'f';
                            break;
                        }
                        CheckSecondDead(matrix, secondPlayerRow+1, secondPlayerCol);
                        if (isDead)
                        {
                            matrix[secondPlayerRow + 1][secondPlayerCol] = 'x';
                            break;
                        }
                        matrix[secondPlayerRow + 1][secondPlayerCol] = 's';
                        secondPlayerRow++;

                        break;
                    case "up":
                        if (secondPlayerRow - 1 < 0)
                        {
                            

                            CheckSecondDead(matrix, secondPlayerRow, secondPlayerCol);
                            if (isDead)
                            {
                                matrix[secondPlayerRow - 1][secondPlayerCol] = 'x';
                                break;
                            }
                            matrix[matrix.Length - 1][secondPlayerCol] = 'f';
                            break;
                        }
                        matrix[secondPlayerRow - 1][secondPlayerCol] = 's';
                        secondPlayerRow--;

                        break;
                    case "left":
                        if (secondPlayerCol - 1 < 0)
                        {
                            matrix[secondPlayerRow][matrix.Length - 1] = 'f';
                            break;
                        }
                        CheckSecondDead(matrix, secondPlayerRow, secondPlayerCol-1);
                        if (isDead)
                        {
                            matrix[secondPlayerRow][secondPlayerCol-1] = 'x';
                            break;
                        }
                        matrix[secondPlayerRow][secondPlayerCol - 1] = 's';
                        secondPlayerCol--;

                        break;
                    case "right":

                        if (secondPlayerCol + 1 > matrix[secondPlayerRow].Length - 1)
                        {
                            matrix[secondPlayerRow][0] = 'f';
                            break;

                        }
                        CheckSecondDead(matrix, secondPlayerRow, secondPlayerCol+1);
                        if (isDead)
                        {
                            matrix[secondPlayerRow][secondPlayerCol+1] = 'x';
                            break;
                        }
                        matrix[secondPlayerRow][secondPlayerCol + 1] = 's';
                        secondPlayerCol++;

                        break;

                    default:
                        break;
                }

                if (isDead)
                {
                    foreach (var item in matrix)
                    {
                        Console.WriteLine(string.Join("", item));

                    }
                    return;
                }

            }

        }

       
        private static void CheckFirstDead(char[][] matrix, int row, int col)
        {
            var dead = matrix[row][col] == 's' ? 'x' : 'f';

            if (dead == 'x')
            {
                isDead = true;
            }
            
        }
        private static void CheckSecondDead(char[][] matrix, int row, int col)
        {
            var dead = matrix[row][col] == 'f' ? 'x' : 's';

            if (dead == 'x')
            {
                isDead = true;
            }
        }
    }
}

