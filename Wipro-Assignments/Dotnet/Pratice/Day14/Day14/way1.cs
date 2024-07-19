

using System;
using System.Collections.Generic;

class Program
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

    static void Main(string[] args)
    {

        IntToStringDelegate intToString = new IntToStringDelegate(ConvertIntToString);

        List<int> intList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        List<string> stringList = new List<string>();

        foreach (int number in intList)
        {
            stringList.Add(intToString(number));
        }


        Console.WriteLine("String representations of the integers:");
        foreach (string str in stringList)
        {
            Console.WriteLine(str);
        }

    }
}
