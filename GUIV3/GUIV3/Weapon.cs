using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeKingdomsTake2
{
    class Weapon : Card
    {
        public Weapon()
      : base() { this.SetType("Weapon"); }

        public Weapon(string name, string desc, int atk)
        {
            this.SetName(name);
            this.SetDescription(desc);
            this.SetAttack(atk);
            this.SetDefense(0);
            this.SetTier(0);
            this.SetType("Weapon");
        }

        public Weapon(string name, string desc, int atk, int def, int tier, string imagePath)
            : base(name, desc, atk, def, tier, imagePath) { this.SetType("Weapon"); }
    }
}

