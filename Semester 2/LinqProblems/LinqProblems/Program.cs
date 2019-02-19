using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProblems
{
    class Program
    {
        static void Main(string[] args)
        {


            //Finds palendrome
            //do
            //{

            //    string s = "";
            //    string revs = "";
            //    Console.WriteLine("Enter string");
            //    s = Console.ReadLine();
            //    s = s.Replace(" ", "");
            //    s = s.Replace("?", "");
            //    s = s.Replace("@", "");
            //    s = s.Replace(".", "");
            //    s = s.Replace("!", "");


            //    for (int i = s.Length - 1; i >= 0; i--)
            //    {

            //        revs = revs + s[i];
            //    }

            //    if (revs == s)
            //    {
            //        Console.WriteLine("PALINDROME");
            //    }
            //    else
            //    {
            //        Console.WriteLine("NOT PALINDROME");
            //    }

            //} while (true);
            do
            {
                Console.WriteLine("Enter string");
                string s = Console.ReadLine();
              
                if (new string(s.Reverse().ToArray() )== s)
                {
                    Console.WriteLine("PALINDROME");
                }
                else
                {
                    Console.WriteLine("Not Palindrome");
                }
            } while (true);



        }
    }
}
