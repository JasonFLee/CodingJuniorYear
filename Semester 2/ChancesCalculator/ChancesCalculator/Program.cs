using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ChancesCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"reltionship.txt";
            List<string> file = new List<string>();
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    file.Add(line);
                }
            }
            Console.WriteLine("Toxic Relationship Calculator: " +
                "Type in yes or no");

            float point = 0;
            float total = file.Count;
            bool good = false;
            Random rnd = new Random();
           
            for (int x = 0; x < 20; x++)
            {
                int randomquestion = rnd.Next(1, file.Count);
                string lastletter = file[randomquestion].Substring(file[randomquestion].Length - 1);
                if (lastletter == "g")
                {
                    good = true;
                }
                if (lastletter == "b")
                {
                    good = false;
                }
                file[randomquestion] = file[randomquestion].Replace(".", "?");
                int index = file[randomquestion].IndexOf("?");
                if (index > 0)
                {
                    file[randomquestion] = file[randomquestion].Substring(0, index + 1);
                }
                Console.Write("Do they ");
                Console.WriteLine(file[randomquestion]);

                string result = Console.ReadLine(); 
                if (good == true)
                {
                    if (result == "yes")
                    {
                        point = point + 1;
                    }
                }
                if (good == false)
                {
                    if (result == "no")
                    {
                        point = point + 1;
                    }
                }
            }
           if( System.Math.Round(point / total * 100)  < 10 && System.Math.Round(point / total * 100) >= 0)
            {
                Console.WriteLine("GET OUT OF THERE. GRAB THE KIDS. LEAVE TOMMOROW MORNING!");
            }
            if (System.Math.Round(point / total * 100) < 30 && System.Math.Round(point / total * 100) >= 10)
            {
                Console.WriteLine("lol. leave now or live in a perpetual misery");
            }
            if (System.Math.Round(point / total * 100) < 50 && System.Math.Round(point / total * 100) >= 30)
            {
                Console.WriteLine("it's probobly time to leave");
            }
            if (System.Math.Round(point / total * 100) < 70 && System.Math.Round(point / total * 100) >= 50)
            {
                Console.WriteLine("it's rocky but it's not over yet");
            }
            if (System.Math.Round(point / total * 100) < 100 && System.Math.Round(point / total * 100) >= 70)
            {
                Console.WriteLine("Looks healthy, keep up the good work");
            }

           
            Console.ReadLine();
        }

    }
}
