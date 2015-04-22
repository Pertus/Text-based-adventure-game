using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Player
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
        public int Mana { get; set; }

        //Inventory
        public GameObject[] Inventory { get; set; }

        public Player()
        {
            Strength = 6;
            Dexterity = 6;
            Constitution = 6;
            Intelligence = 6;
            Wisdom = 6;
            Charisma = 6;

            Inventory = new GameObject[20];
        }
    }
}
