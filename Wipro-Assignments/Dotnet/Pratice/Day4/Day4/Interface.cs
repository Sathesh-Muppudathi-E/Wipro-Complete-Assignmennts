
using System;

interface IDrivable
{
    void Start();
    void Stop();
    void Drive();
}


class Car : IDrivable
{
    public void Start()
    {
        Console.WriteLine("Car started.");
    }

    public void Stop()
    {
        Console.WriteLine("Car stopped.");
    }

    public void Drive()
    {
        Console.WriteLine("Car is driving.");
    }
}


class Bicycle : IDrivable
{
    public void Start()
    {
        Console.WriteLine("Bicycle started.");
    }

    public void Stop()
    {
        Console.WriteLine("Bicycle stopped.");
    }

    public void Drive()
    {

    }


}

class Interface
{
    static void Main()
    {

        var car1 = new Car();
        var car2 = new Car();
        var bicycle1 = new Bicycle();
        var bicycle2 = new Bicycle();

        IDrivable[] vehicles = { car1, car2, bicycle1, bicycle2 };

        foreach (var vehicle in vehicles)
        {
            vehicle.Start();
            vehicle.Drive();
            vehicle.Stop();

        }
    }
}
