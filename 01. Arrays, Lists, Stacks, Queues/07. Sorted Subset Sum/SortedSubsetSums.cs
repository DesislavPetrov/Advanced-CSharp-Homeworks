using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SortedSubsetSums
{
    static bool solution = false;
    static int[] input;
    static int givenSum;
    static void Main()
    {
        givenSum = int.Parse(Console.ReadLine());
        input = Console.ReadLine().Split().Select(int.Parse).ToArray();

        List<int> subset = new List<int>();
        MakeSubset(0, subset);
        if (!solution) // if no sum matches givenSum
        {
            Console.WriteLine("No matching subsets");
        }
    }

    static void MakeSubset(int index, List<int> subset)
    {
        if (subset.Sum() == givenSum && subset.Count > 0) // if subset sum is equal to the givenSum, print ti to the console
        {
            
            Console.WriteLine("{0} = {1}", string.Join(" + ", subset), givenSum);
            solution = true;
        }

        for (int i = index; i < input.Length; i++)
        {
            subset.Add(input[i]);
            MakeSubset(i + 1, subset); // call MakeSubset method recursively every time starting from the previous index + 1
            subset.RemoveAt(subset.Count - 1);
        }
    }

}
