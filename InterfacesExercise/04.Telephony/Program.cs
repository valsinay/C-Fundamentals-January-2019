namespace _04.Telephony
{
    using _04.Telephony.Interfaces;
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static void Main(string[] args)
        {

            ICallable call = new Smartphone();
            IBrowseable browse = new Smartphone();
            var numbers = Console.ReadLine().Split();
            foreach (var phone in numbers)
            {
                Console.WriteLine(call.Call(phone));
            }

            var sites = Console.ReadLine().Split();

            foreach (var site in sites)
            {
                Console.WriteLine(browse.Browse(site));
            }
            
        }
    }
}
