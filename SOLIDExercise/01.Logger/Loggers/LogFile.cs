using _01.Logger.Loggers.Contracts;
using System.Linq;

namespace _01.Logger.Loggers
{
    public class LogFile : ILogFile
    {
        public int Size {get;private set;}

        public void Write(string message)
        {
            Size += message.Where(char.IsLetter).Sum(x => x);
        }
    }
}
