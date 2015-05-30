
using System;
using System.Collections.Generic;
using System.Linq;


class EqualSequencesStrings
{
    public static void Main(string[] args)
    {
        List<string> input = Console.ReadLine().Split().ToList();

        for (int i = 0; i < input.Count; i++)
        {
            string currString = input[i];
            Console.Write("{0} ", currString);
            for (int j = i + 1; j < input.Count; j++)
            {
                if (currString == input[j])
                {
                    Console.Write("{0} ", currString);
                    input.RemoveAt(j);
                    j--;
                }
            }
            input.RemoveAt(i);
            Console.WriteLine();
            i--;
        }
    }
}