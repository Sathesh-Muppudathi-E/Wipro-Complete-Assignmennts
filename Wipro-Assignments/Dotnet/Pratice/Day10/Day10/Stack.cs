using System;
using System.Collections.Generic;
class SimpleStack<T> 
{
    private List<T> items = new List<T>();
    public void Push(T item) { 
        items.Add(item); 
    } public T Pop() { if (items.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty");
        } 
        int lastIndex = items.Count - 1;
        T item = items[lastIndex]; items.RemoveAt(lastIndex);
        return item;
    } 
    public T Peek()
    { 
        if (items.Count == 0)
        { 
            throw new InvalidOperationException("Stack is empty");
        } return items[items.Count - 1];
    }
}
class Program
{ 
    static void main(string[] args)
    {
        SimpleStack<int> stack = new SimpleStack<int>();
        Console.Write("Enter the elements to push:");
        int count = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < count; i++)
        { 
            Console.Write($"push {i + 1}: ");
            int element = Convert.ToInt32(Console.ReadLine()); 
            stack.Push(element);
        } 
        Console.WriteLine("Popp items from the stack:");
        while (true)
        { 
            try
            {
                int poppedItem = stack.Pop();
                Console.WriteLine($"Popped item: {poppedItem}");
            } 
            catch (InvalidOperationException e) 
            { Console.WriteLine(e.Message); break;
            } 
        }
    }
}
