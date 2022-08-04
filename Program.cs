
using LogicaalProblems;
using LogicalPrograms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
   public  class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical Problems ");
            Console.WriteLine("Enter your choice ");
            Console.WriteLine(".............................................");
            Console.WriteLine("1 For: Fibonacci Series ");
            Console.WriteLine("2 For: Perfect Number ");
            Console.WriteLine("3 For: Prime Number ");
            Console.WriteLine("4 For: Reverse Number ");
            int selection = Convert.ToInt32(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    FibbonacciSeries FibboSeries = new FibbonacciSeries();
                    FibboSeries.CalculateFibonacciSeries();
                    break;
                case 2:
                    PerfectNumber PerfectNum = new PerfectNumber();
                    PerfectNum.CheckPerfectNumber();
                    break;
                case 3:
                    PrimeNo Primenumber = new PrimeNo();
                    Primenumber.CheckPrimeNumber();
                    break;
                case 4:
                    ReverseNumber reverseNum = new ReverseNumber();
                    reverseNum.Reversenumber();
                    break;
                default:
                    Console.WriteLine("Invalid Selection");
                    break;
            }
            Console.ReadLine();
        }
    }
}