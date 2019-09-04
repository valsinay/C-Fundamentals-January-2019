using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.SongEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] line = Console.ReadLine().Split(":");
                if (line[0] == "end")
                {
                    break;
                }
                string artist = line[0];
                string song = line[1];

               
                string artistPattern = @"^(?<artist>[A-Z\s\'*][a-z\s\'*]+)$";
                Match artistMatch = Regex.Match(artist, artistPattern);

                string songPattern = @"(?<song>[A-Z\s*]+)$";
                Match songMatch = Regex.Match(song, songPattern);

                string artistStr = artistMatch.Groups["artist"].Value;
                string songStr = songMatch.Groups["song"].Value;
                StringBuilder sb = new StringBuilder();

                if (artistMatch.Success && songMatch.Success)
                {
                    for (int i = 0; i < artistStr.Length; i++)
                    {
                        int length = artistStr.Length;
                        char current = artistStr[i];
                        if (current == ' ' || current == '\'')
                        {
                            sb.Append(current);
                            continue;
                        }
                        int currentLetter = artistStr[i];
                        for (int j = 0; j < length; j++)
                        {
                            if (char.IsUpper(current) && currentLetter + 1 > 90)
                            {
                                currentLetter = 64;
                            }
                            else if (char.IsLower(current) && currentLetter + 1 > 122)
                            {
                                currentLetter = 96;
                            }
                                currentLetter += 1;
                        }
                        sb.Append((char)currentLetter);
                    }
                    sb.Append("@");
                    for (int i = 0; i < songStr.Length; i++)
                    {
                        int length = artistStr.Length;
                        char current = songStr[i];
                        int currentLetter = songStr[i];
                        if (current == ' ' || current =='\'')
                        {
                            sb.Append(current);
                            continue;
                        }
                        for (int j = 0; j < length; j++)
                        {
                            if (char.IsUpper(current) && currentLetter + 1 > 90)
                            {
                                currentLetter = 64;
                            }
                            else if (char.IsLower(current) && currentLetter + 1 > 122)
                            {
                                currentLetter = 96;
                            }
                            currentLetter += 1;
                        }
                        int changed = currentLetter;

                        sb.Append((char)changed);
                    }
                    Console.WriteLine($"Successful encryption: {sb}");
                    sb = new StringBuilder();
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}
