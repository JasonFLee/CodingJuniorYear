using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemovingFromList
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] myIntArray = new int[10];
            for (int i =0; i < myIntArray.Length; i++)
            {
                myIntArray[i] = i;
            }
            foreach (int i in myIntArray)
            {
                Console.WriteLine(myIntArray[i]);
            }
            foreach (int i in myIntArray)
            {
                myIntArray[i] = 0;
                Console.WriteLine(myIntArray[i]);
            }
            Console.WriteLine(myIntArray[9]);
            Console.ReadLine();
        }
    }
}
