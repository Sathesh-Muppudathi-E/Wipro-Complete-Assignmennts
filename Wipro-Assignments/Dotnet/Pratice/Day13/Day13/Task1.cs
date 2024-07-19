


using System;
using System.Collections.Generic;
using System.Linq;

public class Person1
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
}

public class Program
{
    public static void Main()
    {
        List<Person> persons = new List<Person>
        {
            new Person { FirstName = "sathish", LastName = "kumar", Age = 25 },
            new Person { FirstName = "lokesh", LastName = "kumar", Age = 24 },
            new Person { FirstName = "Shiva", LastName = "reddy", Age = 23 },
            new Person { FirstName = "Pradeep", LastName = "singh", Age = 26 }

        };

        var namesOver30 = persons.Where(p => p.Age > 30)
           .Select(p => $"{p.FirstName} {p.LastName}");

        foreach (var name in namesOver30)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine("******************part b*******************");

        var sortedPersons = persons.OrderBy(p => p.LastName)
                                   .ThenBy(p => p.FirstName);

        foreach (var person in sortedPersons)
        {
            Console.WriteLine($"{person.FirstName} {person.LastName} {person.Age}");
        }



    }
}




