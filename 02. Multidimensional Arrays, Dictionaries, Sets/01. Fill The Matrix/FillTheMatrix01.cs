
using System;


class FillTheMatrix01
{
    public static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int[,] matrix = new int[size, size];
        int temp = 1; // we create a temporary integer that will help for the solution

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                matrix[i, j] = temp + j * 4;
            }
            temp++;
        }

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write("{0,-4}", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}