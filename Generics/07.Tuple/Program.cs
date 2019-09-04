using System;

namespace _07.Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            string name = input[0] + " " + input[1];
            string address = input[2];
            string city = input[3];

            Tuple<string, string,string> firstTuple = new Tuple<string, string,string>(name, address,city);

            string[] secondInput = Console.ReadLine().Split();
            string secondName = secondInput[0];
            int litres = int.Parse(secondInput[1]);
            bool isDrunk = secondInput[2] == "drunk" ? true : false;


            Tuple<string, int,bool> secondTuple = new Tuple<string, int,bool>(secondName, litres,isDrunk);

            string[] thirdInput = Console.ReadLine().Split();

            string names =thirdInput[0];
            double doubleNumber = double.Parse(thirdInput[1]);
            string bankName = thirdInput[2];

            Tuple<string, double,string> thirdTuple = new Tuple<string, double,string>(names, doubleNumber, bankName);

            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);

        }
    }
}
