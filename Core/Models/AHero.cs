using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP7_HeroEngine_OOP.Core.Models
{
    public abstract class AHero
    {
        public string Name { get; set; } 
        protected int Level { get; set; } 
        protected int MaxHP { get; set; } 
        protected int CurrentHP { get; set; }
        public bool IsDefeated => CurrentHP <= 0;

        //CHAPTER 1 - Hero Constructor
        public AHero(string name, int level) 
        {
            Name = name;
            Level = level > 0 ? level : 1;

            MaxHP = 100 + ((Level - 1) * 10);
            CurrentHP = MaxHP;
        }

        //CHAPTER 1 - Methods for attack, take damage and display stats
        public abstract int Attack();

        public virtual void TakeDamage(int damage) 
        {
            CurrentHP -= damage;

            if (CurrentHP < 0)
            {
                CurrentHP = 0;
            }
        }

        public override string ToString() => $"{Name} | Level: {Level} | HP: {CurrentHP}/{MaxHP}";

        //CHAPTER 2
        public List<AAbility> listAbilities = new List<AAbility>();

        public void EquipAbility(AAbility ability) 
        {
            listAbilities.Add(ability);
            Console.WriteLine($"[Equipped] {ability.Name} added to {Name}'s loadout.");
        }


    }
}
