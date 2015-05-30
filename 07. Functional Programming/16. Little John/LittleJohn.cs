
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using System.Linq;


class LittleJohn
{
    public static void Main(string[] args)
    {

        string pattern = @"(>>>----->>)|(>>----->)|(>----->)";
        Regex arrowMatcher = new Regex(pattern);

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < 4; i++)
        {
            sb.AppendFormat(" {0}", Console.ReadLine());
        }

        var arrows = arrowMatcher.Matches(sb.ToString());

        int smallCount = 0;
        int mediumCount = 0;
        int largeCount = 0;

        foreach (Match arrow in arrows)
        {
            if (!string.IsNullOrEmpty(arrow.Groups[1].Value))
            {
                largeCount++;
            }
            else if (!string.IsNullOrEmpty(arrow.Groups[2].Value))
	        {
		            mediumCount++;
	        }
            else
            {
                smallCount++;
            }
        }

        long counts = long.Parse("" + smallCount + mediumCount + largeCount);

        string binary = Convert.ToString(counts, 2);
        char[] charArray = binary.ToCharArray();
        Array.Reverse(charArray);
        string reversed = new string(charArray);
        string merged = binary + reversed;


        long result = Convert.ToInt64(merged, 2);
        Console.WriteLine(result);
    }
}