using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class ReverseNumber
    {
        public int Number;
        public int Reverse;
        public int Remainder;
        public void Reversenumber()
        {
            Console.WriteLine("Enter a No. to reverse"); 
            Number = int.Parse(Console.ReadLine()); 
            Reverse = 0; 
            while (Number > 0) 
            {
                Remainder = Number % 10;  
                Reverse = (Reverse * 10) + Remainder; 
                Number = Number / 10; 
            }
            Console.WriteLine("Reverse No. is {0}", Reverse);
            Console.ReadLine();
        }
    }
}