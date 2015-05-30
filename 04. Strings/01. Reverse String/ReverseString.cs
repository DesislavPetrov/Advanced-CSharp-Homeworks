
using System;
using System.Text;
using System.Linq;


class ReverseString
{
    public static void Main()
    {
        string input = Console.ReadLine();
        string reversed = new string(input.ToCharArray().Reverse().ToArray());
        Console.WriteLine(reversed);
    }
}