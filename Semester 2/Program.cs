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

            string path = AppDomain.CurrentDomain.BaseDirectory + @"Prob02.in_ (2).txt";

            List<string> file = new List<string>();
            using (StreamReader sr = new StreamReader(path))
            {


                string line;
                while ((line = sr.ReadLine()) != null)
                {

                    file.Add(line);
                }

            }


            //start cpde

            

            for (int y = 0; y < file.Count; y++)
            {
                //do for each line
                String[] splittedd = file[y].Split(' ');
                List<int> values1 = new List<int>();
                bool isValid = true;
                foreach (String s in splittedd)
                {
                    int output;
                    if (int.TryParse(s, out output))
                    {
                        values1.Add(output);
                    }
                    else
                    {
                        Console.WriteLine("invalid");
                        isValid = false;
                        break;
                    }
                }

                if (isValid == false)
                {

                    continue;
                }

                bool isaccedning = true;
                bool isdecending = true;



                //checking for assending
                for (int i = 0; i < values1.Count - 1; i++)
                {
                    if(!(values1[i] < values1[i + 1]))
                    {
                        isaccedning = false;
                    }
                }

                if( isaccedning== true)
                {
                    Console.WriteLine("Accending");
                }


                //check for descending
                for (int i = 0; i < values1.Count - 1; i++)
                {
                    if (!(values1[i] > values1[i + 1]))
                    {
                        isdecending = false;
                        break;
                    }


                }
                if (isdecending == true)
                {
                    Console.WriteLine("Decending");
                }


                if (isaccedning == false && isdecending == false)
                {
                    Console.WriteLine("It's Random");
                }


            }







            

            

            //for (int y = 0; y < file.Count; y++)
            //{
            //    if (file[y].Contains("(") || file[y].Contains("=") || file[y].Contains("%") || file[y].Contains("_") || file[y].Contains("^") || file[y].Contains("-"))
            //    {
            //        break;
            //    }
            //}
               


            //for (int x = 0; x < splittedd.Length; x++)
            //{

            //    values1.Add(Int32.Parse(splittedd[x]));

            //}

            //for (int x = 0; x < splittedd.Length; x++)
            //{

            //    Console.WriteLine(values1[x]);

            //}

           


            //if (values1[0] < values1[1] && values1[1] < values1[2] && values1[2] < values1[3] && values1[4] < values1[5])
            //{
            //    Console.WriteLine("ITS ACCENDING");
            //}

            //else if (values1[5] < values1[4] && values1[4] < values1[3] && values1[3] < values1[2] && values1[2] < values1[1])
            //{
            //    Console.WriteLine("ITS DECENDING");
            //}
            //else
            //{
            //    Console.WriteLine("ITS RANDOM");
            //}






            Console.ReadLine();
      








        }



    }
}
