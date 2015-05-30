using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace LettersChangeNumbers_07
{
    class Program
    {
        public static void Main(string[] args)
        {
            double sum = 0;

            string[] str = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var s in str)
            {
                double number = double.Parse(s.Substring(1, s.Length - 2));
                if (Char.IsUpper(s[0]))
                {
                    number /= GetAlphabetPos(s[0]);
                }
                else
                {
                    number *= GetAlphabetPos(s[0]);
                }
                if (Char.IsUpper(s[s.Length - 1]))
                {
                    number -= GetAlphabetPos(s[s.Length - 1]);
                }
                else
                {
                    number += GetAlphabetPos(s[s.Length - 1]);
                }
                sum += number;
            }
            Console.WriteLine("{0:F2}", sum);
        }
        static int GetAlphabetPos(char ch)
        {
            if (Char.IsUpper(ch))
            {
                return (int)ch - 'A' + 1;
            }
            else
            {
                return (int)ch - 'a' + 1;
            }
        }
    }
}