using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Currencies : IComparable<Currencies>, IPrintable
    {
       
            int goldCount;
            int SilverCount;
            int CopperCount;
            public Currencies(int goldCount, int SilverCount, int CopperCount)
            {
                this.goldCount = 0;
                this.SilverCount = 0;
                this.CopperCount = 0;
            
            }

        public int CompareTo(Currencies other)
        {
            if (other == null) return 1;
            int total = goldCount * 100 + SilverCount * 100 + CopperCount;
            int otherTotal = other.goldCount * 10000 + other.SilverCount * 100 + other.CopperCount;
            int result = total > otherTotal ? 1 : -1;
            return total > otherTotal ? 1 : total < otherTotal ? -1 : 0;
        }
       
        public void Print()
        {
            Console.WriteLine("You have " + goldCount + " gold, " + SilverCount + " silver, and " + CopperCount + " copper coins.");
        }


    }
}
