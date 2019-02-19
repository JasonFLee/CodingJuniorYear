using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OrderingSetOfNumberCyber
{
    class Program
    {
        static void Main(string[] args)
        {








            string path = AppDomain.CurrentDomain.BaseDirectory + @"Prob02.in.txt";

            List<string> file = new List<string>();
            using (StreamReader sr = new StreamReader(path))
            {


                string line;
                while ((line = sr.ReadLine()) != null)
                {

                    file.Add(line);
                }

            }


            Console.WriteLine(file[0]);



            for (int x = 0; x < file.Count; x++)
            {
                string revs = "";

                string s = file[x];
                

                for (int i = s.Length - 1; i >= 0; i--)
                {

                    revs = revs + s[i];
                }
                Console.WriteLine(revs);

              
            }
            Console.ReadLine();

            }
    }
}
