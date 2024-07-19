

using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

class Task1
{
    static async Task main(string[] args)
    {
        string[] filePaths = { "log1.txt", "log2.txt", "log3.txt" };

        // Ensure directory exists
        string directoryPath = Path.Combine(Directory.GetCurrentDirectory(), "logs");
        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }

        // Prepend directory path to file names
        filePaths = filePaths.Select(fileName => Path.Combine(directoryPath, fileName)).ToArray();

        // Create files to ensure they exist before appending
        foreach (var filePath in filePaths)
        {
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Dispose();
                Console.WriteLine($"Created file: {filePath}");
            }
        }

        // Task 1: Write data to three files in parallel
        Console.WriteLine("Starting to write data to files in parallel...");
        Task[] writeTasks = filePaths.Select(filePath => AppendNumbersToFileAsync(filePath)).ToArray();
        await Task.WhenAll(writeTasks);
        Console.WriteLine("Finished writing data to files in parallel.");
    }

    static async Task AppendNumbersToFileAsync(string filePath)
    {
        Console.WriteLine($"Writing to {filePath}...");
        for (int i = 1; i <= 100; i++)
        {
            await File.AppendAllTextAsync(filePath, i.ToString() + Environment.NewLine);
        }
        Console.WriteLine($"Finished writing to {filePath}.");
    }
}
