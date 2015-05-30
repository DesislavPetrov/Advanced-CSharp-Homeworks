
using System;
using System.Text.RegularExpressions;


class MatrixShuffling
{
    public static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());

        string[,] matrix = new string[rows, cols];

        // here we'll fill the matrix
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = Console.ReadLine();
            }
        }

        // here we'll print the initial version of the matrix
        //for (int i = 0; i < rows; i++)
        //{
        //    for (int j = 0; j < cols; j++)
        //    {
        //        Console.Write("{0} ", matrix[i, j]);
        //    }
        //    Console.WriteLine();
        //}

        int x1 = 0;
        int y1 = 0;
        int x2 = 0;
        int y2 = 0;

        string commandLine = Console.ReadLine();
        while (commandLine != "END")
        {
            if ((commandLine.StartsWith("swap") || commandLine == "END")) // here we check the input data for strings
            {
                string[] input = commandLine.Split();
                if (input.Length == 5)
                { // here we check if the command have five elements
                    string command = input[0];
                    x1 = int.Parse(input[1]);
                    y1 = int.Parse(input[2]);
                    x2 = int.Parse(input[3]);
                    y2 = int.Parse(input[4]);

                    if (x1 >= 0 && x1 < rows && y1 >= 0 && y1 < cols
                    && x2 >= 0 && x2 < rows && y2 >= 0 && y2 < cols) // here we check for 
                    {
                        string temp = "";
                        temp = matrix[x1, y1];
                        matrix[x1, y1] = matrix[x2, y2];
                        matrix[x2, y2] = temp;

                        for (int i = 0; i < rows; i++)
                        {
                            for (int j = 0; j < cols; j++)
                            {
                                Console.Write("{0} ", matrix[i, j]);
                            }
                            Console.WriteLine();
                        }

                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
            commandLine = Console.ReadLine();
        }
    }
}