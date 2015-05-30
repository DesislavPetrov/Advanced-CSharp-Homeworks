using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace SemanticHtml
{
    class SemanticHtml
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string openTagPattern = @"<div(.*)(id|class)\s*=\s*""(\w+)""(.*)>";
            string closeTagPattern = @"</div>(\s*<!--\s*(\w+)\s*-->)";
            while (input != "END")
            {
                if (Regex.IsMatch(input, openTagPattern))
                {
                    Match match = Regex.Match(input, @"\s(id|class)\s*=\s*""(\w+)""");
                    string group3 = match.Groups[3].Value.Trim();
                    string tagName = match.Groups[2].Value.Trim();
                    string group1 = match.Groups[1].Value.Trim();
                    string attribute = match.Groups[0].Value;
                    string result = input.Replace("div", tagName);
                    result = result.Replace(attribute, "");
                    result = result.Replace("  ", " ");
                    result = result.Replace(" >", ">");
                    Console.WriteLine(result);
                }
                else if(Regex.IsMatch(input, closeTagPattern))
                {
                    Match match = Regex.Match(input, closeTagPattern);
                    string tagname = match.Groups[2].Value;
                    string comment = match.Groups[1].Value;
                    string result = input.Replace(comment, "");
                    result = result.Replace("div", tagname);
                    Console.WriteLine(result);
                }
                else {
                    Console.WriteLine(input);
                }
                input = Console.ReadLine();
            }
        }
    }
}


