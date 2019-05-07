using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dynamicvariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] hello = {5,7 };
           
            for(int x =  0; x < 2; x++)
            {
                Console.WriteLine(hello[x] + 5);
            }
            Console.ReadLine();
        }
    }
}
