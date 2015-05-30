using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;


class Phonebook
{
    public static void Main()
    {
        string command = Console.ReadLine();
        string patternName = @"([a-zA-z]+[\(]*[\)]*[/)]*)+"; // search for name in the input data
        string patternNumber = "([\\d]+[\\W]?)+"; // search for phone numbers in the input data

        string name = "";
        string phoneNumber = "";

        Dictionary<string, List<string>> phonebook = new Dictionary<string, List<string>>();


        while (command != "search")
        {
            Regex regName = new Regex(patternName);
            Match matchName = regName.Match(command);

            Regex regNumber = new Regex(patternNumber);
            Match matchNumber = regNumber.Match(command);

            name = matchName.Value;
            phoneNumber = matchNumber.Value;

            if (!phonebook.ContainsKey(name))
            { // here we check if we already have recorded phone number for this name
                phonebook.Add(name, new List<string>());
            }
            phonebook[name].Add(phoneNumber); // here we add the phone number to the list for this name
            command = Console.ReadLine();
        }

        while (command != "")
        {
            if (phonebook.ContainsKey(command))
            {
                Console.WriteLine("{0} -> {1}", command, string.Join(", ", phonebook[command]));
            }
            else if (command != "search")
            {
                Console.WriteLine("Contact {0} does not exist.", command);
            }
            command = Console.ReadLine();
        }
    }
}