

using System;
using System.IO;
using System.Threading.Tasks;

class Task2
{
    static async Task main(string[] args)
    {
        // Ensure directory exists
        string directoryPath = Path.Combine(Directory.GetCurrentDirectory(), "logs");
        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }

        // Task 2: Write data to a file synchronously with a delay of 200 milliseconds
        string syncFilePath = Path.Combine(directoryPath, "log_sync.txt");
        if (!File.Exists(syncFilePath))
        {
            File.Create(syncFilePath).Dispose();
            Console.WriteLine($"Created file: {syncFilePath}");
        }
        Console.WriteLine("Starting to write data to file synchronously with delay...");
        await AppendNumbersToFileWithDelayAsync(syncFilePath, 200);
        Console.WriteLine("Finished writing data to file synchronously with delay.");
    }

    static async Task AppendNumbersToFileWithDelayAsync(string filePath, int delayMilliseconds)
    {
        Console.WriteLine($"Writing to {filePath} with delay...");
        for (int i = 1; i <= 100; i++)
        {
            await File.AppendAllTextAsync(filePath, i.ToString() + Environment.NewLine);
            await Task.Delay(delayMilliseconds);
        }
        Console.WriteLine($"Finished writing to {filePath} with delay.");
    }
}
