using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    class Program
    {
        static void Main(string[] args)
        {
            string given = Console.ReadLine();

            given.Select(q => new string(q, 1)).ToArray();
            Console.WriteLine(given[0]);
            Console.ReadLine();
        }
    }
}
