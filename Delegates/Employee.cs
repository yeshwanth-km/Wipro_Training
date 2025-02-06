﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate bool DelPromote(Employee emp);

    public class Employee
    {
        public int Empid { get; set; }
        public string Name { get; set; }
        public int experienceinyears { get; set; }
        public decimal salary { get; set; }

        public static void PromoteEmployees(List<Employee> lstemps, DelPromote isPromotable)
        {
            foreach (var emp in lstemps.Where(e => isPromotable(e)))
            {
                Console.WriteLine($"{emp.Name} is Promoted");
            }
        }

    }
}
