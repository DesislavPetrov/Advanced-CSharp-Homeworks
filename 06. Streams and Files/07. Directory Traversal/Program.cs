
using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;


class DirectoryTraversal
{
    public static void Main(string[] args)
    {
        string directoryPath = @"../../DirectoryFolder";
        System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(directoryPath);
        System.IO.FileInfo[] fileNames = di.GetFiles();

        // here we'll sort files accordint to the conditions
        var sorted = fileNames.OrderBy(file => file.Length).GroupBy(file => file.Extension).OrderByDescending(group => group.Count()).ThenBy(group => group.Key);

        // here we'll find the desktop
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        // here we'll create report file
        StreamWriter writer = new StreamWriter(desktopPath + "/report.txt");
        foreach (var group in sorted)
        {
            writer.WriteLine(group.Key);
            foreach (var item in group)
            {
                writer.WriteLine("--{0} - {1:F3}kb", item.Name, item.Length / 1024.0);
            }
        }

        writer.Close();

        // open report file
        System.Diagnostics.Process.Start(desktopPath + "/report.txt");
    }
}