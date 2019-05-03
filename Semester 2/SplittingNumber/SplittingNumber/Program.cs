using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplittingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string given = Console.ReadLine();
            for (int x = 0; x < given.Length; x++)
            {
                char v = given[x];
                int n = Convert.ToInt32(new string(v, 1));

             


                Console.Write(n);
            }

        }
    }
}
