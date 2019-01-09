using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jLee_WaterGun
{
    class watergun
    {
        float capacity;
        bool isWet;
        Random rand = new Random();
        public watergun()
        { }
        public bool Shoot(float amount)
        {
            if (capacity > 0)
            {
                capacity -= amount;
                float percentChance = (amount * .2f) + .2f;
                if (rand.NextDouble() < percentChance)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
              
            }
            else
            {
                return false;
            }
        }
        void refill()
        {
            capacity += .25f;
        }
    }
    }

