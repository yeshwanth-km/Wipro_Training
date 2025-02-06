using System;

namespace DelegateExample
{
    class Program
    {
        // Delegate definition
        delegate int Operation(int a, int b);

        static int PerformOperation(int a, int b, Operation operation)
        {
            return operation(a, b);
        }

        static void Main(string[] args)
        {
            try
            {
                // Input handling
                Console.WriteLine("Enter first number:");
                if (!int.TryParse(Console.ReadLine(), out int num1))
                {
                    Console.WriteLine("Invalid input for the first number. Please enter an integer.");
                    return;
                }

                Console.WriteLine("Enter second number:");
                if (!int.TryParse(Console.ReadLine(), out int num2))
                {
                    Console.WriteLine("Invalid input for the second number. Please enter an integer.");
                    return;
                }

                Console.WriteLine("Enter operation (add, subtract, multiply, divide):");
                string operation = Console.ReadLine().ToLower();

                // Lambda expressions for operations
                Operation op = operation switch
                {
                    "add" => (a, b) => a + b,
                    "subtract" => (a, b) => a - b,
                    "multiply" => (a, b) => a * b,
                    "divide" => (a, b) => b == 0 ? throw new DivideByZeroException("Cannot divide by zero.") : a / b,
                    _ => null
                };

                // If no valid operation is matched
                if (op == null)
                {
                    Console.WriteLine("Invalid operation. Please choose from add, subtract, multiply, or divide.");
                    return;
                }

                // Perform the operation and display the result
                int result = PerformOperation(num1, num2, op);
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error occurred: {ex.Message}");
            }
        }
    }
}
