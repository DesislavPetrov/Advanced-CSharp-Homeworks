
using System;
using System.IO;


class OddLines
{
    public static void Main(string[] args)
    {
        string file = "oddLines.txt";
        StreamReader inputStream = new StreamReader(file);
        string readLine;

        using (inputStream)
        {
            while ((readLine = inputStream.ReadLine()) != null)
            {
                int lineCounter = 0; // this var will count the number of rows - the count start from 0
                readLine = inputStream.ReadLine();
                if (lineCounter % 2 == 0)
                {
                    Console.WriteLine(readLine);
                }
                lineCounter++;
            }
            Console.ReadKey(true);
        }
    }
}