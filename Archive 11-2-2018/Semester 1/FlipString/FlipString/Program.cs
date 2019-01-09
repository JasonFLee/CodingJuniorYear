using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipString
{
    class Program
    {
        static void Main(string[] args)
        {
           
            do
            {
          
                string s = "";
                string revs = "";
                Console.WriteLine("Enter string");
                s = Console.ReadLine();
                s = s.Replace(" ", "");
                s = s.Replace("?", "");
                s = s.Replace("@", "");
                s = s.Replace(".", "");
                s = s.Replace("!", "");

                //Console.WriteLine(revs);
                for (int i = s.Length - 1; i >= 0; i--)   
                {
                    
                    revs = revs + s[i];
                }
                //Console.WriteLine(revs);
                if (revs == s)
                {
                    Console.WriteLine("PALINDROME");
                }
                else
                {
                    Console.WriteLine("NOT PALINDROME");
                }
               
            } while (true);
        }
    }
}
