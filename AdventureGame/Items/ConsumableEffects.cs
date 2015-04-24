using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    public static class ConsumableEffects
    {
        public static void HealthPotion(Player player)
        {
            if (player.HP + 20 <= player.MaxHP)
                player.HP += 20;
            else
                player.HP = player.MaxHP;
        }
        public static void ManaPotion(Player player)
        {
            if (player.Mana + 10 <= player.MaxMana)
                player.Mana += 10;
            else
                player.Mana = player.MaxMana;
        }
    }
}
