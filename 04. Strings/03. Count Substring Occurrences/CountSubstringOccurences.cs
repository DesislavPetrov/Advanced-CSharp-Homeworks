
using System;


class CountSubstringOccurences
{
    public static void Main()
    {
        string input = Console.ReadLine().ToLower(); // input the string and convert it to lowercase
        string subInput = Console.ReadLine(); // input the substring we search for

        int counter = 0; // here we count the number of occurences
        for (int i = 0; i < input.Length - subInput.Length + 1; i++)
        {
            if (input.Substring(i, subInput.Length) == subInput)
            {
                counter++;
            }
        }

        Console.WriteLine(counter);
    }
}