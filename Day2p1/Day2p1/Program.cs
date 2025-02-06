using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2p1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String str = "hello";
            Console.WriteLine(str);
            str += "world";
            Console.WriteLine(str);
            StringBuilder sb = new StringBuilder("hi");
            sb.Append("Raj");
            Console.WriteLine(sb);
            String userip = Console.ReadLine();
            Console.WriteLine(userip);
            Console.WriteLine("enter string to append:");
            String appstr = Console.ReadLine();
            Console.WriteLine(appstr);
            StringBuilder sbobj = new StringBuilder(Console.ReadLine());
            sbobj.Append(appstr);
            Console.WriteLine(sbobj);
        }
    }
}
