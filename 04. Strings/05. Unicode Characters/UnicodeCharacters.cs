
using System;
using System.Collections.Generic;
using System.Linq;


class UnicodeCharacters
{
    public static void Main(string[] args)
    {
        string text = Console.ReadLine();
        foreach (char c in text)
        {
            Console.Write("\\u{0:x4}", (int)c);
        }
        Console.WriteLine();
    }
}