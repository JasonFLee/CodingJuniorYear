using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTree
{
    class GummyBear : gummy
    {
        public GummyBear(float calories, bool isnut) : base(calories, isnut)
        {
            calories = 5;
            isnut = false;

        }
        public override void PrintCandy()
        {
            Console.WriteLine("The Gummy Bear has " + calories + " calories");
            Console.WriteLine("Has Nuts: " + isnut);
        }
    }
}
