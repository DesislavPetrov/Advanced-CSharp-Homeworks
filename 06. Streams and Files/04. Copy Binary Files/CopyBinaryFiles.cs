
using System;
using System.IO;


class CopyBinaryFiles
{
    public static void Main(string[] args)
    {
        string inputFile = "logo.jpg";
        string outputFile = "copiedLogo.jpg";
        FileStream input = new FileStream(inputFile, FileMode.Open);
        FileStream output = new FileStream(outputFile, FileMode.Create);
        try
        {
            byte[] buffer = new byte[4096];
            while (true)
            {
                int readBytes = input.Read(buffer, 0, buffer.Length);
                if (readBytes == 0)
                {
                    break;
                }
                output.Write(buffer, 0, buffer.Length);
            }
        }
        finally
        {
            input.Close();
            output.Close();
        }
        Console.ReadKey(true);
    }
}