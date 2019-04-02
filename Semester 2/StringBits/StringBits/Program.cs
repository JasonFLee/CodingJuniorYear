using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your string");
            string given = Console.ReadLine();
        
            for(int x = 0; x<given.Length; x++)
            {
                if(x % 2 == 0)
                {
                    Console.Write(given[x]);
                }
            }

            Console.ReadLine();

        }
    }
}
