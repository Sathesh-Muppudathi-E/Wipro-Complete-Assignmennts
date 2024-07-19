using System;

class Program
{
    public static int[] InsertElement(int[] array, int elementToInsert, int index)
    {
        int[] newArray = new int[array.Length + 1];
        Array.Copy(array, 0, newArray, 0, index);
        newArray[index] = elementToInsert;
        Array.Copy(array, index, newArray, index + 1, array.Length - index);
        return newArray;
    }

    public static int[] UpdateElement(int[] array, int elementToUpdate, int index)
    {


        int[] newArray = new int[array.Length];
        Array.Copy(array, 0, newArray, 0, array.Length);
        newArray[index] = elementToUpdate;
        return newArray;
    }

    public static int[] ReverseArray(int[] array)
    {
        int[] reversedArray = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            reversedArray[array.Length - 1 - i] = array[i];
        }

        return reversedArray;
    }
}

public class Arrays
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the size of the array: ");
        int arraySize = Convert.ToInt32(Console.ReadLine());

        int[] numbers = new int[arraySize];

        Console.WriteLine("Enter the elements for the array : ");
        string inputString = Console.ReadLine();
        string[] stringElements = inputString.Split(' ');



        for (int i = 0; i < arraySize; i++)
        {
            numbers[i] = Convert.ToInt32(stringElements[i]);
        }

        Console.WriteLine("Enter the element to insert: ");
        int elementToInsert = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the index for insertion (0 to {0}): ", arraySize - 1);
        int insertIndex = Convert.ToInt32(Console.ReadLine());

        int[] newArray = Program.InsertElement(numbers, elementToInsert, insertIndex);
        Console.WriteLine("After Insertion: {0}", string.Join(", ", newArray));

        Console.WriteLine("Enter the element to update: ");
        int elementToUpdate = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the index for update (0 to {0}): ", arraySize - 1);
        int updateIndex = Convert.ToInt32(Console.ReadLine());


        numbers = Program.UpdateElement(numbers, elementToUpdate, updateIndex);
        Console.WriteLine("After Update: {0}", string.Join(", ", numbers));

        int[] reversedArray = Program.ReverseArray(numbers);
        Console.WriteLine("Reversed Array: {0}", string.Join(", ", reversedArray));
    }
}








