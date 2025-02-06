using System;
using System.Reflection;
using ReflectionConcept; // Ensure this is added to reference the Employee class

internal class Program
{
    private static void Main(string[] args)
    {
        // Use typeof instead of Type.GetType for classes within the same project
        Type T = typeof(Employee);

        // Display basic type information
        Console.WriteLine($"Type Name: {T.Name}");
        Console.WriteLine($"Full Type Name: {T.FullName}");

        // Retrieve and display all methods of the type
        MethodInfo[] methods = T.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
        Console.WriteLine("Methods:");
        foreach (MethodInfo method in methods)
        {
            Console.WriteLine($"{method.ReturnType.Name} {method.Name}");
        }

        // Retrieve and display all constructors of the type
        ConstructorInfo[] constructors = T.GetConstructors(BindingFlags.Public | BindingFlags.Instance);
        Console.WriteLine("Constructors:");
        foreach (ConstructorInfo constructor in constructors)
        {
            Console.WriteLine(constructor.ToString());
        }
    }
}
