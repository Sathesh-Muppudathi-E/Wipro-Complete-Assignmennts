


using System;
using System.Linq;
using System.Reflection;

namespace ReflectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the path of the assembly:");
            string assemblyPath = Console.ReadLine();

            Console.WriteLine("Enter the name of the type to inspect:");
            string typeName = Console.ReadLine();

            try
            {
                
                Assembly assembly = Assembly.LoadFrom(assemblyPath);

               
                Type type = assembly.GetType(typeName);
                if (type == null)
                {
                    Console.WriteLine("Type not found.");
                    return;
                }

                Console.WriteLine($"Type: {type.FullName}");

                Console.WriteLine($"Base Type: {type.BaseType?.FullName}");

              
                Type[] interfaces = type.GetInterfaces();
                if (interfaces.Length > 0)
                {
                    Console.WriteLine("Interfaces:");
                    foreach (var iface in interfaces)
                    {
                        Console.WriteLine($"  {iface.FullName}");
                    }
                }
                else
                {
                    Console.WriteLine("No interfaces implemented.");
                }

              
                PropertyInfo[] properties = type.GetProperties();
                if (properties.Length > 0)
                {
                    Console.WriteLine("Public Properties of Employee:");
                    foreach (var prop in properties)
                    {
                        var value = prop.GetValue(Activator.CreateInstance(type));
                        Console.WriteLine($"  {prop.Name} ({prop.PropertyType.Name}): {value}");
                    }
                }
                else
                {
                    Console.WriteLine("No public properties.");
                }

           
                FieldInfo[] fields = type.GetFields();
                if (fields.Length > 0)
                {
                    Console.WriteLine("Public Fields of Employee:");
                    foreach (var field in fields)
                    {
                        var value = field.GetValue(Activator.CreateInstance(type));
                        Console.WriteLine($"  {field.Name} ({field.FieldType.Name}): {value}");
                    }
                }
                else
                {
                    Console.WriteLine("No public fields.");
                }

               
                MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
                if (methods.Length > 0)
                {
                    Console.WriteLine("Methods:");
                    foreach (var method in methods)
                    {
                        if (method.GetParameters().Length == 0)
                        {
                            Console.WriteLine($"  {method.Name}()");
                        }
                        else
                        {
                            Console.WriteLine($"  {method.Name}({string.Join(", ", method.GetParameters().Select(p => p.ParameterType.Name + " " + p.Name))})");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("No public methods.");
                }

                Console.WriteLine();

             
                object instance = Activator.CreateInstance(type);

                Console.WriteLine("Enter the name of the method to invoke:");
                string methodName = Console.ReadLine();
                MethodInfo methodToInvoke = type.GetMethod(methodName);

                if (methodToInvoke != null)
                {
                    ParameterInfo[] parameters = methodToInvoke.GetParameters();
                    object[] paramValues = new object[parameters.Length];

                    for (int i = 0; i < parameters.Length; i++)
                    {
                        Console.WriteLine($"Enter value for parameter '{parameters[i].Name}' of type '{parameters[i].ParameterType.Name}':");
                        string input = Console.ReadLine();
                        paramValues[i] = Convert.ChangeType(input, parameters[i].ParameterType);
                    }

                    try
                    {
                        object result = methodToInvoke.Invoke(instance, paramValues);
                        if (methodToInvoke.ReturnType != typeof(void))
                        {
                            Console.WriteLine($"Method returned: {result}");
                        }
                    }
                    catch (TargetInvocationException ex)
                    {
                        Console.WriteLine($"Error invoking method: {ex.InnerException?.Message}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }
                else
                {
                    Console.WriteLine("Method not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}

























