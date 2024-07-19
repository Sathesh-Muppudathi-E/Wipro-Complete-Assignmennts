
using System;
using System.Collections.Generic;

class Patient
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Gender { get; set; }
    public int Age { get; set; }
    public string PhoneNumber { get; set; }
    public string State { get; set; }
    public string Pincode { get; set; }
    public string Department { get; set; }
    public double TreatmentCost { get; set; }

    public override string ToString()
    {
        return $"Name: {FirstName} {LastName}, Gender: {Gender}, Age: {Age}, Phone: {PhoneNumber}, State: {State}, Pincode: {Pincode}, Department: {Department}, Cost: {TreatmentCost}";
    }
}

class Hospital
{
    static void Main(string[] args)
    {
        List<Patient> patients = new List<Patient>();
        Dictionary<int, (string, double)> departments = new Dictionary<int, (string, double)>()
        {
            { 1, ("General", 400) },
            { 2, ("ENT", 800) },
            { 3, ("Cardiology", 1200) },
            { 4, ("Operation Theater", 5000) },
            { 5, ("Intensive care Unit", 6000) }
        };

        for (int i = 0; i < 10; i++)
        {
            Patient patient = new Patient();

            Console.WriteLine("\nEnter Patient Details:");
            Console.Write("First Name: ");
            patient.FirstName = Console.ReadLine();

            Console.Write("Last Name: ");
            patient.LastName = Console.ReadLine();

            Console.Write("Gender: ");
            patient.Gender = Console.ReadLine();

            Console.Write("Age: ");
            patient.Age = int.Parse(Console.ReadLine());

            Console.Write("Phone Number: ");
            patient.PhoneNumber = Console.ReadLine();

            Console.Write("State: ");
            patient.State = Console.ReadLine();

            Console.Write("Pincode: ");
            patient.Pincode = Console.ReadLine();

            Console.WriteLine("Select the department for the treatment:");
            foreach (var dept in departments)
            {
                Console.WriteLine($"{dept.Key}. {dept.Value.Item1} : {dept.Value.Item2}");
            }

            int departmentChoice;
            while (true)
            {
                Console.Write("Enter the department number: ");
                if (int.TryParse(Console.ReadLine(), out departmentChoice) && departments.ContainsKey(departmentChoice))
                {
                    var department = departments[departmentChoice];
                    patient.Department = department.Item1;
                    patient.TreatmentCost = department.Item2;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid department selection. Please try again.");
                }
            }

            patients.Add(patient);
            Console.WriteLine("Patient added successfully!");
        }

        Console.WriteLine("\nEnter phone number to search for a patient:");
        string phoneNumberToSearch = Console.ReadLine();
        Patient foundPatient = patients.Find(p => p.PhoneNumber == phoneNumberToSearch);

        if (foundPatient != null)
        {
            Console.WriteLine("Patient details:");
            Console.WriteLine(foundPatient);
        }
        else
        {
            Console.WriteLine("Patient not found.");
        }
    }
}