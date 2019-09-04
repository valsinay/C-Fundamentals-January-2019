using _01.Logger.Loggers.Contracts.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Logger.Appenders.Contracts
{
    public interface IAppender
    {
        void Append(string dateTime, string reportLevel, string message);

        ReportLevel ReportLevel { get; set; }
    }
}
