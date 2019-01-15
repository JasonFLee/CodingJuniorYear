using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTree
{
    abstract class Candy
    {    
            protected float calories;
            protected bool isnut;
        public Candy(float calories, bool isnut)
        {
            this.calories = calories;
            this.isnut = isnut;
        }

    }
}
