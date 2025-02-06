using System;

namespace ReflectionConcept
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        // Default constructor
        public Employee()
        {
            Console.WriteLine("Default constructor invoked.");
        }

        // Parameterized constructor
        public Employee(int ID, string Name, string Address)
        {
            this.Id = ID;
            this.Name = Name;
            this.Address = Address;
        }

        // Public methods
        public void PrintID()
        {
            Console.WriteLine("Display ID: " + Id);
        }

        public void PrintName()
        {
            Console.WriteLine("Display Name: " + Name);
        }
    }
}
