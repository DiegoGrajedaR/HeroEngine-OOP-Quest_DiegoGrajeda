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
        public TypeAbility TypeAbility { get; set; }
        public RarityAbility RarityAbility { get; set; }
        public int ManaCost { get; set; } = 5;

        //Constructor 
        public AAbility(string name, TypeAbility type, RarityAbility rarity) 
        {
            Name = name;
            TypeAbility = type;
            RarityAbility = rarity;
        }

        public abstract void Execute(Mage mage);
    }
}
