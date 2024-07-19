using System;



class Program

{

    static void Main()

    {

        Console.WriteLine("Enter the values :");

        string input = Console.ReadLine();





        string[] values = input.Split(' ');

        int[] arr = new int[values.Length];

        for (int i = 0; i < values.Length; i++)

        {

            arr[i] = Convert.ToInt32(values[i]);

        }



        SelectionSort(arr);



        Console.WriteLine("Sorted Array values are:");

        foreach (int num in arr)

        {

            Console.Write(num + " ");

        }

    }



    static void SelectionSort(int[] arr)

    {

        for (int i = 0; i < arr.Length - 1; i++)

        {

            int minIndex = i;

            for (int j = i + 1; j < arr.Length; j++)

            {

                if (arr[j] < arr[minIndex])

                {

                    minIndex = j;

                }

            }



            int temp = arr[i];

            arr[i] = arr[minIndex];

            arr[minIndex] = temp;

        }

    }

}

