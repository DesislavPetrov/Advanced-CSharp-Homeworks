using System;


class Disc
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int radius = int.Parse(Console.ReadLine());

        char dot = '.';
        char asterisk = '*';

        int startRow = n / 2 - radius;
        int endRow = n / 2 + radius;


        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int deltaX = (n / 2 - i);
                int deltaY = (n / 2 - j);
                double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
                if (distance <= radius)
                {
                    Console.Write(asterisk);
                }
                else
                {
                    Console.Write(dot);
                }
            }
            Console.WriteLine();
        }
    }
}
