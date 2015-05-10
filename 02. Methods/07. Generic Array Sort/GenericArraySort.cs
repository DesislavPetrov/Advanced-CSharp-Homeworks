
using System;
using System.Collections.Generic;
using System.Linq;

class GenericArraySort
{
    public static void Main()
    {
        int[] nums = { 1, 3, 4, 5, 1, 0, 5 };
        string[] strings = { "zaz", "cba", "baa", "azis" };
        DateTime[] dates =
        {
            new DateTime(2002, 3, 1), new DateTime(2015, 5, 6), new DateTime(2014, 1, 1),
        };

        Console.WriteLine(SelectionSort(nums));
        Console.WriteLine(SelectionSort(strings));
        Console.WriteLine(SelectionSort(dates));
    }

    static string SelectionSort<T>(IEnumerable<T> array)
    {
        List<T> sortedList = array.ToList();

        for (int i = 0; i < sortedList.Count; i++)
        {
            for (int j = i + 1; j < sortedList.Count; j++)
            {
                var result = Comparer<T>.Default.Compare(sortedList[i], sortedList[j]);
                if (result >= 0)
                { // check if sortedList[i] >= sortedList[j]
                    var temp = sortedList[i];
                    sortedList[i] = sortedList[j];
                    sortedList[j] = temp;
                }
            }
        }

        return String.Join(", ", sortedList);
    }
}