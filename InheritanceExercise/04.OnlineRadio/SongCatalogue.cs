namespace _04.OnlineRadio
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class SongCatalogue
    {
        private List<Song> playlist = new List<Song>();


        public string AddSong(Song song)
        {
            playlist.Add(song);

            return "Song added.";
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            int total = playlist.Select(x =>x.GetLengthInSeconds()).Sum();

            TimeSpan t = TimeSpan.FromSeconds(total);
            string format = string.Format("{0}h {1}m {2}s",
                t.Hours,
                t.Minutes,
                t.Seconds);

            builder.AppendLine($"Songs added: {playlist.Count}");
            builder.AppendLine($"Playlist length: {format}");

            return builder.ToString().TrimEnd();
        }
    }
}
