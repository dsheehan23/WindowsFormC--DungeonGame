using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Sheehan
{
    public abstract class Creature
    {
        public Creature(string NAME, int HEALTH)
        {
            this.creature_name = NAME;
            this.creature_health = HEALTH;
        }

        private string creature_name;
        private int creature_health;

        public string Creature_Name
        {
            get
            {
                return creature_name;
            }
            set
            {
                creature_name = value;
            }
        }

        public int Creature_Health
        {
            get
            {
                return creature_health;
            }
            set
            {
                creature_health = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Creature: {0}, Creature Health {1} points", Creature_Name, Creature_Health);
        }
    } 

}
