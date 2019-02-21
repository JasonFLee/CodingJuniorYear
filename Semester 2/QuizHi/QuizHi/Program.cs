using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizHi
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter your string");
            string givenstring = Console.ReadLine();
            Console.WriteLine("enter your int");
            int givenint = int.Parse(Console.ReadLine());
            Console.WriteLine(stringtimes(givenstring, givenint));
           
           
            Console.ReadLine();
        }

        static string stringtimes( string givenstring, int givenint)
        {
            string s = "";

            for (int u = 0; u < givenint; u++)
            {
                s = s  + givenstring;
            }
            
            return s;
        }
       

    }
}
