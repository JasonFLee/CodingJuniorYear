using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jLee_WaterGun
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();

            watergun player1 = new watergun();
            Console.WriteLine("Water percent to shoot");
            float percentwater1 = float.Parse(Console.ReadLine());
            watergun player2 = new watergun();
            Console.WriteLine("Water percent to shoot");
            float percentwater2 = float.Parse(Console.ReadLine());
            player1.Shoot(percentwater1);
            player2.Shoot(percentwater2);
            Console.WriteLine(percentwater1);
            Console.ReadLine();


            //Console.WriteLine("Water percent to shoot");
            //int percentwater =  int.Parse(Console.ReadLine());


        }
    }
    
}
