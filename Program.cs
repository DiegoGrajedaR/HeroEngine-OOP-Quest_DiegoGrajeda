using PP7_HeroEngine_OOP.Core.Enums;
using PP7_HeroEngine_OOP.Core.Models;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Mage gandalf = new Mage("Gandalf", 2, 2);

        AAbility fireball = new AttackAbility("Fireball", RarityAbility.LEGENDARY);
        AAbility healing = new AttackAbility("Healing", RarityAbility.EPIC);

        Console.WriteLine(gandalf.ToString());

        gandalf.EquipAbility(fireball);
        gandalf.EquipAbility(healing);

        gandalf.ShowOrderedAbilities();

        gandalf.UseAbility("Fireball");
        gandalf.UseAbility("Healing");

        Console.WriteLine(gandalf.ToString());

    }
}