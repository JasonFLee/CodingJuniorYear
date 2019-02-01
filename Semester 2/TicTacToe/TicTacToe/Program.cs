using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TicTacToe
{
    class Program
    {





        static void Main(string[] args)
        {





            try
            {
                using (StreamReader sr = new StreamReader(@"C:\Users\142084\Desktop\CodeQuest\Prob17.in.txt"))
                {

                    String line = sr.ReadToEnd();
                    Console.WriteLine(line);

                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();










            char[,] multiDimentionalArray = new Char[3, 3];
            for (int i = 0; i < multiDimentionalArray.GetLength(0); i++)
            {
                for (int j = 0; j < multiDimentionalArray.GetLength(1); j++)
                {

                    multiDimentionalArray[i, j] = ' ';
                }
            }

            Console.WriteLine("x's go first, first to get 3 in a row wins");


            DrawBoard(multiDimentionalArray);

            ProcessTurn(multiDimentionalArray, 'x');
            DrawBoard(multiDimentionalArray);
            for (int p = 1; p < 5; p++)
            {
                ProcessTurn(multiDimentionalArray, 'o');
                DrawBoard(multiDimentionalArray);
                char result = VerifyBoard(multiDimentionalArray);

                if (result == 'o')
                {
                    Console.WriteLine("O WINS!");
                    break;
                }


                ProcessTurn(multiDimentionalArray, 'x');
                DrawBoard(multiDimentionalArray);
                result = VerifyBoard(multiDimentionalArray);


                if (result == 'x')
                {
                    Console.WriteLine("X WINS!");
                    break;
                }
                if (p == 4 && result != 'x' && result != 'o')
                {
                    Console.WriteLine("TIE");
                }
            }

            Console.ReadLine();
        }


        static char VerifyBoard(char[,] multiDimentionalArray)
        {

            if (multiDimentionalArray[0, 0] == 'x' && multiDimentionalArray[0, 1] == 'x' && multiDimentionalArray[0, 2] == 'x')
            {
                return 'x';
            }
            if (multiDimentionalArray[0, 0] == 'o' && multiDimentionalArray[0, 1] == 'o' && multiDimentionalArray[0, 2] == 'o')
            {
                return 'o';
            }


            if (multiDimentionalArray[1, 0] == 'x' && multiDimentionalArray[1, 1] == 'x' && multiDimentionalArray[1, 2] == 'x')
            {
                return 'x';
            }
            if (multiDimentionalArray[1, 0] == 'o' && multiDimentionalArray[1, 1] == 'o' && multiDimentionalArray[1, 2] == 'o')
            {
                return 'o';
            }

            if (multiDimentionalArray[2, 0] == 'x' && multiDimentionalArray[2, 1] == 'x' && multiDimentionalArray[2, 2] == 'x')
            {
                return 'x';
            }
            if (multiDimentionalArray[2, 0] == 'o' && multiDimentionalArray[2, 1] == 'o' && multiDimentionalArray[2, 2] == 'o')
            {
                return 'o';
            }


            if (multiDimentionalArray[0, 0] == 'x' && multiDimentionalArray[1, 0] == 'x' && multiDimentionalArray[2, 0] == 'x')
            {
                return 'x';
            }
            if (multiDimentionalArray[0, 0] == 'o' && multiDimentionalArray[1, 0] == 'o' && multiDimentionalArray[2, 0] == 'o')
            {
                return 'o';
            }

            if (multiDimentionalArray[0, 1] == 'x' && multiDimentionalArray[1, 1] == 'x' && multiDimentionalArray[2, 1] == 'x')
            {
                return 'x';
            }
            if (multiDimentionalArray[0, 1] == 'o' && multiDimentionalArray[1, 1] == 'o' && multiDimentionalArray[2, 1] == 'o')
            {
                return 'o';
            }

            if (multiDimentionalArray[0, 2] == 'x' && multiDimentionalArray[1, 2] == 'x' && multiDimentionalArray[2, 2] == 'x')
            {
                return 'x';
            }
            if (multiDimentionalArray[0, 2] == 'o' && multiDimentionalArray[1, 2] == 'o' && multiDimentionalArray[2, 2] == 'o')
            {
                return 'o';
            }

            if (multiDimentionalArray[0, 0] == 'x' && multiDimentionalArray[1, 1] == 'x' && multiDimentionalArray[2, 2] == 'x')
            {
                return 'x';
            }
            if (multiDimentionalArray[0, 0] == 'o' && multiDimentionalArray[1, 1] == 'o' && multiDimentionalArray[2, 2] == 'o')
            {
                return 'o';
            }

            if (multiDimentionalArray[2, 0] == 'x' && multiDimentionalArray[1, 1] == 'x' && multiDimentionalArray[0, 2] == 'x')
            {
                return 'x';
            }
            if (multiDimentionalArray[2, 0] == 'o' && multiDimentionalArray[1, 1] == 'o' && multiDimentionalArray[0, 2] == 'o')
            {
                return 'o';
            }


            return ' ';

        }

        static void DrawBoard(char[,] multiDimentionalArray)
        {
            Console.WriteLine(multiDimentionalArray[0, 0] + " | " + multiDimentionalArray[0, 1] + " | " + multiDimentionalArray[0, 2]);
            Console.WriteLine("---------");
            Console.WriteLine(multiDimentionalArray[1, 0] + " | " + multiDimentionalArray[1, 1] + " | " + multiDimentionalArray[1, 2]);
            Console.WriteLine("---------");
            Console.WriteLine(multiDimentionalArray[2, 0] + " | " + multiDimentionalArray[2, 1] + " | " + multiDimentionalArray[2, 2]);
        }

        static void ProcessTurn(char[,] multiDimentionalArray, char player)
        {
            Console.WriteLine("What square do you want? 1-9");
            char input = char.Parse(Console.ReadLine());

            if (input == '1' && multiDimentionalArray[0, 0] != 'x' && multiDimentionalArray[0, 0] != 'o')
            {
                multiDimentionalArray[0, 0] = player;

            }

            if (input == '2' && multiDimentionalArray[0, 1] != 'x' && multiDimentionalArray[0, 1] != 'o')
            {
                multiDimentionalArray[0, 1] = player;

            }
            if (input == '3' && multiDimentionalArray[0, 2] != 'x' && multiDimentionalArray[0, 2] != 'o')
            {
                multiDimentionalArray[0, 2] = player;

            }
            if (input == '4' && multiDimentionalArray[1, 0] != 'x' && multiDimentionalArray[1, 0] != 'o')
            {
                multiDimentionalArray[1, 0] = player;

            }
            if (input == '5' && multiDimentionalArray[1, 1] != 'x' && multiDimentionalArray[1, 1] != 'o')
            {
                multiDimentionalArray[1, 1] = player;

            }
            if (input == '6' && multiDimentionalArray[1, 2] != 'x' && multiDimentionalArray[1, 2] != 'o')
            {
                multiDimentionalArray[1, 2] = player;

            }
            if (input == '7' && multiDimentionalArray[2, 0] != 'x' && multiDimentionalArray[2, 0] != 'o')
            {
                multiDimentionalArray[2, 0] = player;

            }
            if (input == '8' && multiDimentionalArray[2, 1] != 'x' && multiDimentionalArray[2, 1] != 'o')
            {
                multiDimentionalArray[2, 1] = player;

            }
            if (input == '9' && multiDimentionalArray[2, 2] != 'x' && multiDimentionalArray[2, 2] != 'o')
            {
                multiDimentionalArray[2, 2] = player;

            }

        }

    }
}
