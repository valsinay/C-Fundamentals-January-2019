using System;

namespace _02.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split();

            string firstWord = input[0];
            string secondWord = input[1];

            int result = 0;
            if (firstWord.Length == secondWord.Length)
            {
                for (int i = 0; i < firstWord.Length; i++)
                {

                    char firstSymbol = firstWord[i];
                    char secondSymbol = secondWord[i];

                    result += firstSymbol * secondSymbol;

                }
            }
            
            else if (firstWord.Length < secondWord.Length)
            {

                for (int i = 0; i < secondWord.Length; i++)
                {
                    if (firstWord.Length == i)
                    {
                        for (int j = i; j < secondWord.Length; j++)
                        {
                            result += secondWord[j];
                        }
                        break;
                    }
                    char firstSymbol = firstWord[i];
                    char secondSymbol = secondWord[i];

                    result += firstSymbol * secondSymbol;

                }
            }
            else if (secondWord.Length < firstWord.Length)
            {

                for (int i = 0; i < firstWord.Length; i++)
                {
                    if (secondWord.Length == i)
                    {
                        for (int j = i; j < firstWord.Length; j++)
                        {
                            result += firstWord[j];
                        }
                        break;
                    }
                    char firstSymbol = firstWord[i];
                    char secondSymbol = secondWord[i];

                    result += firstSymbol * secondSymbol;

                }
            }
            Console.WriteLine(result);
        }
    }
}
