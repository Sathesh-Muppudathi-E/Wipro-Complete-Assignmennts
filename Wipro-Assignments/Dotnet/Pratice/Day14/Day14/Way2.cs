using System;
using System.Collections.Generic;

class Events
{

    public delegate string IntToStringDelegate(int number);


    public static string ConvertIntToString(int number)
    {
        return number.ToString();
    }


    public static void PrintInt(int number)
    {
        Console.WriteLine($"The integer is: {number}");
    }


    public delegate void IntActionDelegate(int number);

    static void main(string[] args)
    {

        IntToStringDelegate intToString = new IntToStringDelegate(ConvertIntToString);

        List<int> intList = new List<int> { 1, 2, 3, 4, 5 };
        List<string> stringList = new List<string>();

        foreach (int number in intList)
        {
            stringList.Add(intToString(number));
        }


        Console.WriteLine("String to integers:");
        foreach (string str in stringList)
        {
            Console.WriteLine(str);
        }


        IntActionDelegate intAction = new IntActionDelegate(PrintInt);
        intAction += new IntActionDelegate(ConvertIntToStringAndPrint);

        Console.WriteLine("\nUsing multicast delegate:");
        foreach (int number in intList)
        {
            intAction(number);
        }
    }

    public static void ConvertIntToStringAndPrint(int number)
    {
        string str = ConvertIntToString(number);
        Console.WriteLine($"Converted to string: {str}");

    }
}



