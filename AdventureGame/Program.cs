using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Program
    {
        //Character information
        static string gender;
        static string race;
        static string characterClass;

        //Character stats
        static int str;
        static int dex;
        static int con;
        static int intelligence;
        static int wis;
        static int charisma;

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
            str = 6;
            dex = 6;
            con = 6;
            intelligence = 6;
            wis = 6;
            charisma = 6;

            Console.WriteLine("------Character creation------\n");
            SelectGender();
            SelectRace();
            SelectClass();
            Console.WriteLine("You are a " + gender.ToLower() + " " + race.ToLower() + " " + characterClass.ToLower() + 
                "\n\n Your stats is:\n Strength: " + str + "\n Dexterity: " + dex + "\n Constitution: " + con + "\n Intelligence: " + intelligence + 
                "\n Wisdom: "+ wis + "\n Charisma: " + charisma + "\n\n Is this ok?\n 1. Yes \n 2. No");
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
                case ("1"): gender = "Female";
                    Console.WriteLine("Your gender is female\n");
                    break;
                case ("2"): gender = "Male";
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
                case ("1"): race = "Human";
                    Console.WriteLine("You are a human");
                    break;
                case ("2"): race = "Elf";
                    Console.WriteLine("You are an elf");
                    dex += 2;
                    str -= 2;
                    con -= 2;
                    intelligence += 2;
                    break;
                case ("3"): race = "Orc";
                    Console.WriteLine("You are an orc");
                    str += 4;
                    con += 4;
                    intelligence -= 4;
                    charisma -= 4;
                    break;
                case ("4"): race = "Drow";
                    Console.WriteLine("You are a drow");
                    dex += 2;
                    str -= 2;
                    con -= 2;
                    intelligence += 2;
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
                case ("1"): characterClass = "Warrior";
                    break;
                case ("2"): characterClass = "Mage";
                    break;
                case ("3"): characterClass = "Thief";
                    break;
                case ("4"): characterClass = "Commoner";
                    break;
                case ("5"): characterClass = "Waste of skin";
                    break;
                default: Console.WriteLine("You have to choose between the presented options");
                    SelectClass();
                    break;
            }
        }
        #endregion

    }
}
