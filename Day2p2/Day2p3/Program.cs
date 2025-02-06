using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2p3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                // Prompt user to enter the number of rows
                Console.WriteLine("Enter the number of rows:");
                int numberOfRows = int.Parse(Console.ReadLine());

                // Prompt user to enter the number of columns
                Console.WriteLine("Enter the number of columns:");
                int numberOfColumns = int.Parse(Console.ReadLine());

                // Declare a 2D array with the given dimensions
                int[,] matrix = new int[numberOfRows, numberOfColumns];

                // Read values into the 2D array
                Console.WriteLine("Enter the elements of the matrix:");
                for (int row = 0; row < numberOfRows; row++)
                {
                    for (int column = 0; column < numberOfColumns; column++)
                    {
                        Console.Write($"Element[{row},{column}]: ");
                        matrix[row, column] = int.Parse(Console.ReadLine());
                    }
                }

                // Display the matrix
                Console.WriteLine("\nThe matrix is:");
                for (int row = 0; row < numberOfRows; row++)
                {
                    for (int column = 0; column < numberOfColumns; column++)
                    {
                        Console.Write(matrix[row, column] + " ");
                    }
                    Console.WriteLine();
                }

                // Calculate the sum of all elements in the matrix
                int sum = 0;
                for (int row = 0; row < numberOfRows; row++)
                {
                    for (int column = 0; column < numberOfColumns; column++)
                    {
                        sum += matrix[row, column];
                    }
                }

                // Display the sum of all elements
                Console.WriteLine($"\nThe sum of all elements in the matrix is: {sum}");
            
        }
    }
    
}
