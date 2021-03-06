﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame.Chapters.Prologue.Scenes
{
    class DungeonScene:Scene
    {
        public DungeonScene(string name, string chapter)
        {
            Name = name;
            Chapter = chapter;
        }
        public override void EntryPoint(Player player)
        {
            WakeUp(player);
        }
        private void WakeUp(Player player)
        {
            Console.Clear();
            Console.WriteLine("When you slowly regain conciousness, you find yourself in a dark and damp place.\nThe smell of dirt and rot is thick in the air.\nWhile your eyes are still adjusting to the darkness, you are fumbling around in the dark. \n Your head hurts.\nAfter just a few seconds you stumble upon what seems like a corpse. \nWhen your eyes have adjusted to the dark you realize that you are in some kind of prison. Ahead of you is a wooden door.\n What do you do?");
            Console.WriteLine("\n1. Search the corpse \n2. Approach the door");
            string selector = Console.ReadLine().ToUpper();
            switch (selector)
            {
                case("1"):
                    Random random = new Random();
                    if (random.Next(0, 10) > 7)
                    {
                        Console.WriteLine("You find a health potion");
                        player.Inventory.Add(new Consumable("Health potion", ConsumableEffects.HealthPotion));
                        CorpseSearched(player);
                    }
                    else
                    {
                        Console.WriteLine("You find nothing");
                        CorpseSearched(player);
                    }
                    break;
                case("2"):
                    DoorApproached(player);
                    break;
                case("INVENTORY"):
                    InventoryViewer.ViewInventory(player);
                    WakeUp(player);
                    break;
                default:
                    Console.WriteLine("You have to choose between the presented options");
                    WakeUp(player);
                    break;

            }
        }
        private void CorpseSearched(Player player)
        {
            Console.WriteLine("What do you do now?");
            Console.WriteLine("1. Approach the wooden door");

            string selector = Console.ReadLine().ToUpper();
            switch (selector)
            {
                case ("1"):
                    DoorApproached(player);
                    break;
                case ("INVENTORY"):
                    InventoryViewer.ViewInventory(player);
                    CorpseSearched(player);
                    break;
                default:
                    Console.WriteLine("You have to choose between the presented options");
                    CorpseSearched(player);
                    break;

            }

        }
        private void DoorApproached(Player player)
        {

            Console.WriteLine("You find a large wooden door. Behind the door you hear the breathing of a person.\nWhat do you do?");
            Console.WriteLine("1. Try to open the door\n2. Talk to the person behind the door\n");
            string selector = Console.ReadLine().ToUpper();
            switch (selector)
            {
                case ("1"):
                    DoorIsLocked(player);
                    break;
                case ("2"):
                    TalkToGuard(player);
                    break;
                case ("INVENTORY"):
                    InventoryViewer.ViewInventory(player);
                    DoorApproached(player);
                    break;
                default:
                    Console.WriteLine("You have to choose between the presented options");
                    DoorApproached(player);
                    break;

            }
        }
        private void DoorIsLocked(Player player)
        {

            Console.WriteLine("The door is locked. What do you do now?");
            if (player.Inventory.FirstOrDefault(x => x.Name == "Lockpick") != null)
            {
                Console.WriteLine("1. Knock on the door\n2. Try to pick the lock with your lockpick\n3. Try to kick in the door");
                string selector = Console.ReadLine().ToUpper();
                switch (selector)
                {
                    case ("1"):
                        TalkToGuard(player);
                        break;
                    case ("2"):
                        LockPicked(player);
                        break;
                    case("3"):
                        if (player.Strength >= 8)
                            BreakSuccess(player);
                        else
                            BreakFail(player);
                        break;
                    case ("INVENTORY"):
                        InventoryViewer.ViewInventory(player);
                        DoorIsLocked(player);
                        break;
                    default:
                        Console.WriteLine("You have to choose between the presented options");
                        DoorIsLocked(player);
                        break;

                }
            }
            else
            {
                Console.WriteLine("1. Knock on the door\n2. Try to kick in the door");
                string selector = Console.ReadLine().ToUpper();
                switch (selector)
                {
                    case ("1"):
                        TalkToGuard(player);
                        break;
                    case ("2"):
                        if (player.Strength >= 8)
                            BreakSuccess(player);
                        else
                            BreakFail(player);
                        break;
                    case ("INVENTORY"):
                        InventoryViewer.ViewInventory(player);
                        DoorIsLocked(player);
                        break;
                    default:
                        Console.WriteLine("You have to choose between the presented options");
                        DoorIsLocked(player);
                        break;
                }
            }

        }
        private void LockPicked(Player player)
        {

            Console.WriteLine("The lock silently clicks open. Outside the door you see the guard, but he hasn't seen you.\n What do you do?");
            Console.WriteLine("1. Try to sneak past the guard\n2. Attack the guard");
            string selector = Console.ReadLine().ToUpper();
            switch (selector)
            {
                case ("1"):
                    if (player.Dexterity > 6)
                        SneakedPastGuard(player);
                    else
                    {
                        Console.WriteLine("You step on a squaky board. The guard notices you and attacks you!");
                        Console.WriteLine("\nPress any key to continue to battle...");
                        Console.ReadLine();
                        Console.WriteLine("Battle!!!");
                    }

                    break;
                case ("2"):
                    Console.WriteLine("You attack the guard from behind");
                    Console.WriteLine("\nPress any key to continue to battle...");
                    Console.ReadLine();
                    Console.WriteLine("Battle!");
                    break;
                case ("INVENTORY"):
                    InventoryViewer.ViewInventory(player);
                    LockPicked(player);
                    break;
                default:
                    Console.WriteLine("You have to choose between the presented options");
                    LockPicked(player);
                    break;

            }

        }
        private void SneakedPastGuard(Player player)
        {
            Console.WriteLine("you sneaked");
        }
        private void BreakSuccess(Player player)
        {
            Console.Clear();
            Console.WriteLine("The door breaks in a loud crash! The guard on the other side looks at you surprised and then attacks you!");
            Console.WriteLine("\nPress any key to continue to battle...");
            Console.ReadLine();
            Console.WriteLine("Battle commenced!");
        }
        private void BreakFail(Player player)
        {
            Console.Clear();
            Console.WriteLine("The door won't budge. But the guard definitley heard you");
            Console.WriteLine("\n Press any key to continue...");
            Console.ReadLine();
            TalkToGuard(player);
        }
        private void TalkToGuard(Player player)
        {
            Console.WriteLine("Guard: Erhm, hello");
            Console.WriteLine("1. 
        }
    }
}
