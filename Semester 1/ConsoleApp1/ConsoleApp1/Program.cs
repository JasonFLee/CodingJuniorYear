using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)      
        {
            Random rand = new Random();
            List<int> integerlist = new List<int>();

            for (int i = 0;  i < 20; i++)
            {
                integerlist.Add(rand.Next(0, 100));
            }
            for(int b= 0; b <20; b++)
            {
                Console.WriteLine(integerlist[b]);
            }
            Console.ReadLine();
        }
    }
}
