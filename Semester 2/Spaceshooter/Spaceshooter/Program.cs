using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;






namespace Spaceshooter
{
    class Program
    {
        static int allowedtime = 10;
        static void Main(string[] args)
        {
            string[,] multiDimentionalArray = new String[3, 3];
            for (int i = 0; i < multiDimentionalArray.GetLength(0); i++)
            {
                for (int j = 0; j < multiDimentionalArray.GetLength(1); j++)
                {

                    multiDimentionalArray[i, j] = " ";
                }
            }


            multiDimentionalArray[1, 1] = "V";
            DrawBoard(multiDimentionalArray);
            
            

            string input;
            
            Stopwatch stopwatch = new Stopwatch();
            do
            {
                Random rnd = new Random();
                int random = rnd.Next(1,4);
                Console.WriteLine("watch out for column " + random);
                stopwatch.Start();
                Console.WriteLine("Which way do you want to move?");
                input = Console.ReadLine();
                stopwatch.Stop();
                int stopwatchtime = (int)stopwatch.Elapsed.TotalSeconds;
                if (allowedtime > 2)
                {
                    allowedtime = allowedtime - 1;
                }

                if (stopwatchtime > allowedtime)
                {
                    Console.WriteLine("you ran out of time");
                    Console.ReadLine();
                            break;
                }
               
                
                //increment

                int slot = 0;

                


                

                //if in middle
                if (input == "up" && multiDimentionalArray[1, 1] == "V")
                {
                    multiDimentionalArray[0, 1] = "V";
                    multiDimentionalArray[1, 1] = " ";
                    DrawBoard(multiDimentionalArray);
                     slot = 2;
                }
                else if (input == "down" && multiDimentionalArray[1, 1] == "V")
                {
                    multiDimentionalArray[2, 1] = "V";
                 
                    multiDimentionalArray[1, 1] = " ";
                    slot = 2;
                    DrawBoard(multiDimentionalArray);
                    
                }
                else if (input == "left" && multiDimentionalArray[1, 1] == "V")
                {
                    multiDimentionalArray[1, 0] = "V";
                  
                    multiDimentionalArray[1, 1] = " ";
                    slot = 1;
                    DrawBoard(multiDimentionalArray);
                    
                }
                else if (input == "right" && multiDimentionalArray[1, 1] == "V")
                {
                    multiDimentionalArray[1, 2] = "V";
                    multiDimentionalArray[1, 1] = " ";
                    slot = 3;
                    DrawBoard(multiDimentionalArray);
                   

                }
                //if in left upper corner
                else if (input == "down" && multiDimentionalArray[0, 0] == "V")
                {
                    multiDimentionalArray[1, 0] = "V";
                    multiDimentionalArray[0, 0] = " ";
                    slot = 1;
                    DrawBoard(multiDimentionalArray);
                   
                }
                else if (input == "right" && multiDimentionalArray[0, 0] == "V")
                {
                    multiDimentionalArray[0, 1] = "V";
                   
                    multiDimentionalArray[0, 0] = " ";
                    slot = 2;
                    DrawBoard(multiDimentionalArray);
                   
                }
                //if in 0,1
                else if (input == "left" && multiDimentionalArray[0, 1] == "V")
                {
                    multiDimentionalArray[0, 0] = "V";
                   
                    multiDimentionalArray[0, 1] = " ";
                    slot = 1;
                    DrawBoard(multiDimentionalArray);
                   
                }
                else if (input == "right" && multiDimentionalArray[0, 1] == "V")
                {
                    multiDimentionalArray[0, 2] = "V";
                  
                    multiDimentionalArray[0, 1] = " ";
                    slot = 3;
                    DrawBoard(multiDimentionalArray);
                   
                }
                else if (input == "down" && multiDimentionalArray[0, 1] == "V")
                {
                    multiDimentionalArray[1, 1] = "V";
                  
                    multiDimentionalArray[0, 1] = " ";
                    slot = 2;
                    DrawBoard(multiDimentionalArray);
                   
                }
                //if in 0,2
                else if (input == "left" && multiDimentionalArray[0, 2] == "V")
                {
                    multiDimentionalArray[0, 1] = "V";
                    
                    multiDimentionalArray[0, 2] = " ";
                    slot = 2;
                    DrawBoard(multiDimentionalArray);
                    
                }
                else if (input == "down" && multiDimentionalArray[0, 2] == "V")
                {
                    multiDimentionalArray[1, 2] = "V";
                    
                    multiDimentionalArray[0, 2] = " ";
                    DrawBoard(multiDimentionalArray);
                    slot = 3;

                }
                // if in 1,0
                else if (input == "up" && multiDimentionalArray[1, 0] == "V")
                {
                    multiDimentionalArray[0, 0] = "V";
                    
                    multiDimentionalArray[1, 0] = " ";
                    slot = 1;
                    DrawBoard(multiDimentionalArray);
                }
                else if (input == "down" && multiDimentionalArray[1, 0] == "V")
                {
                    multiDimentionalArray[2, 0] = "V";
                  
                    multiDimentionalArray[1, 0] = " ";
                    slot = 1;
                    DrawBoard(multiDimentionalArray);
                }
                else if (input == "right" && multiDimentionalArray[1, 0] == "V")
                {
                    multiDimentionalArray[1, 1] = "V";
                   
                    multiDimentionalArray[1, 0] = " ";
                    slot = 2;
                    DrawBoard(multiDimentionalArray);
                }
                //if in 1,2
                else if (input == "left" && multiDimentionalArray[1, 2] == "V")
                {
                    multiDimentionalArray[1, 1] = "V";
                    
                    multiDimentionalArray[1, 2] = " ";
                    slot = 2;
                    DrawBoard(multiDimentionalArray);
                }
                else if (input == "up" && multiDimentionalArray[1, 2] == "V")
                {
                    multiDimentionalArray[0, 2] = "V";
                   
                    multiDimentionalArray[1, 2] = " ";
                    slot = 3;
                    DrawBoard(multiDimentionalArray);
                }
                else if (input == "down" && multiDimentionalArray[1, 2] == "V")
                {
                    multiDimentionalArray[2, 2] = "V";
                    

                    multiDimentionalArray[1, 2] = " ";
                        slot = 3; 
                    DrawBoard(multiDimentionalArray);
                }

                //if in 2,0
                else if (input == "up" && multiDimentionalArray[2, 0] == "V")
                {
                    multiDimentionalArray[1, 0] = "V";
                    
                    multiDimentionalArray[2, 0] = " ";
                    slot = 1;
                    DrawBoard(multiDimentionalArray);
                }
                else if (input == "right" && multiDimentionalArray[2, 0] == "V")
                {
                    multiDimentionalArray[2, 1] = "V";
                    

                    multiDimentionalArray[2, 0] = " ";
                    slot = 2;
                    DrawBoard(multiDimentionalArray);
                }
                //if in 2,1
                else if (input == "up" && multiDimentionalArray[2, 1] == "V")
                {
                    multiDimentionalArray[1, 1] = "V";
                                           
                    
                    multiDimentionalArray[2, 1] = " ";
                    slot = 2;
                    DrawBoard(multiDimentionalArray);
                }
                else if (input == "right" && multiDimentionalArray[2, 1] == "V")
                {
                    multiDimentionalArray[2, 2] = "V";
                    multiDimentionalArray[2, 1] = " ";
                    slot = 3;

                    DrawBoard(multiDimentionalArray);
                }
                else if (input == "left" && multiDimentionalArray[2, 1] == "V")
                {
                    multiDimentionalArray[2, 0] = "V";
                    multiDimentionalArray[2, 1] = " ";
                    slot = 1;

                    DrawBoard(multiDimentionalArray);
                }
                //if in 2,2
                else if (input == "left" && multiDimentionalArray[2, 2] == "V")
                {
                    multiDimentionalArray[2, 1] = "V";
                    multiDimentionalArray[2, 2] = " ";
                    DrawBoard(multiDimentionalArray);
                    slot = 2;

                }
                else if (input == "up" && multiDimentionalArray[2, 2] == "V")
                {
                    multiDimentionalArray[1, 2] = "V";
                    multiDimentionalArray[2, 2] = " ";
                    DrawBoard(multiDimentionalArray);
                    slot = 3;

                }
                else if (input == "shoot")
                {
                    Console.WriteLine("boom, you've shot");

                }


               
               
                
                if(slot == random)
                {
                    Console.WriteLine("you lost");
                  
                    Console.ReadLine();
                    break;
                }




               



            } while (input != "stop");















        }
        static void DrawBoard(string[,] multiDimentionalArray)
        {
            Console.WriteLine(multiDimentionalArray[0, 0] + " | " + multiDimentionalArray[0, 1] + " | " + multiDimentionalArray[0, 2] );
            Console.WriteLine("");
            Console.WriteLine(multiDimentionalArray[1, 0] + " | " + multiDimentionalArray[1, 1] + " | " + multiDimentionalArray[1, 2]   );
            Console.WriteLine("");
            Console.WriteLine(multiDimentionalArray[2, 0] + " | " + multiDimentionalArray[2, 1] + " | " + multiDimentionalArray[2, 2] );
            Console.WriteLine("Time Left: "+ allowedtime);
        }

            




    }   
}


