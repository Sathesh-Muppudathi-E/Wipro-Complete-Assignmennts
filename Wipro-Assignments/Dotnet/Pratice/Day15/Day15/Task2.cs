


using System;
using System.Reflection;

class Program1
{
    static void main(string[] args)
    {
        string assemblyPath = @"D:\dotnet\Day15\Day15\bin\Debug\net8.0\Day15.dll";


        Assembly assembly = Assembly.LoadFrom(assemblyPath);


        Type specificType = assembly.GetType("Day15.ExampleClass");

        if (specificType != null)
        {
            Console.WriteLine($"Type Name: {specificType.FullName}");


            if (specificType.BaseType != null)
            {
                Console.WriteLine($"  Base Type: {specificType.BaseType.FullName}");
            }


            GetProperties(specificType);


            GetFields(specificType);


            object instance = Activator.CreateInstance(specificType);
            PrintMemberValues(instance, specificType);


            GetMethods(specificType);
        }
        else
        {
            Console.WriteLine("Specified type not found in the assembly.");
        }
    }

    public static void GetProperties(Type type)
    {
        if (type != null)
        {
            PropertyInfo[] properties = type.GetProperties();
            if (properties.Length > 0)
            {
                Console.WriteLine("  Public Properties:");
                foreach (PropertyInfo property in properties)
                {
                    Console.WriteLine($"    - {property.Name}, Type: {property.PropertyType.FullName}");
                }
            }
        }
    }

    public static void GetFields(Type type)
    {
        if (type != null)
        {
            FieldInfo[] fields = type.GetFields();
            if (fields.Length > 0)
            {
                Console.WriteLine("  Public Fields:");
                foreach (FieldInfo field in fields)
                {
                    Console.WriteLine($"    - {field.Name}, Type: {field.FieldType.FullName}");
                }
            }
        }
    }

    public static void PrintMemberValues(object instance, Type type)
    {
        if (instance != null && type != null)
        {

            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                var value = property.GetValue(instance);
                Console.WriteLine($"  Property: {property.Name}, Value: {value}");
            }


            FieldInfo[] fields = type.GetFields();
            foreach (FieldInfo field in fields)
            {
                var value = field.GetValue(instance);
                Console.WriteLine($"  Field: {field.Name}, Value: {value}");
            }
        }
    }

    public static void GetMethods(Type type)
    {
        if (type != null)
        {
            MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            if (methods.Length > 0)
            {
                Console.WriteLine("  Public Methods:");
                foreach (MethodInfo method in methods)
                {
                    Console.WriteLine($"    - {method.Name}");
                    ParameterInfo[] parameters = method.GetParameters();
                    foreach (ParameterInfo param in parameters)
                    {
                        Console.WriteLine($"      Parameter Name: {param.Name}, Type: {param.ParameterType.FullName}");
                    }
                }
            }
        }
    }
}


























