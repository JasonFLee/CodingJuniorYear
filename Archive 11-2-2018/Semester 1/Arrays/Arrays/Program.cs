using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int data;
            int[] intArray = new int[10];
            for (int i = 0; i < 10; i++)
            {
                 data = intArray[i] * 2 + 1;
                Console.WriteLine(data);
            }
            
            Console.ReadLine();
        }
    }
}
