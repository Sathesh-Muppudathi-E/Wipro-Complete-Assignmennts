using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

class Task3
{
    static async Task main(string[] args)
    {
        string[] filePaths = { "logs/log1.txt", "logs/log2.txt", "logs/log3.txt" };

        // Task 3: Read data from all three files in parallel
        Console.WriteLine("Starting to read data from files in parallel...");
        Task<string[]>[] readTasks = filePaths.Select(filePath => ReadFileAsync(filePath)).ToArray();
        string[][] fileContents = await Task.WhenAll(readTasks);
        Console.WriteLine("Finished reading data from files in parallel.");

        for (int i = 0; i < filePaths.Length; i++)
        {
            Console.WriteLine($"Content of {filePaths[i]}: \n{string.Join(Environment.NewLine, fileContents[i])}");
        }
    }

    static async Task<string[]> ReadFileAsync(string filePath)
    {
        Console.WriteLine($"Reading from {filePath}...");
        string[] content = await File.ReadAllLinesAsync(filePath);
        Console.WriteLine($"Finished reading from {filePath}.");
        return content;
    }
}