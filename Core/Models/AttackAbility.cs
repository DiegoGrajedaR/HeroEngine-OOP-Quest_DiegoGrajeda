using PP7_HeroEngine_OOP.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP7_HeroEngine_OOP.Core.Models
{
    //Ability subclass that can be instantiated and, when used, calculates damage and mana cost.
    public class AttackAbility : AAbility
    {
        public int BaseDamage { get; set; }

        public AttackAbility(string name, RarityAbility rarity) : base(name, TypeAbility.Attack, rarity) 
        {
            BaseDamage = 10;
        }

        public override void Execute(Mage mage)
        {
            double multiplier = RarityHelper.RarityMultiplier(RarityAbility);
            int finalDamage = Convert.ToInt32(BaseDamage * multiplier);
            int finalCost = Convert.ToInt32(ManaCost * multiplier);

            Console.WriteLine($"\nActivating '{Name}' [{RarityAbility}]...");
            Console.WriteLine($"{mage.Name} channels power! Deals {finalDamage} damage to enemies! (Cost: {finalCost})");
        }
    }
}
