using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2p2
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Enter the number of teams:");
                int teams = Convert.ToInt32(Console.ReadLine());

                int[][] jaggedArray = new int[teams][]; // Create jagged array with size teams

                // Reading scores
                for (int i = 0; i < teams; i++)
                {
                    Console.WriteLine($"Number of rounds played by team {i + 1}:");
                    int rounds = Convert.ToInt32(Console.ReadLine());

                    // Create an array for the rounds within the jagged array
                    jaggedArray[i] = new int[rounds];

                    Console.WriteLine($"Enter the scores for each round for team {i + 1}:");
                    for (int j = 0; j < rounds; j++)
                    {
                        jaggedArray[i][j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                // Display the scores
                Console.WriteLine("\nScores of all teams:");
                for (int i = 0; i < jaggedArray.Length; i++)
                {
                    Console.Write($"Team {i + 1}: ");
                    for (int j = 0; j < jaggedArray[i].Length; j++)
                    {
                        Console.Write(jaggedArray[i][j] + " ");
                    }
                    Console.WriteLine();
                }
            // Calculate and display each team's total score
            Console.WriteLine("\nTotal scores of each team:");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                int totalScore = 0;
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    totalScore += jaggedArray[i][j];
                }
                Console.WriteLine($"Team {i + 1}: {totalScore}");
            }



        }
    }
    
}
