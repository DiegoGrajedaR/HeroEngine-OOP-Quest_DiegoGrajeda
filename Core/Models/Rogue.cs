using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP7_HeroEngine_OOP.Core.Models
{
    public class Rogue : AHero
    {
        public double StealthMultiplier { get; set; }
        public int HiddenDaggers { get; set; }

        public Rogue(string name, int level, int hiddenDaggers) : base(name, level) 
        {
            HiddenDaggers = hiddenDaggers;
            StealthMultiplier = 1 + ((level - 1) * 0.2);
        }

        public override int Attack()
        {
            if (HiddenDaggers > 0)
            {
                HiddenDaggers--;
                int damage = Convert.ToInt32(25 * StealthMultiplier);
                Console.WriteLine($"{Name} throws a dagger! Deals {damage} damage. (Daggers left: {HiddenDaggers})");
                return damage;
            }
            else 
            {
                Console.WriteLine($"{Name} has no daggers! Deals 15 physical damage.");
                return 15;
            }
        }

        public override string ToString() => $"[Rogue] {base.ToString()} | Stealth Multiplier: {StealthMultiplier} | Daggers: {HiddenDaggers}";
    }
}
