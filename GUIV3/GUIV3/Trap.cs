using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeKingdomsTake2
{
    class Trap : Card
    {

            public Trap()
              : base() { this.SetType("Trap"); }

            public Trap(string name, string desc)
            {
                this.SetName(name);
                this.SetDescription(desc);
                this.SetAttack(0);
                this.SetDefense(0);
                this.SetTier(0);
                this.SetType("Trap");
            }

            public Trap(string name, string desc, int atk, int def, int tier, string imagePath)
                : base(name, desc, atk, def, tier, imagePath) { this.SetType("Trap"); }

        
    }
}
