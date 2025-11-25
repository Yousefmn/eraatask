using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace eraatask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int small, larg;
            double tax = 0.06;

            Console.WriteLine("Estimate for carpet cleaning service");

            Console.Write("Number of small carpets: ");
            small = int.Parse(Console.ReadLine());

            Console.Write("Number of large carpets: ");
            larg = int.Parse(Console.ReadLine());

            Console.WriteLine("Price per small room: $25");
            Console.WriteLine("Price per large room: $35");

            int cost = (small * 25) + (larg * 35);
            Console.WriteLine($"Cost: ${cost}");

            double taxAmount = cost * tax;
            Console.WriteLine($"Tax: ${taxAmount}");

            Console.WriteLine("=================================");

            double total = cost + taxAmount;
            Console.WriteLine($"Total estimate: ${total}");

            Console.WriteLine("This estimate is valid for 30 days");


        }
    }
}
