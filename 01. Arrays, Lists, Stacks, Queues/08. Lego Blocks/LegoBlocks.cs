using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LegoBlocks
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        bool isFit = true;

        char [] separators = {' '};

        int maxFirstCols = int.MinValue;
        int minFirstCols = int.MaxValue;
        int maxSecondCols = int.MinValue;
        int minSecondCols = int.MaxValue;

        int cellsCounter = 0; // this var will hold the number of the cells in both of the jagged arrays

        // fill the first block
        int [][] firstJaggedArray = new int [n][];
            
        for (int i = 0; i < firstJaggedArray.GetLength(0); i++)
        {
            firstJaggedArray[i] = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                
            int tempFirstCols = firstJaggedArray[i].Length;
            if (tempFirstCols > maxFirstCols)
            {
                maxFirstCols = tempFirstCols;
            }
            if (tempFirstCols < minFirstCols)
            {
                minFirstCols = tempFirstCols;
            }

            cellsCounter += firstJaggedArray[i].Length;
        }

        // fill the second block
        int[][] secondJaggedArray = new int[n][];

        for (int i = 0; i < secondJaggedArray.GetLength(0); i++)
        {

            secondJaggedArray[i] = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int tempSecondCols = secondJaggedArray[i].Length;
            if (tempSecondCols > maxSecondCols)
            {
                maxSecondCols = tempSecondCols;
            }
            if (tempSecondCols < minSecondCols)
            {
                minSecondCols = tempSecondCols;
            }

            cellsCounter += secondJaggedArray[i].Length;
        }

        // check for the number of the cols we must to fill
        if (maxFirstCols + minSecondCols == maxSecondCols + minFirstCols)
        {
            // reverse the second block
            for (int i = 0; i < secondJaggedArray.GetLength(0); i++)
            {
                Array.Reverse(secondJaggedArray[i]);
            }

            // check if the two arrays can fit
            for (int i = 0; i < n; i++)
            {
                if (firstJaggedArray[i].Length + secondJaggedArray[i].Length !=
                    maxFirstCols + minSecondCols)
                {
                    isFit = false;
                }
            }
        }
        else
	    {
                isFit = false;
	    }

        // here we'll print according to the results
        if (isFit == true)
        {
            for (int i = 0; i < firstJaggedArray.Length; i++)
            {
                Console.WriteLine("[{0}, {1}]",(string.Join(", ",firstJaggedArray[i])), (string.Join(", ",secondJaggedArray[i])));
            }
        }
        else
        {
            Console.WriteLine("The total number of cells is: {0}", cellsCounter);
        }

            


    }
}