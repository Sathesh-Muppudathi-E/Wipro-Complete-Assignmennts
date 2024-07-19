using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

class Task4
{
    static async Task Main(string[] args)
    {
        string[] filePaths = { "logs/log1.txt", "logs/log2.txt", "logs/log3.txt" };

        // Task 4: Get the count of characters in each file using async and await with tasks
        Console.WriteLine("Starting to count characters in each file...");
        Task<string[]>[] readTasks = filePaths.Select(filePath => ReadFileAsync(filePath)).ToArray();
        string[][] fileContents = await Task.WhenAll(readTasks);

        Task<int>[] countTasks = fileContents.Select(content => GetCharacterCountAsync(content)).ToArray();
        int[] characterCounts = await Task.WhenAll(countTasks);
        Console.WriteLine("Finished counting characters in each file.");

        for (int i = 0; i < filePaths.Length; i++)
        {
            Console.WriteLine($"Character count in {filePaths[i]}: {characterCounts[i]}");
        }
    }

    static async Task<string[]> ReadFileAsync(string filePath)
    {
        Console.WriteLine($"Reading from {filePath}...");
        string[] content = await File.ReadAllLinesAsync(filePath);
        Console.WriteLine($"Finished reading from {filePath}.");
        return content;
    }

    static async Task<int> GetCharacterCountAsync(string[] content)
    {
        return await Task.Run(() =>
        {
            int count = content.Sum(line => line.Length);
            Console.WriteLine($"Character count: {count}");
            return count;
        });
    }
}
