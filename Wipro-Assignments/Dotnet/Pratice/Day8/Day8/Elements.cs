using System;

public class Elements
{
    public static void Main(string[] args)
    {
        int size;

        Console.WriteLine("Enter the size of the array:");
        while (!int.TryParse(Console.ReadLine(), out size))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer for size:");
        }

        int[] arr = new int[size];

        Console.WriteLine("Enter the elements of the array (with only two unique elements):");
        for (int i = 0; i < size; i++)
        {
            while (!int.TryParse(Console.ReadLine(), out arr[i]))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer for element {0}:", i + 1);
            }
        }

        (int x, int y) = FindTwoUniqueElements(arr);

        if (x != 0 && y != 0)
        {
            Console.WriteLine($"The two non-repeating elements are: {x} and {y}");
        }
        else
        {
            Console.WriteLine("The array does not contain exactly two unique elements.");
        }
    }

    public static (int, int) FindTwoUniqueElements(int[] arr)
    {
        int xor = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            xor ^= arr[i];
        }

        int rightmostSetBit = xor & -xor;

        int x = 0, y = 0;
        foreach (int num in arr)
        {
            if ((num & rightmostSetBit) != 0)
            {
                x ^= num;
            }
            else
            {
                y ^= num;
            }
        }

        return (x, y);
    }
}
