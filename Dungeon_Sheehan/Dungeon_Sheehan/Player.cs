using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Sheehan
{
    public class Player
    {
        public Player(string NAME)
        {
            this.Name = NAME;
            this.treasure_list = new List<Treasure>();
        }

        string Name { get; set; }
        private List<Treasure> treasure_list = new List<Treasure>();

        public double GetTotalTreasureAmount()
        {
            double total = 0;

            foreach (var i in treasure_list)
            {
                total += i.TreasureAmount;
            }

            return total;
        }

        public string DisplayTreasure_List()
        {
            string treasure = "";

            foreach (var element in this.treasure_list)
            {
                treasure += string.Format("{0}  ", element.TreasureName);
            }

            return treasure;
        }

        public void SetTreasure_List(Treasure item)
        {
            treasure_list.Add(item);
        }

        public void DeleteTreasureList()
        {
            treasure_list.Clear();
        }

        public override string ToString()
        {
            return string.Format(this.Name);
        }

    }
}
