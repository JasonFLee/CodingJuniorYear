using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTree
{
    class Program
    {
        static void Main(string [] args)
        {
            Console.WriteLine("Chocolate or Soft?");
            string chocorsoft = Console.ReadLine();
            if(chocorsoft == "Chocolate")
            {
                Console.WriteLine("Milk or Dark?");
                string milkordark = Console.ReadLine();
                if (milkordark == "Milk")
                {
                    Console.WriteLine("KitKat or Recees?");
                    string kitkatorrecees = Console.ReadLine();
                    if (kitkatorrecees == "KitKat")
                    {
                        Candy kitkat = new KitKat(218, false);
                        kitkat.PrintCandy();
                    }
                    else if (kitkatorrecees == "Recees")
                    {
                        Candy Recees = new Recees(87, true);
                        Recees.PrintCandy();
                    }
                    
                }
                else if (milkordark == "Dark")
                {
                    Candy DarkHereshy = new DarkHereshy(78, false);
                    DarkHereshy.PrintCandy();
                }
            }
            else if (chocorsoft == "Soft")
            {
                Console.WriteLine("Gummy or Taffy?");
                string gummyortaffy = Console.ReadLine();
                if (gummyortaffy == "Gummy")
                {
                    Console.WriteLine("Worm or Bears?");
                    string wormorbears = Console.ReadLine();
                    if (wormorbears == "Worm")
                    {
                        Candy GummyWorm = new GummyWorm(100, false);
                        GummyWorm.PrintCandy();
                    }
                    else if (wormorbears == "Bears")
                    {
                        Candy GummyBear = new GummyBear(150, false);
                        GummyBear.PrintCandy();
                    }
                }
                else if (gummyortaffy == "Taffy")
                {
                    Console.WriteLine("Strawberry or Apple?");
                    string strawberryorapple = Console.ReadLine();
                    if (strawberryorapple == "Strawberry")
                    {
                        Candy StrawberryTaffy = new StrawberryTaffy(200, false);
                        StrawberryTaffy.PrintCandy();
                    }
                    else if (strawberryorapple == "Apple")
                    {
                        Candy AppleTaffy = new AppleTaffy(260, false);
                        AppleTaffy.PrintCandy();
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
