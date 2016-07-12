using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Sheehan
{
    public abstract class Treasure
    {
        public Treasure(string NAME, double AMOUNT)
        {
            TreasureName = NAME;
            TreasureAmount = AMOUNT;
        }

        public string TreasureName { get; private set; }
        public double TreasureAmount { get; private set; }

        public override string ToString()
        {
            return string.Format("Treasure: {0}, TreasureAmount = ${1}", TreasureName, TreasureAmount);
        }

    } 
}
