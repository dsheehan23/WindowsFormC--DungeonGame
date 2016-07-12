using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Sheehan
{
    public class SilverTreasure : Treasure
    {
        public SilverTreasure(string NAME, double AMOUNT)
            : base(NAME, AMOUNT)
        {
        }

        public override string ToString()
        {
            return string.Format("Silver Treasure: {0}, TreasureAmount = ${1}", TreasureName, TreasureAmount);
        }
    }
}
