using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTree
{
    class DarkHereshy: Dark
    {
        public DarkHereshy(float calories, bool isnut) : base(calories, isnut)
        {
            calories = 3;
            isnut = false;

        }
        public override void PrintCandy()
        {
            Console.WriteLine("The Dark Hershey's Bar has " + calories + " calories");
            Console.WriteLine("Has Nuts: " + isnut);
        }
    }
}
