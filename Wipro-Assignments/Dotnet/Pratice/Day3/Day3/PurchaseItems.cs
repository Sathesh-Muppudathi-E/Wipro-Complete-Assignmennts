
using System;

class Program1
{
    static void Main()
    {
        string[] items = { "Coffee", "Grilled Sandwich", "French Fries", "Noodles", "Pizza" };
        int[] prices = { 50, 60, 100, 50, 30 };

        Dictionary<int, int> cart = new Dictionary<int, int>();

        while (true)
        {
            Console.WriteLine("\nSelect an option:");
            Console.WriteLine("1. Show Menu");
            Console.WriteLine("2. Purchase Item and Quantity");
            Console.WriteLine("3. Calculate Bill");
            Console.WriteLine("4. Exit");
            Console.WriteLine("\nSelect an option:");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ShowMenu(items, prices);
                    break;
                case 2:
                    PurchaseItemAndQuantity(cart);
                    break;
                case 3:
                    CalculateBill(cart, items, prices);
                    break;
                case 4:
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void ShowMenu(string[] items, int[] prices)
    {

        Console.WriteLine("\nMenu:");
        for (int i = 0; i < items.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {items[i]} - Rs. {prices[i]}");
        }
    }

    static void PurchaseItemAndQuantity(Dictionary<int, int> cart)
    {
        Console.WriteLine("\nEnter the item number you want to purchase:");
        int itemNumber = int.Parse(Console.ReadLine());

        if (itemNumber < 1 || itemNumber > 5)
        {
            Console.WriteLine("Invalid item number. Please try again.");
            return;
        }

        Console.WriteLine("Enter the quantity:");
        int quantity = int.Parse(Console.ReadLine());

        if (quantity < 1)
        {
            Console.WriteLine("Invalid quantity. Please try again.");
            return;
        }

        if (cart.ContainsKey(itemNumber))
        {
            cart[itemNumber] += quantity;
        }
        else
        {
            cart[itemNumber] = quantity;
        }

        Console.WriteLine($"Added {quantity} of item number {itemNumber} to your cart.");
    }

    static void CalculateBill(Dictionary<int, int> cart, string[] items, int[] prices)
    {
        int totalBill = 0;
        Console.WriteLine("\nYour Cart:");
        foreach (var item in cart)
        {
            int itemNumber = item.Key;
            int quantity = item.Value;
            int itemPrice = prices[itemNumber - 1];
            totalBill += itemPrice * quantity;
            Console.WriteLine($"{items[itemNumber - 1]} (x{quantity}) - Rs. {itemPrice * quantity}");
        }
        Console.WriteLine($"Total Bill: Rs. {totalBill}");
    }
}



