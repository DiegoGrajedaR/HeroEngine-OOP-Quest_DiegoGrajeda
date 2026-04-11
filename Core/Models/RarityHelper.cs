using PP7_HeroEngine_OOP.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP7_HeroEngine_OOP.Core.Models
{
    public class RarityHelper
    {
        public static double RarityMultiplier(RarityAbility rarity) 
        {
            return rarity switch
            {
                RarityAbility.COMMON => 1.0,
                RarityAbility.RARE => 3.0,
                RarityAbility.EPIC => 5.0,
                RarityAbility.LEGENDARY => 8.0,
                _ => 1.0
            };
        }
    }
}
