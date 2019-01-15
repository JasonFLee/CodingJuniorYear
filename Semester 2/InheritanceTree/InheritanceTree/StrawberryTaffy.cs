using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTree
{
    class StrawberryTaffy : Taffy
    {
        public StrawberryTaffy(float calories, bool isnut) : base(calories, isnut)
        {
            calories = 7;
            isnut = false;

        }
        public override void PrintCandy()
        {
            Console.WriteLine("Strawberry Taffy has " + calories + " calories");
            Console.WriteLine("Has Nuts: " + isnut);
        }
    }

}
