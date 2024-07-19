
using System;

namespace MenuOrderingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] menu = { "Coffee", "Grilled Sandwich", "French Fries", "Noodles", "Pizza" };
            int[] order = new int[menu.Length];
            bool addingItems = true;

            while (addingItems)
            {
                DisplayMenu();
                Console.Write("\nSelect the item number: ");
                if (int.TryParse(Console.ReadLine(), out int itemNumber) && itemNumber >= 1 && itemNumber <= menu.Length)
                {
                    Console.Write($"You selected {menu[itemNumber - 1]}\nQuantity: ");
                    if (int.TryParse(Console.ReadLine(), out int quantity))
                    {
                        order[itemNumber - 1] += quantity;
                    }
                    else
                    {
                        Console.WriteLine("Invalid quantity. Please try again.");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid item number selected. Please try again.");
                    continue;
                }

                Console.Write("Do you want to add more items? (Y/N): ");
                string moreItems = Console.ReadLine().Trim().ToLower();
                if (moreItems != "y")
                {
                    addingItems = false;
                }
            }

            Console.WriteLine("\nItems selected by you:");
            int totalItems = 0;
            for (int i = 0; i < menu.Length; i++)
            {
                if (order[i] > 0)
                {
                    Console.WriteLine($" {order[i]}*{menu[i]}");
                    totalItems += order[i];
                }
            }

            Console.WriteLine($"\nTotal Items: {totalItems}");


            int coffeePrice = 40;
            int sandwichPrice = 80;
            int friesPrice = 60;
            int noodlesPrice = 50;
            int pizzaPrice = 120;

            Console.WriteLine("\nTotal Items with Price:");
            Console.WriteLine($"1. Coffee             : {order[0]} * {coffeePrice} Rs = {order[0] * coffeePrice} Rs");
            Console.WriteLine($"2. Grilled Sandwich : {order[1]} * {sandwichPrice} Rs = {order[1] * sandwichPrice} Rs");
            Console.WriteLine($"3. French Fries      : {order[2]} * {friesPrice} Rs = {order[2] * friesPrice} Rs");
            Console.WriteLine($"4. Noodles           : {order[3]} * {noodlesPrice} Rs = {order[3] * noodlesPrice} Rs");
            Console.WriteLine($"5. Pizza             : {order[4]} * {pizzaPrice} Rs = {order[4] * pizzaPrice} Rs");

            int totalBill = order[0] * coffeePrice + order[1] * sandwichPrice + order[2] * friesPrice + order[3] * noodlesPrice + order[4] * pizzaPrice;

            float CGST = totalBill * 0.05f;
            float SGST = totalBill * 0.18f;

            Console.WriteLine($"\nTotal Bill       : {totalBill}");
            Console.WriteLine($"CGST 5%        : {CGST}");
            Console.WriteLine($"SGST 18%      : {SGST}");

            decimal totalAmountToPay = totalBill + (decimal)CGST + (decimal)SGST;

            Console.WriteLine($"\nTotal Amount to Pay: {totalAmountToPay}");

            Console.ReadLine();
        }

        static void DisplayMenu()
        {
            Console.WriteLine("Select the item you want to order:");
            Console.WriteLine("1. Coffee");
            Console.WriteLine("2. Grilled Sandwich");
            Console.WriteLine("3. French Fries");
            Console.WriteLine("4. Noodles");
            Console.WriteLine("5. Pizza");
        }
    }
}
