
using System;

class FillTheMatrix02
{
    public static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int[,] matrix = new int[size, size];
        int temp = 1;

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (j % 2 == 0)
                {
                    matrix[i, j] = temp + j * size;
                }
                else
                {
                    matrix[i, j] = (j * size + size + 1) - temp;
                }
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