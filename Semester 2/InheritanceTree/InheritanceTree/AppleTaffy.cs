using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTree
{
    class AppleTaffy : Taffy
    {
        public AppleTaffy(float calories, bool isnut) : base(calories, isnut)
        {
            calories = 6;
            isnut = false;

        }
        public override void PrintCandy()
        {
            Console.WriteLine("The Apple Taffy has " + calories + " calories");
            Console.WriteLine("Has Nuts: " + isnut);
        }
    }
}
