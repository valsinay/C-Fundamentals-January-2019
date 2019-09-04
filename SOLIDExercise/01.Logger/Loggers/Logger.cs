using _01.Logger.Appenders.Contracts;
using _01.Logger.Loggers.Contracts;

namespace _01.Logger.Loggers
{
    public class Logger : ILogger
    {
        private IAppender consoleAppender;
        private IAppender fileAppender;

        public Logger(IAppender consoleAppender, IAppender fileAppender)
        {
            this.consoleAppender = consoleAppender;
           
        }

        public Logger(IAppender consoleAppender, IAppender fileAppender)
            :base
        {
            this.consoleAppender = consoleAppender;

        }

        public void Info(string dateTime, string infoMessage)
        {
            this.Append(dateTime, "Info", infoMessage);
        }

        public void Warning(string dateTime, string warningMessage)
        {
            this.Append(dateTime, "Warning", warningMessage);
        }

        public void Error(string dateTime, string errorMessage)
        {
            this.Append(dateTime, "Error", errorMessage);
        }

        public void Critical(string dateTime, string criticalMessage)
        {
            this.Append(dateTime, "Critical", criticalMessage);
        }

        public void Fatal(string dateTime,string fatalMessage)
        {
            this.Append(dateTime, "Fatal", fatalMessage);
        }

        private void Append(string dateTime,string type, string message)
        {
            consoleAppender.Append(dateTime, type, message);
            fileAppender.Append(dateTime, type, message);
        }

    }

}
