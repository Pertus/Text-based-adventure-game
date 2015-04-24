using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureGame.Chapters.Prologue;
using AdventureGame.Chapters.Prologue.Scenes;

namespace AdventureGame
{
    class ScenesRepository
    {
        public void CreateScenes()
        {
            DungeonScene dungeonScene = new DungeonScene("Dungeon", "Prologue");
            PrologueChapter.EntryPoint = dungeonScene;
        }
    }
}
