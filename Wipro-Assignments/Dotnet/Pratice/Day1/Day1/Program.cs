

using System;
class studentdetails
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the firstname");
        string firstname = Console.ReadLine();
        Console.WriteLine("Enter the lastname");
        string lastname = Console.ReadLine();
        Console.WriteLine("Enter the age");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the address1");
        string address1 = Console.ReadLine();
        Console.WriteLine("Enter the address2");
        string address2 = Console.ReadLine();
        Console.WriteLine("Enter the city");
        string city = Console.ReadLine();
        Console.WriteLine("Enter the emailid");
        string emailid = Console.ReadLine();
        Console.WriteLine("Enter the phonenumber");
        int phonenumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the gender");
        string gender = Console.ReadLine();
        Console.WriteLine($"firstname : {firstname}");
        Console.WriteLine($"lastname:{lastname}");
        Console.WriteLine($"age:{age}");
        Console.WriteLine($"address1: {address1}");
        Console.WriteLine($"address2 :{address2}");
        Console.WriteLine($"city : {city}");
        Console.WriteLine($"emailid:{emailid}");
        Console.WriteLine($"gender: {gender}");

    }
}
