using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace UsesTextFiles
{
    class Program
    {
        static void Main(string[] args)
        {
           
 string path = @"C:\Users\142084\OneDrive - Academy District 20\C#\WillIWinOrLooseTheFight.txt";





            using (StreamWriter sw = new StreamWriter(path))
            {
                int x=0;
                Random rand = new Random();
                int dice = rand.Next(0, 2);
                if(dice == 0)
                {
                    do
                    {
                        x = x + 1;
                        sw.WriteLine("W");
                    } while (x < 100);
                }
                else if (dice == 1)
                {
                    do
                    {
                        x = x + 1;
                        sw.WriteLine("L");
                    } while (x < 100);
                }

            }
            path = AppDomain.CurrentDomain.BaseDirectory + @"Example.txt";

          
        }
        static void eternalize()
        {
            string path = @"C:\Users\142084\OneDrive - Academy District 20\C#\WillIWinOrLooseTheFight.txt";

            List<string> file = new List<string>();
            using (StreamReader sr = new StreamReader(path))
            {
                string firstLine = sr.ReadLine();
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    file.Add(line);
                }
            }
        }




       

    }
}
