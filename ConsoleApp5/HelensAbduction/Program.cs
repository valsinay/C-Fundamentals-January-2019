using System;

namespace HelensAbduction
{
    class Program
    {
        static void Main(string[] args)
        {
            int energyParis = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());

            char[][] matrix = new char[rows][];

            bool isDead = false;
            bool foundHelena = false;

            int parisRow = -1;
            int parisCol = -1;

            for (int row = 0; row < matrix.Length; row++)
            {
                char[] chars = Console.ReadLine()
                    .ToCharArray();

                matrix[row] = chars;

                for (int col = 0; col < matrix.Length; col++)
                {
                    if (matrix[row][col] == 'P')
                    {
                        parisRow = row;
                        parisCol = col;
                    }
                }

            }
            while (true)
            {
                string[] commands = Console.ReadLine().Split();

                string parisCommand = commands[0];
                int staticParisRow = parisRow;
                int staticParisCol = parisCol;

                int enemyRrow = int.Parse(commands[1]);
                int enemyCol = int.Parse(commands[2]);

                matrix[enemyRrow][enemyCol] = 'S';

                if (parisCommand == "up")
                {
                    matrix[parisRow][parisCol] = '-';
                    parisRow--;
                    // matrix[parisRow--][parisCol] = 'P';

                }
                else if (parisCommand == "down")
                {
                    matrix[parisRow][parisCol] = '-';
                    //  matrix[parisRow++][parisCol] ='P';
                    ++parisRow;
                }
                else if (parisCommand == "left")
                {
                    matrix[parisRow][parisCol] = '-';
                    --parisCol;

                }
                else if (parisCommand == "right")
                {
                    matrix[parisRow][parisCol] = '-';
                    //matrix[parisRow][parisCol++] = 'P';
                    parisCol++;

                }

                if (ValidateMethod(parisRow, parisCol, matrix))
                {
                    if (matrix[parisRow][parisCol] == matrix[enemyRrow][enemyCol])
                    {
                        energyParis -= 3;
                        if (energyParis <= 0)
                        {
                            isDead = true;
                            matrix[parisRow][parisCol] = 'X';
                            break;
                        }
                    }
                    else if (matrix[parisRow][parisCol] == 'H')
                    {
                        matrix[parisRow][parisCol] = '-';
                        foundHelena = true;
                        energyParis--;
                        break;
                    }
                    energyParis--;
                    CheckIsDead(energyParis, parisRow, parisCol, matrix);

                }
                else
                {
                    parisRow = staticParisRow;
                    parisCol = staticParisCol;
                    energyParis--;

                    if (CheckIsDead(energyParis, parisRow, parisCol, matrix))
                    {
                        return;
                    }
                }

            }

            if (isDead)
            {
                Console.WriteLine($"Paris died at {parisRow};{parisCol}.");
                foreach (var item in matrix)
                {
                    Console.WriteLine(string.Join("", item));
                }
                return;
            }

            else if (foundHelena)
            {
                Console.WriteLine($"Paris has successfully abducted Helen! Energy left: { energyParis}");

                foreach (var item in matrix)
                {
                    Console.WriteLine(string.Join("", item));
                }
                return;
            }
            else
            {
                Console.WriteLine($"Paris died at {parisRow};{parisCol}.");
                foreach (var item in matrix)
                {
                    Console.WriteLine(string.Join("", item));
                }
                return;
            }

        }

        private static bool CheckIsDead(int energyParis, int parisRow, int parisCol, char[][] matrix)
        {
            if (energyParis <= 0)
            {
                matrix[parisRow][parisCol] = 'X';
                Console.WriteLine($"Paris died at {parisRow};{parisCol}.");
                foreach (var item in matrix)
                {
                    Console.WriteLine(string.Join("", item));
                }
                return true;
            }
            return false;
        }

        private static bool ValidateMethod(int parisRow, int parisCol, char[][] matrix)
        {
            if (parisRow >= 0 && parisRow <= matrix.Length - 1 && parisCol >= 0 && parisCol <= matrix.Length - 1)
            {
                return true;
            }
            return false;
        }
    }
}
