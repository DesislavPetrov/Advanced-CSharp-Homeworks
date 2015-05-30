
using System;
using System.Linq;
using System.Collections.Generic;



class CategorizeNumbers
{
    public static void Main(string[] args)
    {
        string[] numbers = Console.ReadLine().Split();
        float[] floatNums = new float[numbers.Length];

        List<float> floatingPointNums = new List<float>(); // here we'll put all round numbers
        List<int> roundNums = new List<int>(); // here we'll put all floating point numbers with non-zero fraction

        for (int i = 0; i < numbers.Length; i++)
        {
            floatNums[i] = float.Parse(numbers[i]); // here we parse the input data to float
            int intNums = (int)floatNums[i]; // here we parse the float number to int
            if (intNums != floatNums[i]) // here we check if the parsed int is equal to the float number
            {
                floatingPointNums.Add(floatNums[i]);
            }
            else
            {
                roundNums.Add(intNums);
            }
        }

        // here we'll print the round numbers part
        Console.Write("[");
        for (int k = 0; k < floatingPointNums.Count - 1; k++)
        {
            Console.Write("{0}, ", floatingPointNums[k]);
        }
        Console.Write(floatingPointNums[floatingPointNums.Count - 1]);
        Console.Write("] -> ");
        Console.WriteLine("min: {0}, max: {1}, sum: {2}, avg: {3:0.00}", floatingPointNums.Min(), floatingPointNums.Max(),
                        floatingPointNums.Sum(), floatingPointNums.Average());

        // here we'll print the floating point numbers with non-zero fraction part
        Console.Write("[");
        for (int k = 0; k < roundNums.Count - 1; k++)
        {
            Console.Write("{0}, ", roundNums[k]);
        }
        Console.Write(roundNums[roundNums.Count - 1]);
        Console.Write("] -> ");
        Console.WriteLine("min: {0}, max: {1}, sum: {2}, avg: {3:0.00}", roundNums.Min(), roundNums.Max(),
                        roundNums.Sum(), roundNums.Average());

        Console.ReadKey(true);
    }
}