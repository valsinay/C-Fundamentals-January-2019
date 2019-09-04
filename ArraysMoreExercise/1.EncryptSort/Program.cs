using System;
using System.Linq;
using System.Collections;
namespace _1.EncryptSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            int value = 0;
            int sum = 0;
            for (int j = 0; j < n; j++)
            {
                string input = Console.ReadLine();

                for (int i = 0; i < input.Length; i++)
                {
                    value = (int)input[i];
                    if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u'
                        || input[i] == 'A' || input[i] == 'E' || input[i] == 'I' || input[i] == 'O' || input[i] == 'U')
                    {
                        value *= input.Length;
                    }
                    
                    else
                    {
                        value /= input.Length;
                    }
                    sum += value;
                   
                }

                array[j] = sum;
            }

            foreach (var item in array.OrderBy(x=>x))
            {
                Console.WriteLine(item);
            }
        }
    }
}
