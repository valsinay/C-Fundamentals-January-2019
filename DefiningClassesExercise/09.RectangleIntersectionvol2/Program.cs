using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;

namespace _09._Rectangle_Intersection
{
    public class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);


            var rectanglesNumber = int.Parse(input[0]);
            var intersectionChecks = int.Parse(input[1]);

            List<Rectangle> rectangles = new List<Rectangle>();

            for (int i = 0; i < rectanglesNumber; i++)
            {
                var line = Console.ReadLine().Split();

                var id = line[0];
                var width = double.Parse(line[1]);
                var height = double.Parse(line[2]);
                var x = double.Parse(line[3]);
                var y = double.Parse(line[4]);

                Rectangle rectangle = new Rectangle(id, width, height, x, y);
                rectangles.Add(rectangle);

            }

            while (intersectionChecks > 0)
            {
                var line = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                var firstId = line[0];
                var secondId = line[1];

                int firstIndex = 0;
                int secondIndex = 0;

                for (int i = 0; i < rectanglesNumber; i++)
                {
                    if (rectangles[i].Id == firstId)
                    {
                        firstIndex = i;
                    }
                    if (rectangles[i].Id == secondId)
                    {
                        secondIndex = i;
                    }
                }
                if (GetRectangles(rectangles[firstIndex], rectangles[secondIndex]))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }

                intersectionChecks--;
            }
        }
        public static bool GetRectangles(Rectangle rectangle1, Rectangle rectangle2)
        {
            return rectangle1.Width + rectangle1.X >= rectangle2.X &&
          rectangle1.X <= rectangle2.X + rectangle2.Width &&
          rectangle1.Y >= rectangle2.Y - rectangle2.Height &&
          rectangle1.Y - rectangle1.Height <= rectangle2.Y;
        }
    }
}
