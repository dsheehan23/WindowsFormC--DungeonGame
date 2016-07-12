using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Sheehan
{
    public class KrampusCreature : Creature
    {
        public KrampusCreature(string NAME, int HEALTH)
            : base(NAME, HEALTH)
        {
        }

        public override string ToString()
        {
            return string.Format("Krampus: {0}, Health {1} points", Creature_Name, Creature_Health);
        }
    } 

}
