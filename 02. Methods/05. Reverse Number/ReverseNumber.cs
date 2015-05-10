
using System;

namespace Reverse_Number_05
{
    class Program
    {
        public static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());

            Console.WriteLine(GetReversedNumber(num));
        }

        static double GetReversedNumber(double num)
        {
            string inputNumber = num.ToString();
            char[] reversedChars = inputNumber.ToCharArray();
            Array.Reverse(reversedChars);
            string reversedString = new string(reversedChars);
            double doubleRevNum = double.Parse(reversedString);
            return doubleRevNum;
        }
    }
}