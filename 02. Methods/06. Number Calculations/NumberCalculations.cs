
using System;


class NumberCalculations
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter double values");
        double[] doubleNums = new double[n];
        for (int i = 0; i < n; i++)
        {
            doubleNums[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter integer values");
        int[] intNums = new int[n];
        for (int i = 0; i < n; i++)
        {
            intNums[i] = int.Parse(Console.ReadLine());
        }

        // print the results
        Console.WriteLine("min (double) is {0}", CalculateMin(doubleNums));
        Console.WriteLine("min (int) is {0}", CalculateMin(intNums));
        Console.WriteLine("max (double) is {0}", CalculateMax(doubleNums));
        Console.WriteLine("max (int) is {0}", CalculateMax(intNums));
        Console.WriteLine("sum (double) is {0}", CalculateSum(doubleNums));
        Console.WriteLine("sum (int) is {0}", CalculateSum(intNums));
        Console.WriteLine("average (double) is {0}", CalculateAverage(doubleNums));
        Console.WriteLine("average (int) is {0}", CalculateAverage(intNums));
        Console.WriteLine("product (double) is {0}", CalculateProduct(doubleNums));
        Console.WriteLine("product (int) is {0}", CalculateProduct(intNums));
    }


    // calculate double min value
    static double CalculateMin(double[] nums)
    {
        double min = double.MaxValue;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < min)
            {
                min = nums[i];
            }
        }
        return min;
    }

    // calculate int min value
    static int CalculateMin(int[] nums)
    {
        int min = int.MaxValue;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < min)
            {
                min = nums[i];
            }
        }
        return min;
    }

    // calculate int max value
    static double CalculateMax(double[] nums)
    {
        double max = double.MinValue;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > max)
            {
                max = nums[i];
            }
        }
        return max;
    }

    // calculate int max value
    static int CalculateMax(int[] nums)
    {
        int max = int.MinValue;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > max)
            {
                max = nums[i];
            }
        }
        return max;
    }

    // calculate double average
    static double CalculateAverage(double[] nums)
    {
        double average = 1;
        average = CalculateSum(nums) / nums.Length;
        return average;
    }

    // calculate int average
    static int CalculateAverage(int[] nums)
    {
        int average = 1;
        average = CalculateSum(nums) / nums.Length;
        return average;
    }

    // calculate double sum
    static double CalculateSum(double[] nums)
    {
        double counter = 0;
        double sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            counter++;
        }
        return sum;
    }

    // calculate int sum
    static int CalculateSum(int[] nums)
    {
        int counter = 0;
        int sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            counter++;
        }
        return sum;
    }

    // calculate double product
    static double CalculateProduct(double[] nums)
    {
        double product = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            product *= nums[i];
        }
        return product;
    }

    // calculate int product
    static int CalculateProduct(int[] nums)
    {
        int product = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            product *= nums[i];
        }
        return product;
    }
}