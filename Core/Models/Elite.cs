using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP7_HeroEngine_OOP.Core.Models
{
    public class Elite : AEnemy
    {
        public Elite(string species, int level) : base(species, 50 + (level * 20), 7 + (level * 3)) { }

        public override int Attack()
        {
            Console.WriteLine($"{Species} (Elite) executes a heavy and precise strike!");
            return BaseDamage;
        }
    }
}
