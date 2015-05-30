
using System;
using System.Linq;

class SortNumbersArray
{
    public static void Main()
    {
        string[] numbers = Console.ReadLine().Split();
        int[] sortedNums = new int[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            sortedNums[i] = int.Parse(numbers[i]);
        }
        Array.Sort(sortedNums);
        Console.WriteLine(string.Join(" ", sortedNums));
    }
}
