using System;
using System.Threading;

internal class Program
{
    private static int oddCount = 0;
    private static int evenCount = 0;
    private static readonly object lockObject = new object();

    // Increment odd numbers
    static void IncrementOddCount()
    {
        for (int i = 1; i <= 1000; i += 2)
        {
            lock (lockObject) // Lock the critical section
            {
                oddCount++;
                Console.WriteLine($"Odd Count: {oddCount}");
            }
        }
    }

    // Increment even numbers
    static void IncrementEvenCount()
    {
        for (int i = 2; i <= 1000; i += 2)
        {
            lock (lockObject) // Lock the critical section
            {
                evenCount++;
                Console.WriteLine($"Even Count: {evenCount}");
            }
        }
    }

    private static void Main(string[] args)
    {
        // Creating threads for odd and even count increment
        Thread oddThread = new Thread(IncrementOddCount);
        Thread evenThread = new Thread(IncrementEvenCount);

        // Start the threads
        oddThread.Start();
        evenThread.Start();

        // Wait for threads to complete
        oddThread.Join();
        evenThread.Join();

        // Output the final counts
        Console.WriteLine($"Final Odd Count: {oddCount}");
        Console.WriteLine($"Final Even Count: {evenCount}");
        Console.WriteLine($"Total Count: {oddCount + evenCount}");
    }
}
