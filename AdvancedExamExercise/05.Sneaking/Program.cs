﻿using System;
using System.Linq;

namespace _05.Sneaking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[][] room = new char[n][];

            int samRow = -1;
            int samCol = -1;

            for (int i = 0; i < n; i++)
            {

                room[i] = Console.ReadLine().ToCharArray();

                if (room[i].Contains('S'))
                {
                    int index = Array.IndexOf(room[i], 'S');
                    samRow = i;
                    samCol = index;
                    room[samRow][samCol] = '.';
                }

            }

            char[] commands = Console.ReadLine().ToCharArray();

            foreach (var command in commands)
            {
                Move(room);

                if (room[samRow].Contains('b') && Array.IndexOf(room[samRow], 'b') < samCol
                    || room[samRow].Contains('d') && Array.IndexOf(room[samRow], 'd') > samCol)
                {
                    room[samRow][samCol] = 'X';
                    Console.WriteLine($"Sam died at {samRow}, {samCol}");
                    break;
                }

                switch (command)
                {
                    case 'U': samRow--; break;
                    case 'D': samRow++; break;
                    case 'L': samCol--; break;
                    case 'R': samCol++; break;
                    default:
                        break;
                }

                if (room[samRow][samCol] == 'b' || room[samRow][samCol] == 'd')
                {
                    room[samRow][samCol] = '.';
                }
                if (room[samRow].Contains('N'))
                {
                    int nikoladze = Array.IndexOf(room[samRow], 'N');
                    room[samRow][nikoladze] = 'X';
                    room[samRow][samCol] = 'S';
                    Console.WriteLine("Nikoladze killed!");
                    break;
                }
            }

            foreach (var row in room)
            {
                Console.WriteLine(string.Join("", row));
            }
        }

        private static void Move(char[][] room)
        {
            for (int i = 0; i < room.Length; i++)
            {
                int rowLength = room[i].Length;

                if (room[i].Contains('b') && Array.IndexOf(room[i], 'b') < rowLength - 1)
                {
                    int index = Array.IndexOf(room[i], 'b');
                    room[i][index] = '.';
                    room[i][index + 1] = 'b';
                }
                else if (room[i].Contains('b') && Array.IndexOf(room[i], 'b') == rowLength - 1)
                {
                    room[i][rowLength - 1] = 'd';
                }
                else if (room[i].Contains('d') && Array.IndexOf(room[i], 'd') > 0)
                {
                    int index = Array.IndexOf(room[i], 'd');
                    room[i][index] = '.';
                    room[i][index - 1] = 'd';
                }
                else if (room[i].Contains('d') && Array.IndexOf(room[i], 'd') == 0)
                {
                    room[i][0] = 'b';
                }
            }
        }
    }
}
