
using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class ExtractEmails
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string pattern = "[a-z]+[a-z\\d-_.]*@[a-z-.]*";
        Regex reg = new Regex(pattern);
        MatchCollection matches = reg.Matches(input);
        foreach (var element in matches)
        {
            string result = element.ToString();
            if (result[result.Length-1] == '.')
            {
                int lastIndex = result.LastIndexOf('.');
                result = result.Remove(lastIndex, 1);
            }
            Console.WriteLine(result);
        }
    }
}