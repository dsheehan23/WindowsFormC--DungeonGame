using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Sheehan
{
    public class GhoulCreature : Creature
    {
        public GhoulCreature(string NAME, int HEALTH)
            : base(NAME, HEALTH)
        {
        }

        public override string ToString()
        {
            return string.Format("Ghoul: {0}, Health {1} points", Creature_Name, Creature_Health);
        }
    }

}
