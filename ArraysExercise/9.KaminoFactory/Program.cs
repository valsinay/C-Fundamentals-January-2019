using System;
using System.Linq;

namespace _9.KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int dnaLength = int.Parse(Console.ReadLine());

            int[] sequences = Console.ReadLine()
                .Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            
            int bestSeq = 0;
            int currentSample = 1;
            int sample = 0;
            int currentSum = 0;
            int sum = 0;
            
            int startIndex = -1;
            
            int[] DNA = new int[dnaLength];

            string command = "";

            while (command != "Clone them!")
            {
                for (int i = 0; i < dnaLength; i++)
                {
                    if (sequences[i] == 1)
                    {
                        currentSum++;
                    }
                }
                int currentStartIndex = -1;
                int currentSeq = 0;
                bool isFound = false;

                for (int i = 0; i < dnaLength; i++)
                {
                    if (sequences[i] == 1)
                    {
                        if (!isFound)
                        {
                            currentStartIndex = i;
                        }
                    }
                    currentSeq++;

                    if (currentSeq > bestSeq)
                    {
                        bestSeq = currentSeq;
                        startIndex = currentStartIndex;
                        sample = currentSample;
                        sum = currentSum;
                        DNA = sequences;
                    }
                    else if (currentSeq == bestSeq)
                    {
                        if (currentStartIndex < startIndex)
                        {
                            bestSeq = currentSeq;
                            startIndex = currentStartIndex;
                            sample = currentSample;
                            sum = currentSum;
                            DNA = sequences;
                        }
                        else if (currentSum > sum)
                        {
                            bestSeq = currentSeq;
                            startIndex = currentStartIndex;
                            sample = currentSample;
                            sum = currentSum;
                            DNA = sequences;
                        }
                    }
                    else
                    {
                        currentStartIndex = -1;
                        currentSeq = 0;
                        isFound = false;
                    }

                    currentSample++;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {sample} with sum: {sum}.");
            Console.WriteLine(string.Join(" ", DNA));
        }
    }
}
