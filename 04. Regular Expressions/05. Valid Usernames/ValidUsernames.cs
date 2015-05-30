
using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;


class ValidUsernames
{
    public static void Main(string[] args)
    {

        string input = Console.ReadLine();
        string validation = @"\b[a-zA-Z]\w{3,25}\b";
        Regex reg = new Regex(validation);
        MatchCollection matchColl = reg.Matches(input);

        int max = int.MinValue;
        int initIndex = 0;
        int secIndex = 1;
        for (int i = 0; i < matchColl.Count-1; i ++)
        {
            int tempMax = matchColl[i].Length + matchColl[i + 1].Length;
            if (tempMax > max)
            {
                max = tempMax;
                initIndex = i;
                secIndex = i + 1;
            }
        }

        Console.WriteLine(matchColl[initIndex]);
        Console.WriteLine(matchColl[secIndex]);
    }
}