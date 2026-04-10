using PP7_HeroEngine_OOP.Core.Enums;
using PP7_HeroEngine_OOP.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP7_HeroEngine_OOP.Core.Models
{
    public abstract class AAbility : IAbility
    {
        protected string Name { get; set; }
        protected TypeAbility TypeAbility { get; set; }
        protected RarityAbility RarityAbility { get; set; }
        protected int ManaCost { get; set; }


        public AAbility(string name, TypeAbility type, RarityAbility rarity, int manaCost) 
        {
            Name = name;
            TypeAbility = type;
            RarityAbility = rarity;
            ManaCost = manaCost;
        }

        public abstract void Execute(Mage mage);
    }
}
