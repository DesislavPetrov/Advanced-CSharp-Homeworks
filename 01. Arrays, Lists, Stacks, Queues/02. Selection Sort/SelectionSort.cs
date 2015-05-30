
using System;


class SelectionSort
{
    public static void Main(string[] args)
    {
        string[] numbers = Console.ReadLine().Split();
        int[] sortedNums = new int[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            sortedNums[i] = int.Parse(numbers[i]);
        }

        for (int k = 0; k < sortedNums.Length; k++)
        {
            for (int j = k + 1; j < sortedNums.Length; j++)
            {
                if (sortedNums[j] < sortedNums[k])
                {
                    int temp = sortedNums[j];
                    sortedNums[j] = sortedNums[k];
                    sortedNums[k] = temp;
                }
            }
        }
        Console.WriteLine(string.Join(" ", sortedNums));
    }
}
