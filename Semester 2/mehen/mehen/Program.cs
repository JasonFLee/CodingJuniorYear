using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mehen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What numbers do you want to encode?");
            string given = Console.ReadLine();



            int[] intArray = new int[given.Length];
            for (int i = 0; i < given.Length; i++)
            {
                intArray[i] = int.Parse(given);
               
            }
            Console.WriteLine(intArray[3]);
        }
    }
}
