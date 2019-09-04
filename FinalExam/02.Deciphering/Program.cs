using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Deciphering
{
    class Program
    {
        static void Main(string[] args)
        {
            string encrypted = Console.ReadLine();

            var splitString = Console.ReadLine()
                 .Split()
                 .ToList();

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < encrypted.Length; i++)
            {
                if (encrypted[i] >= 100 && encrypted[i] <= 125 || encrypted[i] == 35)
                {
                    int word = encrypted[i] - 3;
                    char changed = (char)word;

                    sb.Append(changed);
                }
                else
                {
                    Console.WriteLine("This is not the book you are looking for.");
                    return;
                }

            }

            for (int i = 0; i < sb.Length - 1; i++)
            {
                char letter = sb[i];
                char nextLetter = sb[i + 1];
                
               string  piece = "" + letter + nextLetter;

                if (piece == splitString[0])
                {
                    sb.Replace(piece, splitString[1]);
                    break;
                }
            }

            // sb = sb.Replace(splitString[0], splitString[1]);
            Console.WriteLine(sb);
        }
    }
}
