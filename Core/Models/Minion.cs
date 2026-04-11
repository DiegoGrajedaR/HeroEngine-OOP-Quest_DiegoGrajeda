using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP7_HeroEngine_OOP.Core.Models
{
    public class Minion : AEnemy
    {
        public Minion(string species, int level) : base(species, 10 + (level * 10), 5 + (level)) { }

        public override int Attack()
        {
            Console.WriteLine($"{Species} lunges forward!");
            return BaseDamage;
        }
    }
}
