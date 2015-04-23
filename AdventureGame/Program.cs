using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Program
    {
        //The player
        static Player player;

        static void Main(string[] args)
        {
            Console.WriteLine("------------EPIC ADVENTURE GAME-----------\n");
            CreateCharacter();
            Console.ReadLine();
        }
        private static void StartGame()
        {
            Console.Clear();
            Console.WriteLine("Game is started");
        }
        #region character creation
        private static void CreateCharacter()
        {
            player = new Player();

            Console.WriteLine("------Character creation------\n");
            SelectGender();
            SelectRace();
            SelectClass();
            SelectName();
            Console.Clear();
            Console.WriteLine("You are " + player.Name + ". " + "A " + player.Gender.ToLower() + " " + player.Race.ToLower() + " " + player.Class.ToLower() +
                ".\n\n Your stats is:\n Strength: " + player.Strength + "\n Dexterity: " + player.Dexterity + "\n Constitution: " + player.Constitution + "\n Intelligence: " + player.Intelligence +
                "\n Wisdom: " + player.Wisdom + "\n Charisma: " + player.Charisma);
            Console.WriteLine("\n You have the following items in your inventory:");
            foreach (InventoryObject i in player.Inventory)
            {
                Console.WriteLine(i.Name);
            }
            Console.WriteLine("\n Is this ok?\n 1. Yes \n 2. No");
            string confirmation = Console.ReadLine();

            switch (confirmation)
            {
                case ("1"):
                    StartGame();
                    break;
                default: Console.Clear();
                    CreateCharacter();
                    break;
            }                 
        }
        private static void SelectGender()
        {
            
            Console.WriteLine("Select your gender:\n 1. Female \n 2. Male");
            string generSelector = Console.ReadLine();
            switch (generSelector)
            {
                case ("1"): player.Gender = "Female";
                    Console.WriteLine("Your gender is female\n");
                    break;
                case ("2"): player.Gender = "Male";
                    Console.WriteLine("Ýour gender is male\n");
                    break;
                default: Console.WriteLine("You have to choose between the presented options");
                    SelectGender();
                    break;
            }           
        }
        private static void SelectRace()
        {
            Console.WriteLine("Select your race:\n 1. Human\n 2. Elf\n 3. Orc \n 4. Drow");
            string raceSelector = Console.ReadLine();
            switch (raceSelector)
            {
                case ("1"): player.Race = "Human";
                    Console.WriteLine("You are a human");
                    break;
                case ("2"): player.Race = "Elf";
                    Console.WriteLine("You are an elf");
                    player.Strength -= 2;
                    player.Dexterity += 2;
                    player.Constitution -= 2;
                    player.Intelligence += 2;
                    break;
                case ("3"): player.Race = "Orc";
                    Console.WriteLine("You are an orc");
                    player.Strength += 4;
                    player.Constitution += 4;
                    player.Intelligence -= 4;
                    player.Charisma -= 4;
                    break;
                case ("4"): player.Race = "Drow";
                    Console.WriteLine("You are a drow");
                    player.Strength -= 2;
                    player.Dexterity += 2;
                    player.Constitution -= 2;
                    player.Intelligence += 2;
                    break;
                default: Console.WriteLine("You have to choose between the presented options");
                    SelectRace();
                    break;
            }
        }
        private static void SelectClass()
        {
            Console.WriteLine("Select your class:\n 1. Warrior\n 2. Mage\n 3. Thief \n 4. Commoner \n 5. Waste of skin");
            string classSelector = Console.ReadLine();
            switch (classSelector)
            {
                case ("1"): player.Class = "Warrior";
                    player.Strength++;
                    player.Constitution++;
                    player.Inventory.Add(new Weapon("Longsword", true, 1.0, 0.2, 0.0, 10, 13, 5, DamageType.Pierce));
                    player.Inventory.Add(new Consumable("Health potion", ConsumableEffects.HealthPotion));
                    player.Inventory.Add(new Armor("Chainmail", 5));
                    break;
                case ("2"): player.Class = "Mage";
                    player.Intelligence++;
                    player.Wisdom++;
                    player.Inventory.Add(new Weapon("Magic stick", false, 0.0, 0.0, 1.0, 10, 11, 8, DamageType.Magic));
                    player.Inventory.Add(new Consumable("Mana potion", ConsumableEffects.ManaPotion));
                    player.Inventory.Add(new Armor("Mages robe", 2));
                    break;
                case ("3"): player.Class = "Thief";
                    player.Dexterity++;
                    player.Charisma++;
                    player.Inventory.Add(new Weapon("Poison dagger", false, 0.3, 1.0, 0.0, 14, 18, 2, DamageType.Poison));
                    player.Inventory.Add(new NonConsumable("Lockpick"));
                    player.Inventory.Add(new Armor("Cloak", 3));
                    break;
                case ("4"): player.Class = "Commoner";
                    player.Inventory.Add(new Weapon("Knife", false, 0.5, 0.5, 0.0, 5, 10, 2, DamageType.Pierce));
                    player.Inventory.Add(new Armor("Common clothes", 2));
                    break;
                case ("5"): player.Class = "Waste of skin";
                    player.Strength -= 2;
                    player.Dexterity -= 2;
                    player.Constitution -= 2;
                    player.Intelligence -= 2;
                    player.Wisdom -= 2;
                    player.Charisma -= 2;
                    player.Inventory.Add(new NonConsumable("Blood stained idol"));
                    break;
                default: Console.WriteLine("You have to choose between the presented options");
                    SelectClass();
                    break;
            }
        }
        private static void SelectName()
        {
            Console.Write("What is the name of your character?\n");
            player.Name = Console.ReadLine();
        }
        #endregion

    }
}
