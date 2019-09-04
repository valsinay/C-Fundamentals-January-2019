using System;
using System.IO;

namespace _02.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("../../../text.txt"))
            {
                int counter = 1;

                using (var writer = new StreamWriter("../../../output.txt"))
                {
                    while (true)
                    {
                        int letterCount = 0;
                        int symbolCount = 0;

                        string line = reader.ReadLine();
                        if (line == null)
                        {
                            break;
                        }
                        foreach (var charr in line)
                        {
                            if (char.IsLetter(charr))
                            {
                                letterCount++;
                            }
                            else if (char.IsPunctuation(charr))
                            {
                                symbolCount++;
                            }
                        }

                        writer.WriteLine($"Line {counter}: {line} ({letterCount})({symbolCount})");

                        counter++;
                    }
                }
            }
        }
    }
}
