using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Character
{
    class Program
    {
        static void Main(string[] args)
        {
            int menuselect = 0;
            Character_ character = new Character_("", 0, "", "", "");
            do
            {

                Console.WriteLine("1) CREATE A CHARACTER");
                Console.WriteLine("2) MODIFY A CHARACTER");
                Console.WriteLine("3) DELETE A CHARACTER");
                Console.WriteLine("4) LOAD EXISTING CHARACTER");
                Console.WriteLine("5) LIST CHARACTER");
                Console.WriteLine("6) EXIT");

                menuselect = int.Parse(Console.ReadLine());

                if (menuselect == 1)
                {
                    character = CreateCharacter();

                }
                if (menuselect == 2)
                {
                    Console.WriteLine("which character do you want to modify?");
                    
                    string name = Console.ReadLine();
                    character = LoadCharacters(name);
                    string path = AppDomain.CurrentDomain.BaseDirectory + name + ".txt";
                    if (File.Exists(path))
                    {

                        ModifyCharacter(character);





                    }
                    else

                    {
                        Console.WriteLine("that character doens't exist");

                    }
                }
                if (menuselect == 3)
                {
                    Console.WriteLine("what character do you want to delete?");
                    string charactername = Console.ReadLine();
                    if (DeleteCharacter(charactername) == false)
                    {
                        Console.WriteLine("character not deleted");
                    }
                    if (DeleteCharacter(charactername) == true)
                    {
                        Console.WriteLine("character deleted");
                       
                    }

                }
                if (menuselect == 4)
                {
                   
                    Console.WriteLine("what character do you want to load in?");
                    string name = Console.ReadLine();
                    character = LoadCharacters(name);

                }
                if (menuselect == 5)
                {
                   
                    Console.WriteLine(character.CharacterName);



                }
          
            } while (menuselect != 6);


        }


        static void SaveCharacter(Character_ character)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + character.CharacterName + ".txt";
            if (File.Exists(path))
            {
                Console.WriteLine("file exists, orverwrite (yes, no)");
                string answer = Console.ReadLine();
                if (answer == "yes")
                {
                    using (StreamWriter sw = new StreamWriter(path))
                    {
                        sw.WriteLine(character.CharacterName);
                        sw.WriteLine(character.age);
                        sw.WriteLine(character.eyecolor);
                        sw.WriteLine(character.skincolor);
                        sw.WriteLine(character.shirtcolor);
                    }
                    Console.WriteLine("Overwritten");
                }
                else

                    Console.WriteLine("Nothing overwritten");
            }
            else
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(character.CharacterName);
                    sw.WriteLine(character.age);
                    sw.WriteLine(character.eyecolor);
                    sw.WriteLine(character.skincolor);
                    sw.WriteLine(character.shirtcolor);
                }
            Console.WriteLine("file made");
        }

        static Character_ CreateCharacter()
        {
            Console.WriteLine("enter in your characters name");
            string name = Console.ReadLine();
            Console.WriteLine("enter in your characters age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("enter in your characters eyecolor");
            string eyecolor = Console.ReadLine();
            Console.WriteLine("enter in your characters skincolor");
            string skincolor = Console.ReadLine();
            Console.WriteLine("enter in your characters shirtcolor");
            string shirtcolor = Console.ReadLine();
            Character_ character = new Character_(name, age, eyecolor, skincolor, shirtcolor);
            SaveCharacter(character);
            return character;
        }





        static void ModifyCharacter(Character_ character)
        {

          
            Console.WriteLine("enter in your characters new age");
            character.age = int.Parse(Console.ReadLine());
            Console.WriteLine("enter in your characters new eyecolor");
            character.eyecolor = Console.ReadLine();
            Console.WriteLine("enter in your characters new skincolor");
            character.skincolor = Console.ReadLine();
            Console.WriteLine("enter in your characters new shirtcolor");
            character.shirtcolor = Console.ReadLine();
            string path = AppDomain.CurrentDomain.BaseDirectory + character.CharacterName + ".txt";

     
            SaveCharacter(character);


        }

        static bool DeleteCharacter(string characterName)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + characterName + ".txt";

            if (File.Exists(path))
            {

                File.Delete(path);
                return true;
            }
            //POKIIIIMANNNN
            else

            {
              
                return false;
            }
        }
        static Character_ LoadCharacters(string characterName)
        {

            string path = AppDomain.CurrentDomain.BaseDirectory + characterName + ".txt";

            Character_ character;
            using (StreamReader sr = new StreamReader(path))
            {
                character = new Character_(sr.ReadLine(), int.Parse(sr.ReadLine()), sr.ReadLine(), sr.ReadLine(), sr.ReadLine());
            }
            return character;
        }
        //you can blame me, try to shame me, but still I'll care for you. You can run around, even shoot me down. But I'll be there for you. The world may think I'm foolish; They can't see you like I can. Oh, but anyone who knows what love is, will understand. 





    }

}


