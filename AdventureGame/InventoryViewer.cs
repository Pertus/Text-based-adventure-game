using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    static class InventoryViewer
    {

        public static void ViewInventory(Player player)
        {
            Console.WriteLine("");
            Console.WriteLine(player.Name);
            Console.WriteLine(player.Gender);
            Console.WriteLine(player.Race);
            Console.WriteLine(player.Class);
            Console.WriteLine("Level: " + player.Level);
            Console.WriteLine("XP: " + player.XP);
            Console.WriteLine("Health: " + player.Constitution * 3);
            Console.WriteLine("Mana: " + player.Wisdom * 2);
            if (player.Armor == null)
                Console.WriteLine("Armor value: 0");
            else
                Console.WriteLine("Armor value: " + player.Armor.ArmorValue);
            Console.WriteLine("Inventory: ");

                

            foreach (InventoryObject i in player.Inventory)
            {
                Console.WriteLine(i.Name);
            }
        }
    }
}
