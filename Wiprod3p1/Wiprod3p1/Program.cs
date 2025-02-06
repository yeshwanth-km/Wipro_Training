using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiprod3p1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the ProductId");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the ProductName");
            string nm = Console.ReadLine();

            Product product = new Product(id, nm);
            product.PublicMthd();


            Customer cust = new Customer();
            Console.WriteLine("Enter the CustomerId");
            cust.custId = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Enter the CustomerName");
            cust.custName = Console.ReadLine();

            cust.Display();
        }
    }
}
