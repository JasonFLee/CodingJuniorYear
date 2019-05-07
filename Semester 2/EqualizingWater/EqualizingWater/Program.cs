using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EqualizingWater
{
    class Program
    {

        static void Main(string[] args)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"Prob18.in.txt";

            List<string> file = new List<string>();
            using (StreamReader sr = new StreamReader(path))
            {


                string line;
                while ((line = sr.ReadLine()) != null)
                {

                    file.Add(line);
                }

                string name = file[1];
                string secondname = file[3];
                string givennumbers = file[2].Replace(" ", "");
                int[] givennumberint;
                string givennumbers2 = file[4].Replace(" ", ""); ;
                int[] givennumberint2;




                givennumberint = givennumbers.Select(q => int.Parse(q.ToString())).ToArray();
                int tankcount = (givennumberint[0]);
                Console.WriteLine("Tank Count:" + tankcount);

                givennumberint = givennumberint.Where((source, index) => index != 0).ToArray();
                Array.Sort(givennumberint);
                givennumberint2 = givennumbers.Select(q => int.Parse(q.ToString())).ToArray();



                decimal tank1 = (givennumberint[0]);
                Console.WriteLine("Tank One: " + tank1);
                decimal tank2 = (givennumberint[1]);
                Console.WriteLine("Tank Two: " + tank2);
                decimal tank3 = (givennumberint[2]);
                Console.WriteLine("Tank Three: " + tank3);
                decimal tank4 = (givennumberint[3]);
                Console.WriteLine("Tank Four: " + tank4);
                decimal totalwater = ((tank1 + tank2 + tank3 + tank4));
                Console.WriteLine("Total Water: " + totalwater);
                decimal totalmean = totalwater / tankcount;
                Console.WriteLine("Wanted: " + totalmean + " in each");

                int count = 0;

                decimal difference12 = Math.Abs(tank1 - tank2);
                decimal difference23 = Math.Abs(tank2 - tank3);
                decimal difference34 = Math.Abs(tank3 - tank4);
                decimal difference13 = Math.Abs(tank1 - tank3);
                decimal difference14 = Math.Abs(tank1 - tank4);
                decimal difference24 = Math.Abs(tank2 - tank4);


                if (tank1 != totalmean && (difference12 / 2) + tank1 == totalmean)
                {
                    count = count + 1;
                    tank1 = totalmean;
                    tank2 = totalmean;
                }
                if (tank1 != totalmean && (difference13 / 2) + tank1 == totalmean)
                {
                    count = count + 1;
                    tank1 = totalmean;
                    tank3 = totalmean;
                }
                if (tank1 != totalmean && (difference14 / 2) + tank1 == totalmean)
                {
                    count = count + 1;
                    tank1 = totalmean;
                    tank4 = totalmean;
                }

                if (tank2 != totalmean && (difference23 / 2) + tank2 == totalmean)
                {
                    count = count + 1;
                    tank2 = totalmean;
                    tank3 = totalmean;
                }
                if (tank2 != totalmean && (difference24 / 2) + tank4 == totalmean)
                {
                    count = count + 1;
                    tank2 = totalmean;
                    tank4 = totalmean;
                }
                if (tank3 != totalmean && (difference34 / 2) + tank4 == totalmean)
                {
                    count = count + 1;
                    tank2 = totalmean;
                    tank3 = totalmean;
                }

                Console.WriteLine("You need to switch " + name + " " + count + " times.");

                Console.ReadLine();


            }
        }
    }
}
