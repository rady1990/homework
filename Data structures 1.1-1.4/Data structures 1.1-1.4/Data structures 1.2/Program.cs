using System;
using System.Collections;
using System.Collections.Generic;

class OddNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number of variables");
        string lengthAsString = Console.ReadLine();
        int sequenceLength;
        if (int.TryParse(lengthAsString, out sequenceLength) == false)
        {
            Console.WriteLine("Invalid data!");
            return;
        }
        if (sequenceLength < 0)
        {
            Console.WriteLine("Invalid data!");
        }
        Console.WriteLine("Enter numbers");
        int[] sequence = new int[sequenceLength];
        for (int i = 0; i < sequenceLength; i++)
        {
            
            string currentNumberAsString = Console.ReadLine();
            int currentNumber;
            if (int.TryParse(currentNumberAsString, out currentNumber) == false)
            {
                Console.WriteLine("Invalid data!");
                return;
            }
            sequence[i] = currentNumber;
        }
        List<int> outputSequence = RemoveElements(sequence);
        PrintSequence(outputSequence);
    }

    private static List<int> RemoveElements(int[] sequence)
    {
        List<int> resultSequence = new List<int>();
        Array.Sort(sequence);
        int numberOcurances = 1;
        for (int i = 0; i < sequence.Length - 1; i++)
        {
            if (sequence[i] == sequence[i + 1])
            {
                numberOcurances++;
            }
            else if ((numberOcurances % 2) == 0)
            {
                resultSequence.Add(sequence[i]);
                numberOcurances = 1;
            }
        }
        return resultSequence;
    }

    private static void PrintSequence(IEnumerable sequence)
    {
        Console.WriteLine();
        IEnumerator i = sequence.GetEnumerator();
        while (i.MoveNext())
        {
            Console.WriteLine(i.Current);
        }
    }
}
