using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP7_HeroEngine_OOP.Core.Models
{
    public class Boss : AEnemy
    {
        public string Ultimate { get; set; }
        public Boss(string species, int level, string ultimate) : base(species,  + (level * 20), 10 + (level * 5)) 
        {
            Ultimate = ultimate;
        }

        public override int Attack()
        {
            Console.WriteLine($"{Species} uses ULTIMATE: {Ultimate}!");
            return BaseDamage;
        }
    }
}
