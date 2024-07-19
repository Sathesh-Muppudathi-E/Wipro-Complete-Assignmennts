using System;

namespace DemoConsole
{
    public static class SwapData
    {

        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the first integer:");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Enter the second integer:");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine($"Before swap: x = {x}, y = {y}");
            SwapData.Swap(ref x, ref y);
            Console.WriteLine($"After swap: x = {x}, y = {y}");


            Console.Write("Enter the first string:");
            string str1 = Console.ReadLine();

            Console.Write("Enter the second string:");
            string str2 = Console.ReadLine();

            Console.WriteLine($"Before swap: str1 = {str1}, str2 = {str2}");
            SwapData.Swap(ref str1, ref str2);
            Console.WriteLine($"After swap: str1 = {str1}, str2 = {str2}");


        }
    }


    public class Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
