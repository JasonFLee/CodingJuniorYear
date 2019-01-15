using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTree
{
    class Recees: Milk
    {
        public Recees(float calories, bool isnut) : base(calories, isnut)
        {
            calories = 2;
            isnut = true;

        }
        public override void PrintCandy()
        {
            Console.WriteLine("The Recees has " + calories + " calories");
            Console.WriteLine("Has Nuts: " + isnut);
        }
    }
}
