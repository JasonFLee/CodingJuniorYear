using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace EqualizingWaterSmart
{
    class Program
    {
        static void Main(string[] args)
        {
           

                string path = AppDomain.CurrentDomain.BaseDirectory + @"Prob18COPY.txt";

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
                    decimal[] givennumberint;
                    string givennumbers2 = file[4].Replace(" ", ""); ;
                    decimal[] givennumberint2;




                    givennumberint = givennumbers.Select(q => decimal.Parse(q.ToString())).ToArray();
                    decimal tankcount = (givennumberint[0]);
                    Console.WriteLine("Tank Count:" + tankcount);

                    givennumberint = givennumberint.Where((source, index) => index != 0).ToArray();
                    Array.Sort(givennumberint);
                    givennumberint2 = givennumbers.Select(q => decimal.Parse(q.ToString())).ToArray();

                Console.WriteLine("Problem 1");
                    Console.WriteLine("Tank One: " + givennumberint[0]);

                    Console.WriteLine("Tank Two: " + givennumberint[1]);
                    Console.WriteLine("Tank Three: " + givennumberint[2]);
                    Console.WriteLine("Tank Four: " + givennumberint[3]);
                    decimal totalwater = ((givennumberint[0] + givennumberint[1] + givennumberint[2] + givennumberint[3]));
                    Console.WriteLine("Total Water: " + totalwater);
                    decimal totalmean = totalwater / tankcount;
                    Console.WriteLine("Wanted: " + totalmean + " in each");
               




                int count1 = 0;

                    decimal difference12 = Math.Abs(givennumberint[0] - givennumberint[1]);
                    decimal difference23 = Math.Abs(givennumberint[1] - givennumberint[2]);
                    decimal difference34 = Math.Abs(givennumberint[2] - givennumberint[3]);
                    decimal difference13 = Math.Abs(givennumberint[0] - givennumberint[2]);
                    decimal difference14 = Math.Abs(givennumberint[0] - givennumberint[3]);
                    decimal difference24 = Math.Abs(givennumberint[1] - givennumberint[3]);
           
                    if (givennumberint[0] != totalmean && (difference12 / 2) + givennumberint[0] == totalmean)
                    {
                        count1 = count1 + 1;
                        givennumberint[0] = totalmean;
                        givennumberint[1] = totalmean;
                    }
                    if (givennumberint[0] != totalmean && (difference13 / 2) + givennumberint[0] == totalmean)
                    {
                        count1 = count1 + 1;
                        givennumberint[0] = totalmean;
                        givennumberint[2] = totalmean;
                    }
                    if (givennumberint[0] != totalmean && (difference14 / 2) + givennumberint[0] == totalmean)
                    {
                        count1 = count1 + 1;
                        givennumberint[0] = totalmean;
                        givennumberint[3] = totalmean;
                    }

                    if (givennumberint[1] != totalmean && (difference23 / 2) + givennumberint[1] == totalmean)
                    {
                        count1 = count1 + 1;
                        givennumberint[1] = totalmean;
                        givennumberint[2] = totalmean;
                    }
                    if (givennumberint[1] != totalmean && (difference24 / 2) + givennumberint[3] == totalmean)
                    {
                        count1 = count1 + 1;
                        givennumberint[1] = totalmean;
                        givennumberint[3] = totalmean;
                    }
                    if (givennumberint[2] != totalmean && (difference34 / 2) + givennumberint[3] == totalmean)
                    {
                        count1 = count1 + 1;
                        givennumberint[1] = totalmean;
                        givennumberint[2] = totalmean;
                    }

                    Console.WriteLine("You need to switch " + name + " " + count1 + " times.");
                Console.ReadLine();
                }



            }
        }
    }


    

