using System;
using System.Collections.Generic;
using System.Linq;



    class PythagoreanNumbers
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            int[] input = new int[num];
            for (int i = 0; i < num; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
            }

            int counter = 0;
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    for (int k = 0; k < num; k++)
                    {
                        if (input[i] <= input[j] &&
                            (input[i]) * (input[i]) + (input[j]) * (input[j]) ==
                            (input[k]) * (input[k]))
                        {
                            Console.WriteLine("" + input[i] + "*" + (input[i]) + " + "
                                + (input[j]) + "*" + (input[j]) + " = " + 
                            input[k] + "*" + input[k]);
                            counter++;
                        }
                    }
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
