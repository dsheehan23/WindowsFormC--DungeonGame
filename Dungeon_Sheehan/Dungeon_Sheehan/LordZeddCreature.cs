using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Sheehan
{
    public class LordZeddCreature : Creature
    {
        public LordZeddCreature(string NAME, int HEALTH)
            : base(NAME, HEALTH)
        {
        }

        public override string ToString()
        {
            return string.Format("Lord Zedd: {0}, Health {1} points", Creature_Name, Creature_Health);
        }
    }

}
