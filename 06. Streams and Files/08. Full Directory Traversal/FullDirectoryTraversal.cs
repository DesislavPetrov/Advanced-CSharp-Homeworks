
using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;


class FullDirectoryTraversal
{
    public static void Main(string[] args)
    {
        string directoryPath = @"../../";

        string[] filePaths = Directory.GetFiles(directoryPath, "*.*", SearchOption.AllDirectories);

        List<FileInfo> fileNames = filePaths.Select(path => new FileInfo(path)).ToList();

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