using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AdventureGame.Chapters.Prologue
{
    static class PrologueChapter
    {
        public static string Name = "Prologue";
        public static Scene EntryPoint { get; set; }

        

        public static void Start(Player player)
        {
            //Console.WriteLine("PROLOGUE");
            //Thread.Sleep(2000);
            //Console.Clear();
            //Thread.Sleep(2000);
            //Console.WriteLine("In the beginning, there was fire...");
            //Thread.Sleep(3000);
            //Console.Clear();
            //Thread.Sleep(2000);
            EntryPoint.EntryPoint(player);
        }

    }
}
