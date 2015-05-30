
using System;
using System.Text.RegularExpressions;
using System.Text;


class ReplaceATag
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string pattern = @"<a\s*href=(\w+:\/{2}[\w\.]+)>(\w+)<\/a>";
        string replace = @"[URL href=$1]$2[/URL]";

        StringBuilder builder = new StringBuilder();
        while (input != string.Empty)
        {
            builder = builder.AppendLine(input);
            input = Console.ReadLine();
        }
        string output = builder.ToString();
        output = Regex.Replace(output, pattern, replace);

        Console.WriteLine(output);
    }
}