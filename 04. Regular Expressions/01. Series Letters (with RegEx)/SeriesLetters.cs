using System;
using System.Text.RegularExpressions;


class SeriesLetters
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine().Trim();
        input = RemoveDuplicaChars(input);
        Console.WriteLine(input);
    }

    private static string RemoveDuplicaChars(string input)
    {
        string pattern = @"(\w)\1";
        Regex reg = new Regex(pattern);
        Match match = reg.Match(input);

        while (match.Success)
        {
            input = input.Replace(match.ToString(), match.ToString()[0].ToString());
            match = reg.Match(input);
        }
        return input;
    }
}
