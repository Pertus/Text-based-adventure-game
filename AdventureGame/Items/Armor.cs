using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    public class Armor:InventoryObject
    {
        public int ArmorValue { get; set; }

        public Armor(string name, int armorValue)
        {
            Name = name;
            ArmorValue = armorValue;
        }
    }
}
