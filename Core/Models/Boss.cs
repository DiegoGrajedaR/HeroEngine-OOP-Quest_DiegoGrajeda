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
        public Boss(string species, int level, string ultimate) : base(species, 90 + (level * 30), 15 + (level * 10)) 
        {
            Ultimate = ultimate;
        }

        public override int Attack()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"-> [ENEMY] {Species} uses ULTIMATE: {Ultimate}!");
            Console.ResetColor();
            return BaseDamage;
        }
    }
}
