namespace _04.OnlineRadio
{
    using _04.OnlineRadio.Exceptions;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            SongCatalogue catalogue = new SongCatalogue();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                try
                {
                    string[] input = Console.ReadLine().Split(";");

                    string artist = input[0];
                    string songName = input[1];
                   var songLength = input[2].Split(":");

                    if (int.TryParse(songLength[0],out int num) == false || int.TryParse(songLength[1],out int num1) == false)
                    {
                        throw new InvalidSongLengthException();
                    }
                    int minutes = int.Parse(songLength[0]);
                    int seconds = int.Parse(songLength[1]);



                    Song song = new Song(artist, songName, minutes, seconds,input[2]);


                    Console.WriteLine(catalogue.AddSong(song));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine(catalogue);
        }
    }
}
