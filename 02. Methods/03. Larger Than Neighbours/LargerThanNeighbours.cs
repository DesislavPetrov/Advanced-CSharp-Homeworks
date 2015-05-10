using System;



class LargerThanNeighbours
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int [] numbers = new int[num];

        // fill the array
        for (int i = 0; i < num; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        // check the condition
        for (int j = 0; j < numbers.Length; j++)
        {
            Console.WriteLine(IsLargerThanNeighbours(numbers, j));
        }


    }

    static bool  IsLargerThanNeighbours(int[] numbers, int i)
    {
        if (i > 0 && i < numbers.Length-1 && numbers[i] > numbers[i-1] && numbers[i] > numbers[i+1])
        {
            return true;
        }
        else if (i == 0 && numbers[i] > numbers[i+1])
        {
            return true;
        }
        else if (i == numbers.Length-1 && numbers[i] > numbers[i-1])
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
