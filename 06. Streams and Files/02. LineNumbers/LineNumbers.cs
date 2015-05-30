
using System;
using System.IO;


class LineNumbers
{
    public static void Main(string[] args)
    {
        string inputFile = "input.txt";
        string outputFile = "output.txt";
        StreamReader inputStream = new StreamReader(inputFile);
        StreamWriter outputStream = new StreamWriter(outputFile);

        using (inputStream)
        {
            using (inputStream)
            {
                int lineNumber = 0;
                string line = inputStream.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    Console.WriteLine("{0} {1}", lineNumber, line);
                    line = inputStream.ReadLine();
                }
            }
        }
        Console.ReadKey(true);
    }
}