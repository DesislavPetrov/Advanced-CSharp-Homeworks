
using System;
using System.Linq;


class LongestIncreasingSequence
{
    public static void Main()
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int counter = 1;
        int maxLength = 1; // it will hold the length of the longest increasing sequence
        int endElement = 0; // here we'll put the position of the last element of the longest increasing sequence

        Console.Write("{0} ", input[0]); // here we print the first element of the array
        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] > input[i - 1])
            {
                Console.Write("{0} ", input[i]);
                counter++;
            }
            else
            {
                counter = 1;
                Console.WriteLine();
                Console.Write("{0} ", input[i]);
            }
            if (counter > maxLength)
            {
                maxLength = counter;
                endElement = i;
            }
        }
        Console.WriteLine();
        Console.Write("Longest: ");
        for (int j = endElement - maxLength + 1; j <= endElement; j++)
        {
            Console.Write("{0} ", input[j]);
        }
        Console.WriteLine();
    }
}