using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTree
{
    class GummyWorm : gummy
    {
        public GummyWorm(float calories, bool isnut) : base(calories, isnut)
        {
            calories = 4;
            isnut = false;

        }
        public override void PrintCandy()
        {
            Console.WriteLine("The Gummy Worm has " + calories + " calories");
            Console.WriteLine("Has Nuts: " + isnut);
        }
    }
}
