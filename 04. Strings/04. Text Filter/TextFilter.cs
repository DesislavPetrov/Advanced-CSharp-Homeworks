
using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;


class TextFilter
{
    public static void Main(string[] args)
    {
        char[] separators = {',', ' '};
        string[] bannedWords = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
        string text = Console.ReadLine();
        StringBuilder newText = new StringBuilder(text);
        for (int i = 0; i < bannedWords.Length; i++)
        {
            newText.Replace(bannedWords[i], new string('*', bannedWords[i].Length)); // here we change the letters of 
            // the banned word with asterisks, the number of which is equal to the length of the word
        }

        Console.WriteLine(newText);
    }
}