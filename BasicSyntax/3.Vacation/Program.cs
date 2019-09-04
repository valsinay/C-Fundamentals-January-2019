using System;

namespace _3.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPeople = int.Parse(Console.ReadLine());
            string typePeople = Console.ReadLine();
            string day = Console.ReadLine();
            double ticketPrice = 0;
            double totalSum = 0;
            double discount = 0;

            if (day == "Friday")
            {
                if (typePeople == "Students")
                {
                    ticketPrice = 8.45;
                    totalSum = numberPeople * ticketPrice;
                    if (numberPeople>=30)
                    {
                        discount = totalSum *0.15;
                        totalSum -= discount;
                    }
                    Console.WriteLine($"Total price: {totalSum:f2}");
                }
               else if (typePeople == "Business")
                {
                    ticketPrice = 10.90;
                    totalSum = numberPeople * ticketPrice;
                    if (numberPeople >=100)
                    {
                        totalSum = totalSum - ticketPrice * 10;
                    }
                    Console.WriteLine($"Total price: {totalSum:f2}");
                }
              else  if (typePeople == "Regular")
                {
                    ticketPrice = 15;
                    totalSum = numberPeople * ticketPrice;
                    if (numberPeople >=10 && numberPeople <=20)
                    {
                        discount = totalSum * 0.05;
                        totalSum -= discount;
                    }
                    Console.WriteLine($"Total price: {totalSum:f2}");
                }
            }
            else if (day == "Saturday")
            {

                if (typePeople == "Students")
                {
                    ticketPrice = 9.80;
                    totalSum = numberPeople * ticketPrice;
                    if (numberPeople >= 30)
                    {
                       discount = totalSum *0.15;
                        totalSum -= discount;
                    }
                    Console.WriteLine($"Total price: {totalSum:f2}");
                }

                else if (typePeople == "Business")
                {
                    ticketPrice = 15.60;
                    totalSum = numberPeople * ticketPrice;
                    if (numberPeople >= 100)
                    {
                        totalSum = totalSum - ticketPrice * 10;
                    }
                    Console.WriteLine($"Total price: {totalSum:f2}");
                }
                else if (typePeople == "Regular")
                {
                    ticketPrice = 20;
                    totalSum = numberPeople * ticketPrice;
                   
                    if (numberPeople >= 10 && numberPeople <= 20)
                    {
                        discount = totalSum * 0.05;
                        totalSum -= discount;
                    }
                    Console.WriteLine($"Total price: {totalSum:f2}");
                }

            }
            else if (day == "Sunday")
            {
                if (typePeople == "Students")
                {
                    ticketPrice = 10.46;
                    totalSum = numberPeople * ticketPrice;
                    if (numberPeople >= 30)
                    {
                        discount = totalSum *0.15;
                        totalSum = totalSum - discount;
                    }
                    Console.WriteLine($"Total price: {totalSum:f2}");
                }

                else if (typePeople == "Business")
                {
                    ticketPrice = 16;
                    totalSum = numberPeople * ticketPrice;
                    if (numberPeople >= 100)
                    {
                        totalSum = totalSum - ticketPrice * 10;
                    }
                    Console.WriteLine($"Total price: {totalSum:f2}");
                }
                else if (typePeople == "Regular")
                {
                    ticketPrice = 22.50;
                    totalSum = numberPeople * ticketPrice;
                    if (numberPeople >= 10 && numberPeople <= 20)
                    {
                        discount = totalSum * 0.05;
                        totalSum -= discount;
                    }
                    Console.WriteLine($"Total price: {totalSum:f2}");
                }
            }
        }
    }
}
