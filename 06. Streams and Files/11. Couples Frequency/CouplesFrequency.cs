using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CouplesFrequency
{
    static void Main(string[] args)
    {
        string [] input = Console.ReadLine().Split();
        string[] couples = new string[input.Length - 1];

        for (int i = 0; i < input.Length - 1; i++)
        {
            couples[i] = input[i] + " " + input[i + 1];
        }

        int count = 0;
        Dictionary<string, int> countWords = new Dictionary<string, int>();
        foreach (var item in couples)
        {
            if (!countWords.ContainsKey(item))
            {
                countWords.Add(item, count);    
            }

            int oldCount = countWords[item];
            countWords[item] = oldCount + 1; // here we increase the count of the couple
        }


        foreach (var item in countWords.Keys)
        {
            double percentage = (double)(countWords[item]) / couples.Length * 100;
            Console.WriteLine("{0} -> {1:0.00}%", item, percentage);

        }

    }
}
