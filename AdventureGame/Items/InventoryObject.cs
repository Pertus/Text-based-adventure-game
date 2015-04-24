using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    public abstract class InventoryObject
    {
        public string Name { get; set; }
        public int Weight { get; set; }
    }
}
