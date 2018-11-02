using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WHAT IS THE DECIMAL? ");
            int decimal_ = int.Parse(Console.ReadLine());
            if(decimal_ < 0)
            {
               decimal_=  Math.Abs(decimal_);
            }
            Console.WriteLine("WHAT IS THE BASE? ");
            int base_ = int.Parse(Console.ReadLine());
            if (2 > base_ || base_ > 32)
            {
                Console.WriteLine("no");
                Console.ReadLine();
            }
            
            else
            {
                int remainder;
                string result = string.Empty;
                while (decimal_ > 0)
                {
                    remainder = decimal_ % base_;
                    decimal_ = decimal_ / base_;
                    result = remainder.ToString() + result;
                }
                Console.WriteLine("BINARY IS " + result);
                Console.ReadLine();
            }
            
        }
    }
}
