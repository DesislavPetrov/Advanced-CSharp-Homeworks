using System;
using System.Text.RegularExpressions;
using System.Text;
using System.Security;


class TextGravity
{
    public static void Main(string[] args)
    {
        // here we'll define the count of rows and columns
        int cols = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        int rows = (int)Math.Ceiling((double)input.Length / cols);

        // here we'll fill the matrix with chars
        int charIndex = -1;
        char[,] matrix = new char[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                charIndex++;
                if (charIndex > input.Length - 1)
                {
                    matrix[i, j] = ' ';
                }
                else
                {
                    matrix[i, j] = input[charIndex];
                }
            }
        }

        // here we'll make movements
        for (int i = rows - 1; i > 0; i--)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] == ' ' && matrix[i - 1, j] != ' ')
                {
                    matrix[i, j] = matrix[i - 1, j];
                    matrix[i - 1, j] = ' ';
                }
                else if (matrix[i, j] == ' ' && matrix[i - 1, j] == ' ')
                {
                    int currentRow = i;
                    while (matrix[currentRow, j] == ' ' && currentRow >= 0)
                    {
                        currentRow--;
                        if (currentRow < 0)
                        {
                            currentRow++;
                            break;
                        }
                    }
                    matrix[i, j] = matrix[currentRow, j];
                    matrix[currentRow, j] = ' ';
                }
            }

        }

        // print just the matrix without HTML tags
        //for (int i = 0; i < rows; i++)
        //{
        //    for (int j = 0; j < cols; j++)
        //    {
        //        Console.Write(matrix[i, j]);
        //    }
        //    Console.WriteLine();
        //}

        Console.Write("<table>");
        for (int i = 0; i < rows; i++)
        {
            Console.Write("<tr>");
            for (int j = 0; j < cols; j++)
            {
                Console.Write("<td>{0}</td>", SecurityElement.Escape(matrix[i, j].ToString()));
            }
            Console.Write("</tr>");
        }
        Console.Write("</table>");
    }
}
