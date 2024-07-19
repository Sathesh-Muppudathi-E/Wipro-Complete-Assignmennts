using System;


public interface IStack<T>
{
    void Push(T item);
    T Pop();
    T Peek();
    bool IsEmpty();
}


public class SimpleStack1<T> : IStack<T>
{
    private T[] stack;
    private int size;

    public SimpleStack1(int capacity = 4)
    {
        stack = new T[capacity];
        size = 0;
    }

    public void Push(T item)
    {
        if (size == stack.Length)
        {
            Resize(stack.Length * 2);
        }
        stack[size++] = item;
    }

    public T Pop()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Stack is empty.");
        }
        T item = stack[--size];
        stack[size] = default(T); // Clear the reference
        if (size > 0 && size == stack.Length / 4)
        {
            Resize(stack.Length / 2);
        }
        return item;
    }

    public T Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Stack is empty.");
        }
        return stack[size - 1];
    }

    public bool IsEmpty()
    {
        return size == 0;
    }

    private void Resize(int newCapacity)
    {
        T[] newArray = new T[newCapacity];
        Array.Copy(stack, newArray, size);
        stack = newArray;
    }
}

internal class Way1
{
    static void Main(string[] args)
    {
        // Testing SimpleStack with integer values
        IStack<int> intStack = new SimpleStack1<int>();
        intStack.Push(1);
        intStack.Push(2);
        intStack.Push(3);

        Console.WriteLine($"Peek at stack: {intStack.Peek()}");

        Console.WriteLine($"Pop the value: {intStack.Pop()}");
        Console.WriteLine($"Pop the value: {intStack.Pop()}");
        Console.WriteLine($"Peek at stack: {intStack.Peek()}");

        try
        {
            intStack.Pop();
            intStack.Pop();
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }

        // Testing SimpleStack with string values
        IStack<string> stringStack = new SimpleStack1<string>();
        stringStack.Push("ab");
        stringStack.Push("abc");
        stringStack.Push("abcd");

        Console.WriteLine($"Peek at stack: {stringStack.Peek()}");

        Console.WriteLine($"Pop the value: {stringStack.Pop()}");
        Console.WriteLine($"Pop the value: {stringStack.Pop()}");
        Console.WriteLine($"Peek at stack: {stringStack.Peek()}");
        try
        {
            stringStack.Pop();
            stringStack.Pop();
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}