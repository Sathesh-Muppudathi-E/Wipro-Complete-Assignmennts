

using System;
using System.Collections.Generic;

public class CustomQueue<T>
{
    private List<T> queueList;

    public CustomQueue()
    {
        queueList = new List<T>();
    }

    public void Enqueue(T item)
    {
        queueList.Add(item);
    }

    public T Dequeue()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("The queue is empty.");
        }
        T item = queueList[0];
        queueList.RemoveAt(0);
        return item;
    }

    public T Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("The queue is empty.");
        }
        return queueList[0];
    }

    public bool IsEmpty()
    {
        return queueList.Count == 0;
    }

    public void Display()
    {
        Console.Write("Queue contents: ");
        foreach (T item in queueList)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}

public class Queue
{
    public static void Main(string[] args)
    {
        CustomQueue<int> customQueue = new CustomQueue<int>();

        customQueue.Enqueue(1);
        customQueue.Enqueue(2);
        customQueue.Enqueue(3);
        customQueue.Enqueue(4);
        customQueue.Enqueue(5);
        customQueue.Display();

        Console.WriteLine("Next item to be dequeued: " + customQueue.Peek());
        customQueue.Display();

        while (!customQueue.IsEmpty())
        {
            int item = customQueue.Dequeue();
            Console.WriteLine("Dequeued element: " + item);
            customQueue.Display();
        }
    }
}



