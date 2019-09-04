using System;
using System.Collections.Generic;

namespace _03.GenericSwapMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            var boxes = new Box<double>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                double value = double.Parse(Console.ReadLine());
                
                boxes.Add(value);
            }
            double element =double.Parse( Console.ReadLine());
            int count = GetCountOfGreaterElements(boxes.Data, element);
            Console.WriteLine(count);
        }
        public static int GetCountOfGreaterElements<T>(List<T> list, T element)        
            where T: IComparable
        {
            int count = 0;
            foreach (var item in list)
            {
                if (item.CompareTo(element)>0)
                {
                    count++;
                }
            }
            return count;
        }

        public static void Swap<T>(List<T> list, int index1, int index2)
        {
           var temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
        }
    }
}
