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
        public string Name { get; set; }
        protected TypeAbility TypeAbility { get; set; }
        protected RarityAbility RarityAbility { get; set; }
        protected int ManaCost { get; set; }


        public AAbility(string name, TypeAbility type, RarityAbility rarity) 
        {
            Name = name;
            TypeAbility = type;
            RarityAbility = rarity;
            ManaCost = 5;
        }

        public abstract void Execute(Mage mage);
    }
}
