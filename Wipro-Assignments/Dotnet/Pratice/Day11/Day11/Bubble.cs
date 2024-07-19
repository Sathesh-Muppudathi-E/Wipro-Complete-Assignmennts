using System;

class BubbleSort
{
    static void Main(string[] args)
    {
        int[] numbers = { 10, 50, 90, 40, 30, 20, 80, 70 };
        int temp;
        int length = numbers.Length;


        for (int i = 0; i < length - 1; i++)
        {

            for (int j = 0; j < length - 1 - i; j++)
            {

                if (numbers[j] > numbers[j + 1])
                {

                    temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                }
            }
        }


        Console.WriteLine("bubbleSort values:");
        foreach (int num in numbers)
        {
            Console.Write($"{num} ");
        }
        Console.WriteLine();
    }
}
