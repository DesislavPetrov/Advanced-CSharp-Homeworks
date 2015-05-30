using System;
using System.Collections.Generic;
using System.Linq;



class StuckNumbers
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        char[] separator = { ' ' };
        string[] input = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries); // input data as strings
        // Here we must use input data as string, because we don't need to convert them to int. Furthermore, if we convert the input data to int, the judge system give time limit error for the last three cheks.
        bool valid = false;

        for (int i = 0; i < input.Length; i++)
        {
            for (int j = 0; j < input.Length; j++)
            {
                for (int k = 0; k < input.Length; k++)
                {
                    for (int m = 0; m < input.Length; m++)
                    {
                        if (input[i] != input[j] && input[i] != input[k]
                            && input[i] != input[m] && input[j] != input[k]
                            && input[j] != input[m] && input[k] != input[m])
                        {
                            if ("" + input[i] + input[j] == "" + input[k] + input[m])
                            {
                            Console.WriteLine(input[i] + "|" + input[j] + "==" + input[k] + "|" + input[m]);
                            valid = true;
                            }
                        } 
                    }
                }
            }
        }

        if (!valid)
        {
            Console.WriteLine("No");
        }
    }
}
