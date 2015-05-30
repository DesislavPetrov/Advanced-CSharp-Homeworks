
using System;
using System.Linq;

class MaximalSum
{
    public static void Main()
    {
        int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int rows = size[0];
        int cols = size[1];

        // here we'll fill the matrix		
        int[,] matrix = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = input[j];
            }
        }

        int tempSum = 0; // it will hold the sum of the current matrix with size 3X3
        int maxSum = 0; // it will hold the maximum sum of the matrices with size 3X3

        // the following two variables will help for printing the matrix with maximum size
        int startBestRow = 0;
        int startBestCol = 0;

        for (int i = 0; i < rows - 2; i++)
        {
            for (int j = 0; j < cols - 2; j++)
            {
                tempSum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2]
                    + matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2]
                    + matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];
                if (tempSum > maxSum)
                {
                    maxSum = tempSum;
                    startBestRow = i;
                    startBestCol = j;
                }
            }
        }

        // here we print the initial matrix
        //			for (int i = 0; i < rows; i++) {
        //				for (int j = 0; j < cols; j++) {
        //					Console.Write("{0,-4}", matrix[i,j]);
        //				}
        //				Console.WriteLine();
        //			}


        // here we print the output matrix with size 3X3
        Console.WriteLine("Sum = {0}", maxSum);
        for (int i = startBestRow; i < startBestRow + 3; i++)
        {
            for (int j = startBestCol; j < startBestRow + 3; j++)
            {
                Console.Write("{0,-4}", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}