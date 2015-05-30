using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ActivityTracker
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        SortedDictionary<string, SortedDictionary<string, int>> monthInfo = new SortedDictionary<string, SortedDictionary<string, int>>();
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            string date = input[0];
            string[] months = date.Split('/');
            string month = months[1];
            string user = input[1];
            int distance = int.Parse(input[2]);

            // here we'll put a key to the outer SortedDictionary
            if (!monthInfo.ContainsKey(month))
            {
                monthInfo.Add(month, new SortedDictionary<string,int>());
            }

            // here we'll create the inner SortedDictionary and connect it to the outer SortedDictionary
            SortedDictionary<string, int> userInfo = monthInfo[month];

            int oldDistance = 0;

            if (userInfo.ContainsKey(user))
            {
                  
                oldDistance = userInfo[user];
            }

            userInfo[user] = oldDistance + distance;
        }

        int counter = 0; // this var will count the number of values in the inner SortedDictionary
        foreach (var pair in monthInfo)
        {
            Console.Write("{0}: ", pair.Key.ToString().Replace("0", ""));
            foreach (var innerPair in pair.Value)
            {
                Console.Write("{0}({1})", innerPair.Key, innerPair.Value);
                counter++;
                if (counter < pair.Value.Count)
                {
                    Console.Write(", ");
                }
            }
            counter = 0;
            Console.WriteLine();
        }

           

    }
}