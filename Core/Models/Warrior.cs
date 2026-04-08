using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP7_HeroEngine_OOP.Core.Models
{
    public class Warrior : AHero
    {
        public int Armor { get; set; }
        public string BattleCry { get; set; }

        public Warrior(string name, int level, string battleCry) : base(name, level)
        {
            BattleCry = battleCry;

            Armor = 20 + ((Level - 1) * 10);
        }

        public override int Attack()
        {
            int damage = 30 + (Level * 5);

            Console.WriteLine($"{Name} screams: '{BattleCry}'\n{Name} attacks! Deals {damage} damage.");
            return damage;
        }

        public override void TakeDamage(int damage)
        {
            int realDamage = damage - Armor;

            if (realDamage < 0)
            { 
                realDamage = 0; 
            }

            Console.WriteLine($"{Name} receives {damage} damage -> absorbed {Math.Min(damage, Armor)} by armor -> real damage: {realDamage}");
            base.TakeDamage(realDamage);
        }

        public override string ToString() => $"[Warrior] {base.ToString()} | Armor: {Armor} | Battle Cry: {BattleCry}";
    }
}
