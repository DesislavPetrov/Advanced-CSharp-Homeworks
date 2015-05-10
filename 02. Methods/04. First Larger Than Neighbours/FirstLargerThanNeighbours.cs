
using System;


class FirstLargerThanNeighbours
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine(GetFirstLargerNumber(array));

        Console.ReadKey(true);
    }

    static int GetFirstLargerNumber(int[] array)
    {
        bool isLarger = false;
        int firstLargerNum = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (i == 0 && array[i] > array[i + 1])
            {
                isLarger = true;
                firstLargerNum = array[i];
            }
            else if (i == array.Length - 1 && array[i] > array[i - 1])
            {
                isLarger = true;
                firstLargerNum = array[i];
            }
            else if (i > 0 && i < array.Length - 1 && array[i] > array[i + 1] && array[i] > array[i - 1])
            {
                isLarger = true;
                firstLargerNum = array[i];
            }
            if (isLarger == true)
            {
                break;
            }
        }
        return firstLargerNum;
    }
}