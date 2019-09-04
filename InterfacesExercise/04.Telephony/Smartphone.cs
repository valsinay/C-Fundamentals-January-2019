namespace _04.Telephony
{
    using _04.Telephony.Interfaces;
    using System;
    using System.Linq;
    using System.Text;

    public class Smartphone : ICallable, IBrowseable
    {
        public string Call(string call)
        {
            bool digitsOnly = call.All(char.IsDigit);
            var builder = new StringBuilder();

            if (!digitsOnly)
            {
                builder.AppendLine("Invalid number!");
            }
            else
            {
                builder.AppendLine($"Calling... {call}");
            }
                return builder.ToString().TrimEnd();
        }

        public string Browse(string url)
        {
            bool containsDigit = url.Any(char.IsDigit);
            var builder = new StringBuilder();

            if (containsDigit)
            {
                builder.AppendLine("Invalid URL!");
            }
            else
            {
                builder.AppendLine($"Browsing: {url}!");
            }
                return builder.ToString().TrimEnd();
        }

       
    }
}
