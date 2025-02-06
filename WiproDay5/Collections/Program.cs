using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                // Creating a List and adding elements to it
                List<object> list = new List<object>();
                list.Add(111); // Boxing
                list.Add("Wipro");
                list.Add(true);

                // Printing all elements in the List
                Console.WriteLine("Elements in List:");
                foreach (object i in list)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("Capacity of List: " + list.Capacity);
                Console.WriteLine("Number of items in List: " + list.Count);
                Console.WriteLine();

                // Adding a range of elements to the List
                string[] cities = { "Chennai", "Bangalore", "Hyderabad", "Bihar" };
                list.AddRange(cities);

                // Printing the updated List
                Console.WriteLine("Updated List after AddRange:");
                foreach (object i in list)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine();

                // Printing capacity and count
                Console.WriteLine("Capacity of List: " + list.Capacity);
                Console.WriteLine("Number of items in List: " + list.Count);

                // Inserting an element at index 1
                list.Insert(1, 1000);

                // Printing the List after insertion
                Console.WriteLine("List after Insert:");
                foreach (object i in list)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine();

                // Inserting a range of elements at index 3
                int[] ar = { 10, 20, 30 };
                list.InsertRange(3, ar);

                // Printing the List after InsertRange
                Console.WriteLine("List after InsertRange:");
                foreach (object i in list)
                {
                    Console.WriteLine(i);
                }

                // Printing capacity and count
                Console.WriteLine("Capacity of List: " + list.Capacity);
                Console.WriteLine("Number of items in List: " + list.Count);

                // Removing an element
                Console.WriteLine("\nList after Remove 'Chennai':");
                list.Remove("Chennai");
                foreach (object i in list)
                {
                    Console.WriteLine(i);
                }

                // Removing an element at a specific index
                Console.WriteLine("\nList after RemoveAt(2):");
                list.RemoveAt(2);
                foreach (object i in list)
                {
                    Console.WriteLine(i);
                }

                // Removing a range of elements
                Console.WriteLine("\nList after RemoveRange(1, 3):");
                list.RemoveRange(1, 3);
                foreach (object i in list)
                {
                    Console.WriteLine(i);
                }

                // Updating an element
                Console.WriteLine("\nList after updating index 1:");
                list[1] = "Update";
                foreach (object i in list)
                {
                    Console.WriteLine(i);
                }

                // Checking if an element exists in the List
                Console.WriteLine("\nList contains 'bangalore': " + list.Contains("bangalore"));

                // Creating a List of integers
                List<int> intList = new List<int>();
                intList.Add(111);
                intList.Add(112); // No boxing needed here, it's a value type

                // Printing the List of integers
                Console.WriteLine("\nList of integers (no boxing/unboxing needed):");
                foreach (int item in intList)
                {
                    Console.WriteLine(item); // Directly prints integers without unboxing
                }

                // Conclusion
                Console.WriteLine("\nNote: Generic collections like List<T> offer better performance than non-generic collections because they avoid boxing/unboxing.");
            }
        }
    }

