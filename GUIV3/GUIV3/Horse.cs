using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeKingdomsTake2
{
    class Horse: Card
    {
        public Horse()
     : base() { this.SetType("Horse"); }

        public Horse(string name, string desc, int def)
        {

            this.SetName(name);
            this.SetDescription(desc);
            this.SetAttack(0);
            this.SetDefense(def);
            this.SetTier(0);
            this.SetType("Horse");
        }

        public Horse(string name, string desc, int atk, int def, int tier, string imagePath)
            : base(name, desc, atk, def, tier, imagePath) { this.SetType("Horse"); }

    }
}

