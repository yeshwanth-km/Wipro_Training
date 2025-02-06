using Delegates;

namespace Delegates
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){ Empid = 1, Name = "Sai", experienceinyears = 2, salary = 50000 },
                new Employee(){ Empid = 2, Name = "Kiran", experienceinyears = 6, salary = 80000 },
                new Employee(){ Empid = 3, Name = "Smaran", experienceinyears = 5, salary = 50000 },
                new Employee(){ Empid = 4, Name = "Pooja", experienceinyears = 7, salary = 80000 },
                new Employee(){ Empid = 5, Name = "Manas", experienceinyears = 3, salary = 50000 },
                new Employee(){ Empid = 6, Name = "SriRam", experienceinyears = 8, salary = 90000 }
            };

            DelPromote delpromote = IsPromote; // Delegate instance

            // Calling the method to promote employees
            Employee.PromoteEmployees(employees, delpromote);
        }

        static bool IsPromote(Employee emp)
        {
            return emp.salary > 50000; // Simplified return statement
        }
    }



}

