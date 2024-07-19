
using System;


public class CustomStack<T>
{
    private List<T> stackList;

    public CustomStack()
    {
        stackList = new List<T>();
    }


    public void Push(T item)
    {
        stackList.Add(item);
    }


    public T Pop()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("The stack is empty.");
        }
        T item = stackList[stackList.Count - 1];
        stackList.RemoveAt(stackList.Count - 1);
        return item;
    }


    public T Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("The stack is empty.");
        }
        return stackList[stackList.Count - 1];
    }


    public bool IsEmpty()
    {
        return stackList.Count == 0;
    }


    public void Display()
    {
        Console.Write("Pushed into stack: ");
        foreach (T item in stackList)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
public class Stack
{
    public static void Main(string[] args)
    {
        CustomStack<int> customStack = new CustomStack<int>();


        customStack.Push(1);

        customStack.Push(2);

        customStack.Push(3);

        customStack.Push(4);

        customStack.Push(5);
        customStack.Display();


        Console.WriteLine("Total item are pushed into stack: " + customStack.Peek());
        customStack.Display();



        while (!customStack.IsEmpty())
        {/*
            int item = customStack.Pop();
            Console.WriteLine("Popped element: " + item);
           customStack.Display();*/
        }
    }
}

