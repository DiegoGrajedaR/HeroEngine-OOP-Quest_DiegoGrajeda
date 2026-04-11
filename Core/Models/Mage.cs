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

        //CHAPTER 2 - New methods related to the abilites class, only mage can use them 

        public List<AAbility> listAbilities = new List<AAbility>();

        public void EquipAbility(AAbility ability)
        {
            listAbilities.Add(ability);
            Console.WriteLine($"Equipped! {ability.Name} added to {Name}'s loadout.");
        }

        public void ShowOrderedAbilities() 
        {
            Console.WriteLine($"\n=== {Name}'s abilities ===");

            if (listAbilities.Count == 0) 
            {
                Console.WriteLine("No abilites equiped!");
                return;
            }

            var orderAbilites = listAbilities.OrderByDescending(a => a.RarityAbility).ToList();

            foreach (var ability in orderAbilites) 
            {
                var costmult = RarityHelper.RarityMultiplier(ability.RarityAbility);

                Console.WriteLine($"- [{ability.RarityAbility.ToString().ToUpper()}] {ability.Name} | Type: { ability.TypeAbility} | Cost: {costmult * ability.ManaCost}");
            }
        }

        public void UseAbility(string abilityName) 
        {
            var ability = listAbilities.FirstOrDefault(a => a.Name.Equals(abilityName));

            if (ability != null)
            {
                ability.Execute(this);
            }
            else 
            {
                Console.WriteLine("This ability does not exist!");
            }
        }
    }
}
