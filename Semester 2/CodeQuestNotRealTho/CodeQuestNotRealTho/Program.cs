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
                //string firstLine = sr.ReadLine();
                //string secondline = sr.ReadLine();
                //string thirdLine = sr.ReadLine();
                //string fourthline = sr.ReadLine();
                //string fifthline = sr.ReadLine();
                //string sixthline = sr.ReadLine();
                //string seventhline = sr.ReadLine();
                //string eigthline = sr.ReadLine();

                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    file.Add(line);
                }
                float total = 0;
         
              


                Console.WriteLine(line[5]);
               
                Console.ReadLine();




            }


        }
            

        
    }
}
