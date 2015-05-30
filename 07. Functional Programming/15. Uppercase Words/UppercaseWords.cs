using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;
using System.Security;


class UppercaseWords
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string pattern = @"(?<![a-zA-Z])[A-Z]+(?![a-zA-Z])";

        while (input != "END")
        {
            Regex reg = new Regex(pattern);
            MatchCollection matches = reg.Matches(input);

            int offset = 0; // this will count the offset indexes after we replace uppercase palindrome
            foreach (Match match in matches)
            {
                string word = match.Value;
                string reversed = Reverse(word);

                if (reversed == word) // here we check if the uppercase word is a palindrome
                {
                    reversed = DoubleEachLetter(reversed);
                }

                int index = match.Index; // it returns the index of the matched value
                input = input.Remove(index + offset, word.Length);
                input = input.Insert(index + offset, reversed);
                offset += reversed.Length - word.Length;
            }

            Console.WriteLine(SecurityElement.Escape(input));
            input = Console.ReadLine();
        }
        
    }

    private static string DoubleEachLetter(string reversed)
    {
        StringBuilder doubled = new StringBuilder();
        for (int i = reversed.Length - 1; i >= 0; i--)
        {
            doubled.Append(new string(reversed[i], 2));
        }
        return doubled.ToString();
    }

    private static string Reverse(string str)
    {
        StringBuilder reversed = new StringBuilder();
        for (int i = str.Length-1; i >= 0; i--)
        {
            reversed.Append(str[i]);
        }
        return reversed.ToString();
    }
}