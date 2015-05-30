
using System;


class StringLength
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();

        if (input.Length > 20) // here we check if the string have more than 20 characters
        {
            string substringed = input.Substring(0, 20); // the 20th char is not included
            Console.WriteLine(substringed);
        }
        else
        {
            Console.WriteLine(input + new string('*', 20 - input.Length));
        }
    }
}