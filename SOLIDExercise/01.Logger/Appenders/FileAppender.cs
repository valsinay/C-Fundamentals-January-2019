using _01.Logger.Appenders.Contracts;
using _01.Logger.Layouts.Contracts;
using _01.Logger.Loggers.Contracts;
using _01.Logger.Loggers.Contracts.Enums;
using System.IO;

namespace _01.Logger.Appenders
{
    public class FileAppender : IAppender
    {
        private const string path = @"..\..\..\log.txt";
        private ILayout layout;
        private ILogFile logFile;

        public FileAppender(ILayout layout)
        {
            this.layout = layout;
        }

        public ReportLevel ReportLevel { get; set; }

        public void Append(string dateTime, string reportLevel, string message)
        {
            File.AppendAllText(path, string.Format(this.layout.Format, dateTime, reportLevel,
                message));
        }
    }
}
