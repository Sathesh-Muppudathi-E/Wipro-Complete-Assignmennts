
using System;
using System.Collections.Generic;
using System.Linq;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
}

public class Task2
{
    public static void main()
    {
        List<Person> persons = new List<Person>
        {
            new Person { FirstName = "yashasree", LastName = "p", Age = 25 },
            new Person { FirstName = "lahari", LastName = "G", Age = 24 },
            new Person { FirstName = "Sarvya", LastName = "B", Age = 23 },
            new Person { FirstName = "Likhitha", LastName = "L", Age = 26 }

        };

        var averageAge = persons.Average(p => p.Age);
        Console.WriteLine($"Average Age: {averageAge}");

        Console.WriteLine("********************part b**************************");

        var oldestPerson = persons.OrderByDescending(p => p.Age).First();
        var youngestPerson = persons.OrderBy(p => p.Age).First();

        Console.WriteLine($"Oldest Person: {oldestPerson.FirstName} {oldestPerson.LastName}");
        Console.WriteLine($"Youngest Person: {youngestPerson.FirstName} {youngestPerson.LastName}");


    }
}



