using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrgrams
{
    class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical Problems ");
            Console.WriteLine("Enter your choice ");
            Console.WriteLine(".............................................");
            Console.WriteLine("1 For: Fibonacci Series ");
            int selection = Convert.ToInt32(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    FibbonacciSeries FibboSeries = new FibbonacciSeries();
                    FibboSeries.CalculateFibonacciSeries();
                    break;
                default:
                    Console.WriteLine("Invalid Selection.select 1");
                    break;
            }
            Console.ReadLine();
        }
    }
}