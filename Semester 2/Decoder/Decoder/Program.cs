using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;
namespace Decoder
{
    class Program
    {



        static void Main(string[] args)
        {

            string path = AppDomain.CurrentDomain.BaseDirectory + @"Prob03.in_ (1).txt";

            List<string> file = new List<string>();
            using (StreamReader sr = new StreamReader(path))
            {


                string line;
                while ((line = sr.ReadLine()) != null)
                {

                    file.Add(line);
                }

            }
            //CODE


            String[] splited = file[0].Split(' ');

            
            Console.WriteLine(splited[0]);

            for (int y = 0; y < file.Count; y++)
            {


            }



            Console.ReadLine();

        }
    }
}