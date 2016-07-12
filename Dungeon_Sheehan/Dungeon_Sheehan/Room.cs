using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Sheehan
{
    public class Room
    {
        public Room(Treasure tres, Creature creat)
        {
            this.room_treasure = tres;
            this.room_creature = creat;
        }

        private int room_health;
        private Creature room_creature;
        private Treasure room_treasure;

        public Creature Room_Creature
        {
            get
            {
                return room_creature;
            }
            set
            {
                room_creature = value;
            }
        }

        public Treasure Room_Treasure
        {
            get
            {
                return room_treasure;
            }
            set
            {
                room_treasure = value;
            }
        }

        public void Creature_Fight(int fight_move)
        {
            Room_Creature.Creature_Health -= fight_move;
        }
    } 
}
