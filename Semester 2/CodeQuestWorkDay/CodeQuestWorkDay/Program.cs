using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeQuestWorkDay
{
    class Program
    {
        static int Rotor1(int input)
        {
            int output = 0;
            if(input == 0)
            {
                 output = 1;
            }
            if (input == 1)
            {
                output = 3;
            }
            if (input == 2)
            {
                output = 6;
            }
            if (input == 3)
            {
                output = 0;
            }
            if (input == 4)
            {
                output = 5;
            }
            if (input == 5)
            {
                output = 4;
            }
            if (input == 6)
            {
                output = 8;
            }
            if (input == 7)
            {
                output = 7;
            }
            if (input == 8)
            {
                output = 9;
            }
            if (input == 9)
            {
                output = 2;
            }
            
            return output;
        }
        static int Rotor1INVERSE(int input)
        {
            int output = 0;
            if (input == 1)
            {
                output = 0;
            }
            if (input == 3)
            {
                output = 1;
            }
            if (input == 6)
            {
                output = 2;
            }
            if (input == 0)
            {
                output = 3;
            }
            if (input == 5)
            {
                output = 4;
            }
            if (input == 4)
            {
                output = 5;
            }
            if (input == 8)
            {
                output = 6;
            }
            if (input == 7)
            {
                output = 7;
            }
            if (input == 9)
            {
                output = 8;
            }
            if (input == 2)
            {
                output = 9;
            }

            return output;
        }
        static int Rotor2(int input)
        {
            int output = 0;
            if (input == 0)
            {
                output = 0;
            }
            if (input == 1)
            {
                output = 3;
            }
            if (input == 2)
            {
                output = 5;
            }
            if (input == 3)
            {
                output = 2;
            }
            if (input == 4)
            {
                output = 6;
            }
            if (input == 5)
            {
                output = 9;
            }
            if (input == 6)
            {
                output = 1;
            }
            if (input == 7)
            {
                output = 4;
            }
            if (input == 8)
            {
                output = 8;
            }
            if (input == 9)
            {
                output = 7;
            }

         
            return output;
        }
        static int Rotor2INVERSE(int input)
        {
            int output = 0;
            if (input == 0)
            {
                output = 0;
            }
            if (input == 3)
            {
                output = 1;
            }
            if (input == 5)
            {
                output = 2;
            }
            if (input == 2)
            {
                output = 3;
            }
            if (input == 6)
            {
                output = 4;
            }
            if (input == 9)
            {
                output = 5;
            }
            if (input == 1)
            {
                output = 6;
            }
            if (input == 4)
            {
                output = 7;
            }
            if (input == 8)
            {
                output = 8;
            }
            if (input == 7)
            {
                output = 9;
            }


            return output;
        }
        static int Rotor3(int input)
        {
            int output = 0;
            if (input == 0)
            {
                output = 5;
            }
            if (input == 1)
            {
                output = 9;
            }
            if (input == 2)
            {
                output = 1;
            }
            if (input == 3)
            {
                output = 7;
            }
            if (input == 4)
            {
                output = 3;
            }
            if (input == 5)
            {
                output = 8;
            }
            if (input == 6)
            {
                output = 0;
            }
            if (input == 7)
            {
                output = 2;
            }
            if (input == 8)
            {
                output = 4;
            }
            if (input == 9)
            {
                output = 6;
            }

           
            return output;
        }
        static int Rotor3INVERSE(int input)
        {
            int output = 0;
            if (input == 5)
            {
                output = 0;
            }
            if (input == 9)
            {
                output = 1;
            }
            if (input == 1)
            {
                output = 2;
            }
            if (input == 7)
            {
                output = 3;
            }
            if (input == 3)
            {
                output = 4;
            }
            if (input == 8)
            {
                output = 5;
            }
            if (input == 0)
            {
                output = 6;
            }
            if (input == 2)
            {
                output = 7;
            }
            if (input == 4)
            {
                output = 8;
            }
            if (input == 6)
            {
                output = 9;
            }


            return output;
        }
        static int Rotor4(int input)
        {
            int output = 0;
            if (input == 0)
            {
                output = 1;
            }
            if (input == 1)
            {
                output = 5;
            }
            if (input == 2)
            {
                output = 5;
            }
            if (input == 3)
            {
                output = 2;
            }
            if (input == 4)
            {
                output = 9;
            }
            if (input == 5)
            {
                output = 0;
            }
            if (input == 6)
            {
                output = 7;
            }
            if (input == 7)
            {
                output = 4;
            }
            if (input == 8)
            {
                output = 3;
            }
            if (input == 9)
            {
                output = 8;
            }

            return output;
        }
        static int Rotor4INVERSE(int input)
        {
            int output = 0;
            if (input == 1)
            {
                output = 0;
            }
            if (input == 5)
            {
                output = 1;
            }
            if (input == 5)
            {
                output = 2;
            }
            if (input == 2)
            {
                output = 3;
            }
            if (input == 9)
            {
                output = 4;
            }
            if (input == 0)
            {
                output = 5;
            }
            if (input == 7)
            {
                output = 6;
            }
            if (input == 4)
            {
                output = 7;
            }
            if (input == 3)
            {
                output = 8;
            }
            if (input == 8)
            {
                output = 9;
            }

            return output;
        }
        static int dothings(int given)
        {
           int decoded = 0;
           
            Console.WriteLine("Which chamber do you start with?");
            int firstchamber = int.Parse(Console.ReadLine());
            Console.WriteLine("Then?");
            int secondchamber = int.Parse(Console.ReadLine());
            Console.WriteLine("Then?");
            int thirdchamber = int.Parse(Console.ReadLine());
            if (firstchamber == 1)
            {
                decoded = Rotor1(given);
            }
            if (firstchamber == 2)
            {
                decoded = Rotor2(given);
            }
            if (firstchamber == 3)
            {
                decoded = Rotor3(given);
            }
            if (firstchamber == 4)
            {
                decoded = Rotor4(given);
            }


            if (secondchamber == 1)
            {
                decoded = Rotor1(decoded);
            }
            if (secondchamber == 2)
            {
                decoded = Rotor2(decoded);
            }
            if (secondchamber == 3)
            {
                decoded = Rotor3(decoded);
            }
            if (secondchamber == 4)
            {
                decoded = Rotor4(decoded);
            }

            if (thirdchamber == 1)
            {
                decoded = Rotor1(decoded);


            }
            if (thirdchamber == 2)
            {
                decoded = Rotor2(decoded);
            }
            if (thirdchamber == 3)
            {
                decoded = Rotor3(decoded);
            }
            if (thirdchamber == 4)
            {
                decoded = Rotor4(decoded);
            }
            decoded = Reflect(decoded);
            if (thirdchamber == 1)
            {
                decoded = Rotor1INVERSE(decoded);
            }
            if (thirdchamber == 2)
            {
                decoded = Rotor2INVERSE(decoded);
            }
            if (thirdchamber == 3)
            {
                decoded = Rotor3INVERSE(decoded);
            }
            if (thirdchamber == 4)
            {
                decoded = Rotor4INVERSE(decoded);
            }
            //next
            if (secondchamber == 1)
            {
                decoded = Rotor1INVERSE(decoded);
            }
            if (secondchamber == 2)
            {
                decoded = Rotor2INVERSE(decoded);
            }
            if (secondchamber == 3)
            {
                decoded = Rotor3INVERSE(decoded);
            }
            if (secondchamber == 4)
            {
                decoded = Rotor4INVERSE(decoded);
            }
            //next
            if (firstchamber == 1)
            {
                decoded = Rotor1INVERSE(decoded);
            }
            if (firstchamber == 2)
            {
                decoded = Rotor2INVERSE(decoded);
            }
            if (firstchamber == 3)
            {
                decoded = Rotor3INVERSE(decoded);
            }
            if (firstchamber == 4)
            {
                decoded = Rotor4INVERSE(decoded);
            }
            return decoded;
        }

        static int Reflect(int input)
        {
            int output = 0;
            if (input == 0)
            {
                output = 3;
            }
            if (input == 1)
            {
                output = 6;
            }
            if (input == 2)
            {
                output = 8;
            }
            if (input == 3)
            {
                output = 0;
            }
            if (input == 4)
            {
                output = 5;
            }
            if (input == 5)
            {
                output = 4;
            }
            if (input == 6)
            {
                output = 1;
            }
            if (input == 7)
            {
                output = 9;
            }
            if (input == 8)
            {
                output = 2;
            }
            if (input == 9)
            {
                output = 7;
            }

            return output;
        }
        static void Main()
        {
          
                Console.WriteLine("1) encode");
                Console.WriteLine("2) decode");
                Console.WriteLine("3) quit");

                int answer = int.Parse(Console.ReadLine());
                if (answer == 1)
                {
                    Console.WriteLine("What numbers do you want to encode");
                    string given = Console.ReadLine();


                    for (int i = 0; i < given.Length; i++)
                    {
                        Console.WriteLine("encrypted number: " + dothings(given[i] - 48));
                    }


                }

                if (answer == 2)
                {
                Console.WriteLine("What numbers do you want to decode");
                string given = Console.ReadLine();
                for (int i = 0; i < given.Length; i++)
                {
                    Console.WriteLine("decrypted number: " + dothings(given[i] - 48));
                }

            }
               
                 


            


            Console.ReadLine();
        }



    }

}
