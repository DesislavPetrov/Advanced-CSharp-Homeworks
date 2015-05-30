using System;

public class TerroristsWin
{
    public static void Main()
    {
        char[] field = Console.ReadLine().ToCharArray();

        int startIndex = Array.IndexOf(field, '|');

        while (startIndex != -1)
        {
            int endIndex = Array.IndexOf(field, '|', startIndex + 1);
            int power = GetAsciiSum(startIndex, endIndex, field) % 10;

            // here we define the borders of the bomb
            int startIndexToExplode = Math.Max(0, startIndex - power);
            int endIndexToExplode = Math.Min(endIndex + power, field.Length - 1);

            ExplodeBomb(startIndexToExplode, endIndexToExplode, field);

            // here we continue to search for the next bomb (if it is available)
            startIndex = Array.IndexOf(field, '|', endIndex + 1);
        }

        Console.WriteLine(new string(field));
    }

    private static void ExplodeBomb(int startIndex, int endIndex, char[] field)
    {
        for (int i = startIndex; i <= endIndex; i++)
        {
            field[i] = '.';
        }
    }

    private static int GetAsciiSum(int startIndex, int endIndex, char[] field)
    {
        int sum = 0;

        for (int i = startIndex + 1; i < endIndex; i++)
        {
            sum += field[i];
        }

        return sum;
    }
}