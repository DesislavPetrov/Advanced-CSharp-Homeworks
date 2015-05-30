using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _17.Office_Stuff
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string pattern = @"([a-zA-Z\d]+) - ([0-9]+) - ([a-zA-Z\d]+)";
            SortedDictionary<string, Dictionary<string, int>> dictionary = new SortedDictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < number; i++)
            {
                string[] input = Regex.Split(Console.ReadLine(), pattern);
                string name = input[1];
                int amount = int.Parse(input[2]);
                string product = input[3];

                
                if (!dictionary.ContainsKey(name))
                {
                    dictionary.Add(name, new Dictionary<string,int>());
                }
                Dictionary<string, int> productInfo = dictionary[name];
                int oldAmount = 0;
                if (productInfo.ContainsKey(product))
                {
                    oldAmount = productInfo[product];
                }
                productInfo[product] = oldAmount + amount;

            }

            // Here we'll print the results
            int counter = 0; // this var will count the number of values in the inner SortedDictionary
            foreach (var pair in dictionary)
            {
                Console.Write("{0}: ", pair.Key.ToString().Replace("0", ""));
                foreach (var innerPair in pair.Value)
                {
                    Console.Write("{0}-{1}", innerPair.Key, innerPair.Value);
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
}


