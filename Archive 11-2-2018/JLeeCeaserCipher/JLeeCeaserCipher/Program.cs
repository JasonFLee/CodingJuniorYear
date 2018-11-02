using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphabetprintJLee
{
    class Program
    {
        static void Main(string[] args)
        {

            do
            {

                Console.WriteLine("1. Encrypt ");
                Console.WriteLine("2. Brute Force");
                Console.WriteLine("3. Decrypt ");
                string i = Console.ReadLine();
                if (i == "1")
                {
                    encryptanddecrypt();
                }
                if (i == "2")
                {
                    bruteforce();
                }
                if (i == "3")
                {
                    decrypt();
                    Console.WriteLine("FUCKFGD");
                }





            } while (true);


        }
        static void decrypt()
        {
            int code = 1;

            Console.WriteLine("enter the phrase you want to decrypt");
            string phrase = Console.ReadLine();
            Console.WriteLine("enter the shift ");
            int shift = int.Parse(Console.ReadLine());
            shift = shift * -1;
            char[] characters = phrase.ToCharArray();
            for (int x = 0; x < phrase.Length; x++)
            {
                code = characters[x] + shift;

                if (code > 122)
                {
                    code = code - 26;
                }
                if (code < 97)
                {
                    code = code + 26;
                }
                characters[x] = (char)code;

            }
            for (int i = 0; i < phrase.Length; i++)
            {
                Console.Write(characters[i]);
            }
            Console.WriteLine();

        }
        static void bruteforce()
        {
            int code = 1;
            //  char myChar = (char)code;

            // Console.WriteLine(myChar);
            Console.WriteLine("enter the phrase you want to decipher");
            string phrase = Console.ReadLine();


            char[] characters = phrase.ToCharArray();
            for (int u = 0; u < 26; u++)
            {
                for (int x = 0; x < phrase.Length; x++)
                {

                    code = characters[x] + 1;

                    if (code > 122)
                    {
                        code = code - 26;
                    }
                    if (code < 97)
                    {
                        code = code + 26;
                    }
                    characters[x] = (char)code;

                    Console.Write(characters[x]);




                }
                Console.WriteLine();
            }




















        }
        //static void printstuff()
        //{
        //    char[] alpha = new char[26];
        //    alpha[0] = 'a';
        //    alpha[1] = 'b';
        //    alpha[2] = 'c';
        //    alpha[3] = 'd';
        //    alpha[4] = 'e';
        //    alpha[5] = 'f';
        //    alpha[6] = 'g';
        //    alpha[7] = 'h';
        //    alpha[8] = 'i';
        //    alpha[9] = 'j';
        //    alpha[10] = 'k';
        //    alpha[11] = 'l';
        //    alpha[12] = 'm';
        //    alpha[13] = 'n';
        //    alpha[14] = 'o';
        //    alpha[15] = 'p';
        //    alpha[16] = 'q';
        //    alpha[17] = 'r';
        //    alpha[18] = 's';
        //    alpha[19] = 't';
        //    alpha[20] = 'u';
        //    alpha[21] = 'v';
        //    alpha[22] = 'w';
        //    alpha[23] = 'x';
        //    alpha[24] = 'y';
        //    alpha[25] = 'z';




        //    for (int x = 0; x < 26; x++)
        //    {
        //        int MyInt = alpha[x];
        //        Console.WriteLine(alpha[x] + " = " + MyInt);
        //    }
        //}
        //static void question()
        //{
        //    for (int x = 0; x < 130000; x++)
        //    {
        //        char poopidyscoop = (char)x;
        //        Console.Write(poopidyscoop);
        //    }
        //    Console.ReadLine();
        //}
        static void encryptanddecrypt()
        {
            int code = 1;
            //  char myChar = (char)code;

            // Console.WriteLine(myChar);
            Console.WriteLine("enter the phrase you want to cipher");
            string phrase = Console.ReadLine();
            Console.WriteLine("enter the shift ");
            int shift = int.Parse(Console.ReadLine());
            char[] characters = phrase.ToCharArray();
            for (int x = 0; x < phrase.Length; x++)
            {
                code = characters[x] + shift;
                
                if (code > 122)
                {
                    code = code - 26;
                }
                if (code < 97)
                {
                    code = code + 26;
                }
                
                characters[x] = (char)code;

            }
     
            for (int i = 0; i < phrase.Length; i++)
            {
                
                Console.Write(characters[i]);
            }
            Console.WriteLine();


        }
    }

}


