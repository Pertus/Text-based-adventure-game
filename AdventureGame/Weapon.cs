using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Weapon:InventoryObject
    {
        public bool TwoHanded { get; set; }
        public double StrScaling { get; set; }
        public double DexScaling { get; set; }
        public double IntScaling { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public int AttackBonus { get; set; }
        public DamageType DamageType { get; set; }

        public Weapon(string name, bool twoHanded, double strScaling, double dexScaling, double intScaling, int minDamage, int maxDamage, int attackBonus, DamageType damageType)
        {
            Name = name;
            TwoHanded = twoHanded;
            StrScaling = strScaling;
            DexScaling = dexScaling;
            IntScaling = intScaling;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            AttackBonus = attackBonus;
            DamageType = damageType;
            
        }
    }

    public enum DamageType
    {
        Pierce,
        Blunt,
        Slash,
        Magic,
        Poison
    }
}
