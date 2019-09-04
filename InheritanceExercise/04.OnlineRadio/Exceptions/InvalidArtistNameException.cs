namespace _04.OnlineRadio.Exceptions
{
   public class InvalidArtistNameException : InvalidSongException
    {
        public override string Message => "Artist name should be between 3 and 20 symbols."; 
    }
}
