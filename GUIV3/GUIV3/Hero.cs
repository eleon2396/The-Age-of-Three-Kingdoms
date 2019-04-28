using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeKingdomsTake2
{
    class Hero : Card
    {

        public Hero()
    : base() { this.SetType("Hero"); }

        public Hero(string name, string desc, int atk, int def, int tier, string imagePath)
            : base(name, desc, atk, def, tier, imagePath) { this.SetType("Hero"); }


    }
}
