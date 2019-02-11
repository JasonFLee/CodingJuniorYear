using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;
namespace OrderAlgorithm
{
    class Program
    {



        static void Main(string[] args)
        {

            string path = AppDomain.CurrentDomain.BaseDirectory + @"Prob02.in_.txt";

            List<string> file = new List<string>();
            using (StreamReader sr = new StreamReader(path))
            {


                string line;
                while ((line = sr.ReadLine()) != null)
                {

                    file.Add(line);
                }

            }

           
            String[] splittedd = file[2].Split(' ');


            List<int> values1 = new List<int>();

            for (int x = 0; x < splittedd.Length; x++)
            {

               values1.Add(Int32.Parse(splittedd[x]));
              
            }

            for (int x = 0; x < splittedd.Length; x++)
            {

                Console.WriteLine(values1[x]);

            }

            if (values1[0] < values1[1] && values1[1] < values1[2] && values1[2] < values1[3]&& values1[4] < values1[5])
            {
                Console.WriteLine("ITS ACCENDING");
            }

            if (values1[5] < values1[4] && values1[4] < values1[3] && values1[3] < values1[2] && values1[2] < values1[1])
            {
                Console.WriteLine("ITS DECENDING");
            }







            Console.ReadLine();
            //how to split
            //how to make integers








        }



    }
}
