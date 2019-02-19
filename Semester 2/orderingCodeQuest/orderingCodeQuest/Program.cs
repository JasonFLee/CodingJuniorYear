using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace orderingCodeQuest
{
    class Program
    {
        static void Main(string[] args)
        {

           

                string path = AppDomain.CurrentDomain.BaseDirectory + @"Prob01.in.txt";

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
            Console.ReadLine();

            List<int> listints = new List<int>();

            string phrase = file[0];
            string[] words = phrase.Split(' ');

            
           for(int x = 0; x > 9; x++)
            {
                listints[x] = int.Parse(words[x]);
            }
            foreach (var word in words)
            {
                System.Console.WriteLine($"<{word}>");
            }


        }
    }
}
