
using System;
using System.Linq;


class CountSymbols
{
    public static void Main(string[] args)
    {
        char[] input = Console.ReadLine().ToCharArray(); // here we convert the input data to a char array

        var groups = input.GroupBy(a => a).OrderBy(a => a.Key); // here we group the chars and sort them lexicographically by key

        foreach (var group in groups)
        {

            Console.WriteLine("{0}: {1} time/s", group.Key, group.Count());
        }

        Console.ReadKey(true);
    }
}