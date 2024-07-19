using System;

public class Patient
{
    public string Name { get; set; }
    public long Age { get; set; }
    public string MedicalCondition { get; set; }

    public Patient(string name, long age, string medicalCondition)
    {
        Name = name;
        Age = age;
        MedicalCondition = medicalCondition;
    }
}

public class PatientQueue
{
    private class Node
    {
        public Patient Data { get; set; }
        public Node Next { get; set; }

        public Node(Patient data)
        {
            Data = data;
            Next = null;
        }
    }

    private Node head;
    private Node tail;
    private long count;

    public PatientQueue()
    {
        head = null;
        tail = null;
        count = 0;
    }

    public void AddPatient(Patient patient)
    {
        Node newNode = new Node(patient);
        if (tail != null)
        {
            tail.Next = newNode;
        }
        tail = newNode;
        if (head == null)
        {
            head = newNode;
        }
        count++;
    }

    public Patient RemovePatient()
    {
        if (head == null)
        {
            Console.WriteLine("\nQueue is empty. No patient to remove.\n");
            return null;
        }

        Patient removedPatient = head.Data;
        head = head.Next;
        if (head == null)
        {
            tail = null;
        }
        count--;
        return removedPatient;
    }

    public Patient SearchMiddlePatient()
    {
        if (head == null)
        {
            Console.WriteLine("\nQueue is empty. No middle patient.\n");
            return null;
        }

        Node slow = head;
        Node fast = head;
        while (fast != null && fast.Next != null)
        {
            slow = slow.Next;
            fast = fast.Next.Next;
        }
        return slow.Data;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        PatientQueue patientQueue = new PatientQueue();

        Console.WriteLine("Welcome to the Hospital Patient Queue Management System!\n");

        long choice;  // Changed to long to handle larger inputs
        do
        {
            Console.WriteLine("1. Add Patient");
            Console.WriteLine("2. Remove Patient");
            Console.WriteLine("3. Search for Middle Patient");
            Console.WriteLine("4. Exit\n");

            Console.Write("Enter your choice: ");
            if (!long.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("\nInvalid input! Please enter a valid option between 1 and 4.\n");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine("\nEnter patient details:");
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Age: ");
                    if (!long.TryParse(Console.ReadLine(), out long age) || age < 0)  // Validate age input
                    {
                        Console.WriteLine("\nInvalid age input! Please enter a valid number.\n");
                        break;
                    }
                    Console.Write("Medical Condition: ");
                    string medicalCondition = Console.ReadLine();

                    Patient patient = new Patient(name, age, medicalCondition);
                    patientQueue.AddPatient(patient);
                    Console.WriteLine("\nPatient added successfully to the queue.\n");
                    break;

                case 2:
                    Patient removedPatient = patientQueue.RemovePatient();
                    if (removedPatient != null)
                    {
                        Console.WriteLine($"\nPatient {removedPatient.Name} removed successfully from the queue.\n");
                    }
                    break;

                case 3:
                    Patient middlePatient = patientQueue.SearchMiddlePatient();
                    if (middlePatient != null)
                    {
                        Console.WriteLine("\nMiddle Patient:");
                        Console.WriteLine($"Name: {middlePatient.Name}");
                        Console.WriteLine($"Age: {middlePatient.Age}");
                        Console.WriteLine($"Medical Condition: {middlePatient.MedicalCondition}\n");
                    }
                    break;

                case 4:
                    Console.WriteLine("\nExiting the system. Thank you!");
                    break;

                default:
                    Console.WriteLine("\nInvalid choice! Please enter a valid option.\n");
                    break;
            }
        } while (choice != 4);
    }
}
