using PP7_HeroEngine_OOP.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PP7_HeroEngine_OOP.Core.Models
{
    public class HealingAbility : AAbility
    {
        //Ability subclass that can be instantiated and, when used, calculates healing and mana cost.
        public int BaseHeal { get; set; }

        public HealingAbility(string name, RarityAbility rarity, int manaCost) : base(name, TypeAbility.Attack, rarity)
        {
            BaseHeal = 10;
        }

        public override void Execute(Mage mage)
        {
            double multiplier = RarityHelper.RarityMultiplier(RarityAbility);
            int finalHeal = Convert.ToInt32(BaseHeal * multiplier);
            int finalCost = Convert.ToInt32(ManaCost * multiplier);

            Console.WriteLine($"\nActivating '{Name}' [{RarityAbility}]...");
            Console.WriteLine($"{mage.Name} casts a healing spell! Restores {finalHeal} HP. (Cost: {finalCost})");
        }
    }
}
