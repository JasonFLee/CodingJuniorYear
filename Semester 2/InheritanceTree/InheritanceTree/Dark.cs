using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTree
{
    abstract class Dark:Chocolate
    {
        public Dark(float calories, bool isnut) : base(calories, isnut)
        {


        }

    }
}
