using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character
{
    class Character_
    {
        public string CharacterName;
        public int age;
        public string eyecolor;
        public string skincolor;
        public string shirtcolor;
        public Character_(string CharacterName, int age, string eyecolor, string skincolor, string shirtcolor)
        {
            this.CharacterName = CharacterName;
            this.age = age;
            this.eyecolor = eyecolor;
            this.skincolor = skincolor;
            this.shirtcolor = shirtcolor;
        }

    }
}
