using PP7_HeroEngine_OOP;
using PP7_HeroEngine_OOP.Core.Enums;
using PP7_HeroEngine_OOP.Core.Models;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        //Hereos creation and the party/group
        List<AHero> partyHeroes =  UIconfig.SetupHeroes();

        //Form the group of enemies

        List<AEnemy> dungeonEnemies = new List<AEnemy>
        {
            new Minion("Slime", UIconfig.lvlOperator.Next(1, 4)),
            new Minion("Goblin", UIconfig.lvlOperator.Next(1, 4)),
            new Minion("Dark Goblin", UIconfig.lvlOperator.Next(1, 4)),
            new Elite("Warrior Skeleton", UIconfig.lvlOperator.Next(4, 6)),
            new Boss("Baldur the Dark Emperor", UIconfig.lvlOperator.Next(7, 10), "DARK PROJECTILE")
        };

        //Start combat
        
        CombatEngine.StartBattle(partyHeroes, dungeonEnemies);


    }
}