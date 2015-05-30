using System;
using System.Text.RegularExpressions;

class SentenceExtractor
{
    static void Main(string[] args)
    {
        string keyword = "\\b" + Console.ReadLine() +"\\b";
        string text = Console.ReadLine();

        string pattern = @"([A-Z][^\.!?]*[\.!?])";
        Regex reg = new Regex(pattern);
        MatchCollection matches = reg.Matches(text);

        foreach (Match item in matches)
        {
            foreach (Capture capture in item.Captures)
            {
                string currentSentence = capture.Value;
                Match matchWordInSentence = Regex.Match(capture.Value, keyword, RegexOptions.IgnoreCase);
                if (matchWordInSentence.Success)
                {
                    Console.WriteLine(currentSentence);
                }
            }
        }
    }
}