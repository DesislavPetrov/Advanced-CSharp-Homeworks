using System;
using System.Collections.Generic;
class NightLife
{
    static void Main()
    {
        // Cities should remain in the order in which they have been received - so we'll use Dictionary<T,T>
        // Venues should be sorted alphabetically - so we'll use SortedDictionary<T,T>
        // Performers should by unique (per venue) and also sorted alphabetically - so we'll use SortedSet<T>
        Dictionary<string, SortedDictionary<string, SortedSet<string>>> directory = new Dictionary<string, SortedDictionary<string, SortedSet<string>>>();
        while (true)
        {
            string line = Console.ReadLine();
            if (line == "END")
            {
                break;
            }
            string[] input = line.Split(';');
            string city = input[0];
            string venue = input[1];
            string performer = input[2];
            if (!directory.ContainsKey(city))
            {
                directory.Add(city, new SortedDictionary<string, SortedSet<string>>());
            }
            if (!directory[city].ContainsKey(venue))
            {
                directory[city].Add(venue, new SortedSet<string>());
            }
            directory[city][venue].Add(performer);
        }
        foreach (var city in directory.Keys)
        {
            Console.WriteLine(city);
            foreach (var venue in directory[city].Keys)
            {
                Console.Write("-> " + venue + ": ");
                Console.Write(string.Join(", ", directory[city][venue]));
                Console.WriteLine();
            }
        }
    }
}
