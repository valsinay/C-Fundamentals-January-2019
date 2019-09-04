using _01.Logger.Appenders.Contracts;
using _01.Logger.Layouts.Contracts;
using _01.Logger.Loggers.Contracts.Enums;
using System;

namespace _01.Logger.Appenders
{
    public class ConsoleAppender : IAppender
    {
        private ILayout layout;

        public ConsoleAppender(ILayout layout)
        {
            this.layout = layout;
        }

        public ReportLevel ReportLevel { get; set; }

        public void Append(string dateTime, string reportLevel, string message)
        {
            Console.WriteLine(string.Format(this.layout.Format,dateTime,reportLevel,message));
        }

        
    }
}
