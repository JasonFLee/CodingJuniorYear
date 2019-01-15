using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTree
{
    class KitKat: Milk
    {
        public KitKat(float calories, bool isnut) : base(calories, isnut)
        {
           

        }

        public override void PrintCandy()
        {
            Console.WriteLine("The KitKat has " + calories +" calories" );
            Console.WriteLine("Has Nuts: " + isnut);
        }
    }
}
