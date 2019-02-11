using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CodeQuestNotRealTho
{
    class Program
    {
      


            static void Main(string[] args)
            {

               string path = AppDomain.CurrentDomain.BaseDirectory + @"Prob01.in_.txt";

            List<string> file = new List<string>();
            using (StreamReader sr = new StreamReader(path))
            {
             
                
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    file.Add(line);
                }

            }
            float total = 0;
            for (int x = 0; x < file.Count; x++)
            {
                string s = file[x];

              

                if (s.Contains("QUARTER="))
                {
                    s = s.Substring(8);
                    total = total +float.Parse(s) * .25f;

                }
                if (s.Contains("HALFDOLLAR="))
                {
                    s = s.Substring(11);
                    total = total + float.Parse(s) * .5f;

                }
                if (s.Contains("DIME="))
                {
                    s = s.Substring(5);
                    total = total + float.Parse(s) * .1f;

                }
                if (s.Contains("NICKEL="))
                {
                    s = s.Substring(7);
                    total = total + float.Parse(s) * .05f;

                }
                if (s.Contains("PENNY="))
                {
                    s = s.Substring(6);
                    total = total + float.Parse(s) * .01f;

                }

            }


            string meh = "";

            if(total % 10 > 0)
            {
                meh = "0";
            }
            else
            {
                meh = " ";
            }

            Console.WriteLine("$ " + total+ meh );

            Console.ReadLine();




        }



    }
}
