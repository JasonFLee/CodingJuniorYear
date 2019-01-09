using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jlee_CompetencyExam
{
    class Program
    {
        static void Main(string[] args)
        {
            


                bool done = false;
                while (done == false)
                {
                Console.WriteLine("_______________________________________________________________");
                    Console.WriteLine("Enter the integer value for the action you want to preform ");
                    Console.WriteLine("1");
                    Console.WriteLine("2");
                    Console.WriteLine("3");
                    Console.WriteLine("4");
                    Console.WriteLine("5");
                    Console.WriteLine("-1");
                Console.WriteLine("_______________________________________________________________");


                string result = Console.ReadLine();
                if (result == "1")
                {
                    Console.WriteLine("whats your grade?");

                    int gradelevel = int.Parse(Console.ReadLine());


                    Console.WriteLine("whats your reading grade level?");
                    int readinggradelevel = int.Parse(Console.ReadLine());
                    if (gradelevel <= 5)
                    {
                        Console.WriteLine("you're a elementary schooler");
                    }
                    else if (gradelevel == 6 || gradelevel == 7 || gradelevel == 8)
                    {
                        Console.WriteLine("you're a middle schooler");
                    }

                    else if (gradelevel == 9 || gradelevel == 10 || gradelevel == 11 || gradelevel == 12)
                    {
                        Console.WriteLine("you're a high schooler");
                    }
                    if (gradelevel <= readinggradelevel)
                    {
                        Console.WriteLine("you are proficeient");
                    }
                    else if (gradelevel >= readinggradelevel)
                    {
                        Console.WriteLine("you are not proficeient");

                    }

                }
                else if (result == "2")
                {

                    Console.WriteLine("enter a number to count by");
                    int numtocountby = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter a number to count up to by " + numtocountby);
                    int numtocountupto = int.Parse(Console.ReadLine());
                    int poopidyscoop = 0;
                    int thisisslowlykillingme = 0;
                    for (poopidyscoop = 0; thisisslowlykillingme < numtocountupto; poopidyscoop++)
                    {
                        thisisslowlykillingme = numtocountby * poopidyscoop;
                        Console.WriteLine(thisisslowlykillingme);
                    }
                }
                else if (result == "3")
                {
                    int sum = 0;
                    int number;
                    do
                    {
                        Console.WriteLine("value:");
                        number = int.Parse(Console.ReadLine());
                        sum = sum + number;
                        Console.WriteLine("the sum is " + sum);
                    } while (number != 0);
                }
                else if (result == "4")
                {

                    int[] Array = new int[10];
                    bool o = true;
                    int i = 0;


                    Console.WriteLine("press 0 to quit)");
                    while (o == true && i < 10)
                    {

                        Console.WriteLine("what number do you want in your array?");
                        int Arraynum = int.Parse(Console.ReadLine());


                        Array[i] = Arraynum;

                        foreach (var item in Array)
                        {

                            Console.Write(item.ToString());
                        }
                        Console.WriteLine("");
                        if (Arraynum == 0)
                        {
                            o = false;
                        }


                        i = i + 1;


                        if(i == 10)
                        {
                            Console.WriteLine("Array Full!");
                        }

                    }
                }
                else if (result == "5")
                {
                    Console.WriteLine("Type 'stop', to stop");

                    List<string> things = new List<string>();
                    bool almostdone = false;
                    for (int p = 0; almostdone == false; p++)
                    {

                        Console.WriteLine("Type in a string");
                        string iteem = Console.ReadLine();
                        if (iteem == "stop")
                        {
                            almostdone = true;
                        }
                        things.Add(iteem);
                        int meh = 0;
                        foreach (string item in things)
                        {
                            meh = meh + 1;
                            Console.Write("Slot " + meh + " has ");
                            Console.WriteLine(item.ToString());
                        }
                    }







                }
                else if (result == "-1")
                {
                    break;
                }

                else
                {
                    Console.WriteLine("PLEASE ENTER A VALID ANSWER");
                }
                }
            }



        }
    }







    

