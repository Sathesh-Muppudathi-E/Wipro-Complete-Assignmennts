

using System;
using System.Collections.Generic;

class Item
{
    public char ObjectNumber { get; set; }
    public double Weight { get; set; }
    public double Profit { get; set; }
    public double ProfitToWeightRatio { get; set; }
}

class Knap
{
    static void Main()
    {
        List<Item> items = new List<Item>();

        AddItems(items, 'A', 3, 50);
        AddItems(items, 'B', 4, 40);
        AddItems(items, 'C', 6, 90);
        AddItems(items, 'D', 4, 10);
        AddItems(items, 'E', 1, 5);
        AddItems(items, 'F', 2, 11);
        AddItems(items, 'G', 5, 70);
        AddItems(items, 'H', 2, 15);

        double knapsackCapacity = 20;

        foreach (var item in items)
        {
            item.ProfitToWeightRatio = item.Profit / item.Weight;
        }


        items.Sort((x, y) => y.ProfitToWeightRatio.CompareTo(x.ProfitToWeightRatio));

        double totalProfit = 0;
        double totalWeight = 0;

        Console.WriteLine("Items included in the knapsack:");
        foreach (var item in items)
        {
            if (totalWeight + item.Weight <= knapsackCapacity)
            {
                totalWeight += item.Weight;
                totalProfit += item.Profit;
                Console.WriteLine($"Object {item.ObjectNumber}:  (Weight {item.Weight}, Profit {item.Profit})");
            }
            else
            {
                double remainingCapacity = knapsackCapacity - totalWeight;
                double fraction = remainingCapacity / item.Weight;
                totalWeight += remainingCapacity;
                totalProfit += item.Profit * fraction;
                Console.WriteLine($"Object {item.ObjectNumber}:remainingCapacity:0");
                break;
            }
        }

        Console.WriteLine($"Total profit: {totalProfit}");
    }

    static void AddItems(List<Item> items, char label, double weight, double profit)
    {
        items.Add(new Item { ObjectNumber = label, Weight = weight, Profit = profit });
    }
}
