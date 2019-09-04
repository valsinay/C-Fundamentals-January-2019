using _01.Logger.Layouts.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Logger.Layouts
{
    public class XMLLayout : ILayout
    {
        public string Format
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("<log>")
                    .AppendLine("   <date>{0}</date")
                    .AppendLine("   <level>{1}</level>")
                    .AppendLine("   <message>{2}</message>")
                    .AppendLine("</log>");

                return sb.ToString().Trim();
            }
        }
    }
}
