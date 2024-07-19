

using System;
class ArraySlicer
{
    public static int[] SliceArray(int[] array, int startIndex, int endIndex)
    {
        startIndex = StartIndex(startIndex);
        endIndex = EndIndex(endIndex, array.Length);

        return array[startIndex..endIndex];
    }

    public static int StartIndex(int startIndex)
    {
        return startIndex < 0 ? 0 : startIndex;
    }

    public static int EndIndex(int endIndex, int arrayLength)
    {
        return endIndex > arrayLength ? arrayLength : endIndex;
    }

    public static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int startIndex = 3;
        int endIndex = 7;

        int[] slicedArray = SliceArray(numbers, startIndex, endIndex);
        Console.WriteLine("Sliced Array:");
        foreach (int num in slicedArray)
        {
            Console.WriteLine(num);
        }
    }
}


