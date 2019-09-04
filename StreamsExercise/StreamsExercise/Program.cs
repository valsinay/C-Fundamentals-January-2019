using System;
using System.IO;

namespace StreamsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string symbols = "-,.!?";
            int count = 0;

            using (var reader = new StreamReader("../../../text.txt"))
            {
                using (var writer = new StreamWriter("../../../output.txt"))
                {
                    while (true)
                    {
                        var line = reader.ReadLine();

                        if (line == null)
                        {
                            break;
                        }
                        if (count % 2 == 0)
                        {
                            string changedLine = string.Empty;

                            foreach (var charr in line)
                            {
                                if (symbols.Contains(charr))
                                {
                                    changedLine += '@';
                                }
                                else
                                {
                                    changedLine += charr;
                                }
                            }
                            string[] splitted = changedLine.Split();

                            Array.Reverse(splitted);
                            writer.WriteLine(string.Join(" ", splitted));
                        }
                        count++;
                    }
                }
            }
        }


    }
}
