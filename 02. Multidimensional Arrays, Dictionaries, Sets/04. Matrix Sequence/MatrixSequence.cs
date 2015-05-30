using System;

class MatrixSequence
{

    static void Main()
    {
        // On the first two lines we'll enter the size of the matrix
        int numberOfRows = int.Parse(Console.ReadLine());
        int numberOfCols = int.Parse(Console.ReadLine());

        string[,] matrix = new string[numberOfRows, numberOfCols];
        int count = 1;
        int maxSecq = 1;
        string maxValue = "";

        // here we'fill the matrix
        for (int row = 0; row < numberOfRows; row++)
        {
            for (int col = 0; col < numberOfCols; col++)
            {
                matrix[row, col] = Console.ReadLine();
            }
        }

        // print the matrix
        for (int row = 0; row < numberOfRows; row++)
        {
            for (int col = 0; col < numberOfCols; col++)
            {
                Console.Write("{0,4} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();


        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)     //Searching horizontally
            {
                if ((matrix[row, col] == matrix[row, col + 1]))
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (count > maxSecq)
                {
                    maxSecq = count;
                    maxValue = matrix[row, col];
                }
            }
            count = 1;
        }


        for (int col = 0; col < matrix.GetLength(1); col++)                 //Searching vertically
        {
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                if ((matrix[row, col] == matrix[row + 1, col]))
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (count > maxSecq)
                {
                    maxSecq = count;
                    maxValue = matrix[row, col];
                }
            }
            count = 1;
        }


        //Searching diagonally from left to right
        for (int row = 0, col = 0; row < matrix.GetLength(0) - 1 && col < matrix.GetLength(1) - 1; row++, col++)
        {
            if ((matrix[row, col] == matrix[row + 1, col + 1]))
            {
                count++;
            }
            else
            {
                count = 1;
            }
            if (count > maxSecq)
            {
                maxSecq = count;
                maxValue = matrix[row, col];
            }
        }
        count = 1;


        //Searching diagonally from right to left
        for (int row = 0, col = 0; row < matrix.GetLength(0) - 1 && col > 0; row++, col--)
        {
            if ((matrix[row, col] == matrix[row + 1, col + 1]))
            {
                count++;
            }
            else
            {
                count = 1;
            }
            if (count > maxSecq)
            {
                maxSecq = count;
                maxValue = matrix[row, col];
            }
        }

        // printing the result:
        for (int i = 0; i < maxSecq; i++)
        {
            if (i < maxSecq - 1)
            {
                Console.Write("{0}, ", maxValue);
            }
            else
            {
                Console.Write("{0}", maxValue);
            }

        }
        Console.WriteLine();
    }
}
