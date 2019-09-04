namespace _04.OnlineRadio.Exceptions
{
    public class InvalidSongLengthException : InvalidSongException
    {
          public override string Message => "Invalid song length.";
    }
}
