using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP7_HeroEngine_OOP.Core.Models
{
    public class Mage : AHero
    {
        public int Mana { get; set; }
        public int ArcaneLvl { get; set; }

        //Mage Constructor to instantiate
        public Mage(string name, int level, int arcaneLvl) : base(name, level) 
        {
            ArcaneLvl = arcaneLvl;

            Mana = 50 + ((level - 1) * 20);
        }

        //CHAPTER 1 - Overriden methods of the parent class AHero
        public override int Attack()
        {
            int manaCost = 10;

            if (Mana >= manaCost)
            {
                Mana -= manaCost;
                int damage = 40 + (ArcaneLvl * 5);

                Console.WriteLine($"{Name} casts a spell! Deals {damage} damage. Remaining Mana: {Mana}");
                return damage;
            }
            else 
            {
                Console.WriteLine($"{Name} tries to cast a spell but is out of mana! Deals 10 physical damage.");
                return 10;
            }
        }

        public override string ToString() => $"[Mage] {base.ToString()} | Mana: {Mana} | ArcaneLvl: {ArcaneLvl}";
    }
}
