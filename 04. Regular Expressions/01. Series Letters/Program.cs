using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SeriesLetters
{
    static void Main()
    {
        List <char> input = Console.ReadLine().ToCharArray().ToList();
        for (int i = 1; i < input.Count(); i++)
        {
            if (input[i] == input[i-1])
            {
                input.RemoveAt(i);
                i--;
            }
        }

        for (int i = 0; i < input.Count(); i++)
        {
            Console.Write(input[i]);
        }
        Console.WriteLine();
    }
}