using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame.Chapters
{
    abstract class Scene
    {
        public string Name { get; set; }
        public string Chapter { get; set; }
        public abstract void EntryPoint(Player player);
    }
}
