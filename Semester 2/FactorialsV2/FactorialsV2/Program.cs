using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;
namespace FactorialsV2
{
    class Program
    {



        static void Main(string[] args)
        {

     
           


           


            string path = AppDomain.CurrentDomain.BaseDirectory + @"Prob04.in_.txt";

            List<string> file = new List<string>();
            using (StreamReader sr = new StreamReader(path))
            {


                string line;
                while ((line = sr.ReadLine()) != null)
                {

                    file.Add(line);
                }

            }
            List<int> values = new List<int>();

            float total = 1;


           
                for (int i = 1; i <= file.Count; i++)
                {
                    total = total * i;
                Console.WriteLine(total);
             }

               
               

            









            Console.ReadLine();

        }
    }
}



