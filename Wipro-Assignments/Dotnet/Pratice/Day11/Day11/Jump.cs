


using System;

public class JumpSearch

{



    public static int Square(int n)

    {

        if (n == 0)

            return 0;

        int x = n;

        int y = (x + 1) / 2;

        while (y < x)

        {

            x = y;

            y = (x + n / x) / 2;

        }

        return x;

    }

    public static int Min(int a, int b)

    {

        return a < b ? a : b;

    }

    public static int Jump(int[] array, int target)

    {

        int n = array.Length;

        int jumpSize = Square(n);

        int left = 0;

        int right = 0;

        while (right < n && array[right] < target)

        {

            left = right;

            right = Min(n - 1, right + jumpSize);

        }



        for (int i = left; i <= right; i++)

        {

            if (array[i] == target)

                return i;

        }



        return -1;

    }

    public static void Main()

    {

        int[] sortedArray = { 10, 20, 30, 40, 50, 70, 80, 90 };

        int target = 20;



        int index = Jump(sortedArray, target);



        if (index != -1)

            Console.WriteLine($"Element {target} found at index {index}");

        else

            Console.WriteLine($"Element {target} not found in the array");

    }



}

