using System;
using System.Text.RegularExpressions;
using System.Text;
using System.Linq;
using System.IO;

public class Example
{
    public static void Main()
    {
        // here we'll put a bit of code, that will help the console to show all text, because without this bit of code, the text in the console is cut
        Console.SetIn(new StreamReader(Console.OpenStandardInput(8192)));

        // here we'll enter the input data
        string input = Console.ReadLine();

        // here we'll search in the input text for all text that is between <p> and </p> tags
        string pattern = @"<p>(.*?)<\/p>";
        Regex regex = new Regex(pattern);
        Match match = regex.Match(input);

        // here we'll create a StringBuilder, which we'll fill with the output text
        StringBuilder output = new StringBuilder();


        while (match.Success)
        {
            string currString = match.Groups[1].ToString();
            string newString = currString;

            // here we'll replace all characters which are not small letters and numbers with a space " ". 
            foreach (char item in currString)
            {
                if ((item >= 'a' && item <= 'z') || (item >= '0' && item <= '9'))
                {
                    continue;
                }
                else
                {
                    newString = newString.Replace(item, ' ');
                }
            }

            // here we'll replace all multiple spaces with just one space
            string spacesPattern = @"\s+";
            newString = Regex.Replace(newString, spacesPattern, " ");

            // here we'll convert all lettersfrom a to m to letters from n to z and vice versa

            foreach (char item in newString)
            {
                if (item >= 'a' && item <= 'm')
                {
                    output.Append((char)(item + 13));
                }
                else if (item >= 'n' && item <= 'z')
                {
                    output.Append((char)(item - 13));
                }
                else
                {
                    output.Append(item);
                }
            }
            match = match.NextMatch();
        }
        Console.WriteLine(output.ToString());
    }
}