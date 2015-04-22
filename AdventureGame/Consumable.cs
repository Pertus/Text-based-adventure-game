using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Consumable:InventoryObject
    {
        public Action<Player> Effect { get; set; }

        public Consumable(string name, Action<Player> effect)
        {
            Name = name;
            Effect = effect;
        }
        public void Use(Player player)
        {
            Effect(player);
        }
    }
}
