using System;

class Swap
{
    static void Main()
    {
        int a = 5, b = 10;

        Console.WriteLine($"Before swapping: a = {a}, b = {b}");

        // Swap using XOR (^) operator
        a = a ^ b;
        b = a ^ b;
        a = a ^ b;

        Console.WriteLine($"After swapping: a = {a}, b = {b}");
    }
}