using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    public class Player
    {
        //Basic info
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Race { get; set; }
        public string Class { get; set; }

        //Stats
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

        //Other stats
        public int HP { get; set; }
        public int MaxHP { get; set; }
        public int Mana { get; set; }
        public int MaxMana { get; set; }
        public int XP { get; set; }
        public int Armor { get; set; }

        //Inventory
        public List<InventoryObject> Inventory { get; set; }

        public Player()
        {
            Strength = 6;
            Dexterity = 6;
            Constitution = 6;
            Intelligence = 6;
            Wisdom = 6;
            Charisma = 6;

            XP = 0;

            Inventory = new List<InventoryObject>();
        }
    }
}
