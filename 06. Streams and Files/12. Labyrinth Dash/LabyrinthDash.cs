using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LabyrinthDash
{
    static void Main(string[] args)
    {
        const string ObstacleChars = "*#@";
        int numberOfRows = int.Parse(Console.ReadLine());
        char[][] matrix = new char[numberOfRows][];

        for (int i = 0; i < numberOfRows; i++)
        {
            string input = Console.ReadLine();
            matrix[i] = input.ToCharArray();

        }

        string commands = Console.ReadLine();
        int livesleft = 3;
        int row = 0;
        int col = 0;
        int movesMade = 0;

        foreach (var command in commands)
        {
            int previousRow = row;
            int previousCol = col;
            switch (command)
            {
                case '<':
                    col --;
                    break;
                case '>':
                    col++;
                    break;
                case '^':
                    row--;
                    break;
                case 'v':
                    row++;
                    break;
            }

            if (!IsCellInsideMatrix (row, col, matrix) || matrix[row][col] == ' ') // check if we are in the matrix
            {
                Console.WriteLine("Fell off a cliff! Game Over!");
                movesMade++;
                break;
            }

            else if (matrix[row][col] == '_' || matrix[row][col] == '|') 
            {
                Console.WriteLine("Bumped a wall.");
                row = previousRow;
                col = previousCol;
            }

            else if (ObstacleChars.Contains(matrix[row][col].ToString())) // check for landing on an obstacle 
            {
                livesleft--;
                movesMade++;
                Console.WriteLine("Ouch! That hurt! Lives left: {0}", livesleft);

                if (livesleft <= 0)
                {
                    Console.WriteLine("No lives left! Game Over!");
                    break;
                }
            }

            else if (matrix[row][col] == '$')
            {
                livesleft++;
                movesMade++;
                matrix[row][col] = '.';
                Console.WriteLine("Awesome! Lives left: {0}", livesleft);
            }

            else
            {
                movesMade++;
                Console.WriteLine("Made a move!");
            }
            char currentCell = matrix[row][col];
        }

        Console.WriteLine("Total moves made: {0}", movesMade);
    }

    private static bool IsCellInsideMatrix (int row, int col, char [][] matrix)
    {
        bool isRowInsideMatrix = 0  <= row && row < matrix.Length;
            
        if (!isRowInsideMatrix)
        {
            return false;
        }

        bool isColInRange = 0 <= col && col < matrix[row].Length;

        return isColInRange;
    }
}
