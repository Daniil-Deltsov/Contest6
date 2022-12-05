using System;
using System.Collections.Generic;

internal sealed class Wizard : LegendaryHuman
{
    List<string> ranks = new List<string>() { "Neophyte", "Adept", "Charmer", "Sorcerer", "Master", "Archmage" };

    public static string _currRank;
    private int Strength
    {
        get
        {
            return Power * (int)(Math.Pow(ranks.IndexOf(_currRank), 1.5)) + HealthPoints / 10;
        }
    }


    public Wizard(string name, int healthPoints, int power, string rank) : base(name, healthPoints, power)
    {
        if (!ranks.Contains(rank))
        {
            throw new ArgumentException("Invalid wizard rank.");
        }

        _currRank = rank; 
    }

    public override void Attack(LegendaryHuman enemy)
    {
        if ((enemy.HealthPoints > 0) && (HealthPoints > 0))
        {
            enemy.HealthPoints = enemy.HealthPoints - HealthPoints;
            if (enemy.HealthPoints <= 0)
            {
                Console.WriteLine($"Knight {Name} with HP {HealthPoints} is dead");
            }
            else { }
        }
    }

    public override string ToString()
    {
        return $"{_currRank} Wizard {Name} with HP {HealthPoints} ";
    }
}