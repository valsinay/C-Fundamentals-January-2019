namespace _04.OnlineRadio
{
    using _04.OnlineRadio.Exceptions;
    using System;

    public class Song
    {
        private string artistName;
        private string songName;
        private int songMinutes;
        private int songSeconds;
        private string length;

        public Song(string artistName, string songName, int songMinutes, int songSeconds,string length)
        {
            this.ArtistName = artistName;
            this.SongName = songName;
            this.SongMinutes = songMinutes;
            this.SongSeconds = songSeconds;
            this.Length = length;
        }
        public string Length
        {
            get => this.length;

            set
            {
                var input = value.Split(":");

                if (input.Length!=2)
                {
                    throw new InvalidSongLengthException();
                }
                if (int.TryParse(input[0], out int _) && int.TryParse(input[1], out int _))
                {
                    int firstNum = int.Parse(input[0]);
                    int secondNum = int.Parse(input[1]);

                    if (firstNum<0 || firstNum >14 || secondNum<0 || secondNum>59)
                    {
                        throw new InvalidSongLengthException();
                    }

                this.length = value;
                }
                else
                {
                    throw new InvalidSongLengthException();
                }
            }

        }

        public string ArtistName
        {
            get => this.artistName;

            set
            {
                if (value.Length < 3 || value.Length > 20)
                {
                  //  throw new ArgumentException("Artist name should be between 3 and 20 symbols.");
                    throw new InvalidArtistNameException();
                }
                this.artistName = value;
            }
        }

        public string SongName
        {
            get => this.songName;

            set
            {
                if (value.Length < 3 || value.Length > 30)
                {
                  //  throw new ArgumentException("Song name should be between 3 and 30 symbols.");
                    throw new InvalidSongNameException();
                }
                this.songName = value;
            }
        }

        public int SongMinutes
        {
            get => this.songMinutes;

            set
            {
                if (value < 0 || value > 14)
                {
                    throw new InvalidSongMinutesException();
                }
                this.songMinutes = value;
            }
        }

        public int SongSeconds
        {
            get => this.songSeconds;

            set
            {
                if (value < 0 || value > 59)
                {
                    throw new InvalidSongSecondsException();
                }
                this.songSeconds = value;
            }
        }
        

        public int GetLengthInSeconds()
        {
            return this.SongMinutes * 60 + this.SongSeconds;
        }
    }
}
