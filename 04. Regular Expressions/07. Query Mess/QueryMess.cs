using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


class QueryMess
{
    static void Main(string[] args)
    {
        string input;

        string spacesPattern = "\\s{2,}"; // here we'll match multiple whitespaces
        Regex spacesReg = new Regex(spacesPattern);

        string wordsPattern = "([^=&]+)=([^&=]+)"; // here we'll match all key/value pairs
        Regex wordsReg = new Regex(wordsPattern);

        Dictionary<string, List<string>> registration = new Dictionary<string, List<string>>();
        MatchCollection matches;

        while (!((input = Console.ReadLine()) == "END"))
        {
            input = input.Replace("%20", " ").Replace("+", " ").Replace("?", "&");
            input = spacesReg.Replace(input, " "); // here we reduce multiple whitespace characters to one inside value/key names
            matches = wordsReg.Matches(input);
            foreach (Match match in matches)
            {
                string keyString = match.Groups[1].ToString().Trim();
                string valueString = match.Groups[2].ToString().Trim();
                if (!registration.ContainsKey(keyString))
                {
                    registration.Add(keyString, new List<string>());
                }
                registration[keyString].Add(valueString);
            }
            foreach (string keyString in registration.Keys)
            {
                Console.Write("{0}=[{1}]", keyString, string.Join(", ", registration[keyString]));
            }
            Console.WriteLine();
            registration.Clear();
        }
    }
}
