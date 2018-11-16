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
            List<Character_> characters = new List<Character_>();
            Console.WriteLine("1) CREATE A CHARACTER");
                Console.WriteLine("2) MODIFY A CHARACTER");
                Console.WriteLine("3) DELETE A CHARACTER");
                Console.WriteLine("4) LOAD EXISTING CHARACTER");
                Console.WriteLine("5) LIST CHARACTERS");
                Console.WriteLine("6) SAVE CHARACTER");
                Console.WriteLine("7) EXIT");

                int menuselect = int.Parse(Console.ReadLine());
                if (menuselect == 1)
                {
                    characters.Add(CreateCharacter());

                }
                if (menuselect == 2)
                {

                    ModifyCharacter();
                }
                if (menuselect == 3)
                {
                    //   DeleteCharacter();
                }
                if (menuselect == 4)
                {

                }
                if (menuselect == 5)
                {

                }
                if (menuselect == 6)
                {

                }

   
         
          
                
            

             Character_ CreateCharacter()
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
                string path = @"C:\Users\142084\OneDrive - Academy District 20\C#\" + character.CharacterName + ".txt";

                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(character.CharacterName + " " + character.age + " " + character.eyecolor + " " + character.skincolor + " " + character.shirtcolor);
                }
                path = AppDomain.CurrentDomain.BaseDirectory + @"Example.txt";

                return character ;
            }
            void ModifyCharacter(Character_ character )
            {
                Console.WriteLine("what character do you want to modify?");
                string whichcharacter = Console.ReadLine();
                Console.WriteLine("enter in your characters new age");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("enter in your characters new eyecolor");
                string eyecolor = Console.ReadLine();
                Console.WriteLine("enter in your characters new skincolor");
                string skincolor = Console.ReadLine();
                Console.WriteLine("enter in your characters new shirtcolor");
                string shirtcolor = Console.ReadLine();
               
                string path = @"C:\Users\142084\OneDrive - Academy District 20\C#\" + character.CharacterName + ".txt";

                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(character.CharacterName + " " + character.age + " " + character.eyecolor + " " + character.skincolor + " " + character.shirtcolor);
                }
                path = AppDomain.CurrentDomain.BaseDirectory + @"Example.txt";
               
            }
             bool DeleteCharacter(List<Character_>charcters, string characterName)
            {
                Console.WriteLine("what character do you want to delete?");
                string charactername = Console.ReadLine();

                if (File.Exists(@"C:\Users\142084\OneDrive - Academy District 20\C#\" + charactername + ".txt"))
                {

                    File.Delete(@"C:\Users\142084\OneDrive - Academy District 20\C#\" + charactername + ".txt");
                }
                else
                {
                    Console.WriteLine("that character doens't exist");
                }

                return null;
            }
            Character LoadCharacter(string characterName)
            {

            }
            List<Character> LoadCharacters()
            {

            }
            void ListCharacters(List<characters> characters)
            {

            }
            void SaveCharacter(Character character)
            {

            }

        }

        
    }

}
