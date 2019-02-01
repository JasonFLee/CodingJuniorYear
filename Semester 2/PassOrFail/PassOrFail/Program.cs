using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace PassOrFail
{




    class Program
    {




      
        static void Main(string[] args)
        {




            string contents = File.ReadAllText(@"C:\Users\142084\Desktop\CodeQuest\Prob17.in.txt");
            char[] rawr = contents.ToCharArray();
            Console.WriteLine(contents);
            char[,] multiDimentionalArray = new Char[3, 3];





                    for (int i = 0; i < multiDimentionalArray.GetLength(0); i++)
                    {
                        for (int j = 0; j < multiDimentionalArray.GetLength(1); j++)
                        {

                            multiDimentionalArray[i, j] = ' ';
                        }
                    }

            
            




            bool x;
           


            for (int o = 0; o <40; o += 10)
            {



                multiDimentionalArray[0, 0] = rawr[3 + o];
                multiDimentionalArray[0, 1] = rawr[4 + o];
                multiDimentionalArray[0, 2] = rawr[5 + o];

                multiDimentionalArray[1, 0] = rawr[6 + o];
                multiDimentionalArray[1, 1] = rawr[7 + o];
                multiDimentionalArray[1, 2] = rawr[8 + o];

                multiDimentionalArray[2, 0] = rawr[9 + o];
                multiDimentionalArray[2, 1] = rawr[10 + o];
                multiDimentionalArray[2, 2] = rawr[11 + o];

                if (multiDimentionalArray[0, 0] == 'X' && multiDimentionalArray[0, 1] == 'X' && multiDimentionalArray[0, 2] == 'X')
                {
                    x = true;
                    Console.WriteLine("X WINNER");
                }
                if (multiDimentionalArray[0, 0] == 'O' && multiDimentionalArray[0, 1] == 'O' && multiDimentionalArray[0, 2] == 'O')
                {

                    x = true;
                    Console.WriteLine("O WINNER");
                }


                if (multiDimentionalArray[1, 0] == 'X' && multiDimentionalArray[1, 1] == 'X' && multiDimentionalArray[1, 2] == 'X')
                {
                    x = true;
                    Console.WriteLine("X WINNER");
                }
                if (multiDimentionalArray[1, 0] == 'O' && multiDimentionalArray[1, 1] == 'O' && multiDimentionalArray[1, 2] == 'O')
                {
                    x = true;
                    Console.WriteLine("O WINNER");
                }

                if (multiDimentionalArray[2, 0] == 'X' && multiDimentionalArray[2, 1] == 'X' && multiDimentionalArray[2, 2] == 'X')
                {
                    x = true;
                    Console.WriteLine("X WINNER");
                }
                if (multiDimentionalArray[2, 0] == 'O' && multiDimentionalArray[2, 1] == 'O' && multiDimentionalArray[2, 2] == 'O')
                {
                    x = true;
                    Console.WriteLine("O WINNER");
                }


                if (multiDimentionalArray[0, 0] == 'X' && multiDimentionalArray[1, 0] == 'X' && multiDimentionalArray[2, 0] == 'X')
                {
                    x = true;
                    Console.WriteLine("X WINNER");
                }
                if (multiDimentionalArray[0, 0] == 'O' && multiDimentionalArray[1, 0] == 'O' && multiDimentionalArray[2, 0] == 'O')
                {
                    x = true;
                    Console.WriteLine("O WINNER");
                }

                if (multiDimentionalArray[0, 1] == 'X' && multiDimentionalArray[1, 1] == 'X' && multiDimentionalArray[2, 1] == 'X')
                {
                    x = true;
                    Console.WriteLine("X WINNER");
                }
                if (multiDimentionalArray[0, 1] == 'O' && multiDimentionalArray[1, 1] == 'O' && multiDimentionalArray[2, 1] == 'O')
                {
                    x = true;
                    Console.WriteLine("O WINNER");
                }

                if (multiDimentionalArray[0, 2] == 'X' && multiDimentionalArray[1, 2] == 'X' && multiDimentionalArray[2, 2] == 'X')
                {
                    x = true;
                    Console.WriteLine("X WINNER");
                }
                if (multiDimentionalArray[0, 2] == 'O' && multiDimentionalArray[1, 2] == 'O' && multiDimentionalArray[2, 2] == 'O')
                {
                    x = true;
                    Console.WriteLine("O WINNER");
                }

                if (multiDimentionalArray[0, 0] == 'X' && multiDimentionalArray[1, 1] == 'X' && multiDimentionalArray[2, 2] == 'X')
                {
                    x = true;
                    Console.WriteLine("X WINNER");
                }





                
            }


            Console.ReadLine();



                }



            }
           
          

                
          






           
       
    
}
        