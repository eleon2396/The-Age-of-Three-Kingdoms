using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientNetwork;
namespace GUIV3
{
    class Player: Client
    {
        protected string name;
        // set of cards

        // cards on the field
        protected int lifePoints;

        public Player(string name, int lp):base()
        {
            this.name = name;
            this.lifePoints = lp;
        }

        public String GetName()
        {
            return name;
        }
    }
}
