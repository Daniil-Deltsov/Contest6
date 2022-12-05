using System;

internal sealed class Knight : LegendaryHuman
{
    private int _equiment;
    private int Strength
    {
        get
        {
            return Power + 10 * _equiment; 
        }
    }

    public Knight(string name, int healthPoints, int power, string[] equipment) : base(name, healthPoints, power)
    {
        if (equipment == null)
        {
            throw new ArgumentException("Not enough equipment.");
        }
        _equiment = equipment.Length;
    }

    public override void Attack(LegendaryHuman enemy)
    {
        if ((enemy.HealthPoints > 0) && (HealthPoints > 0))
        {
            enemy.HealthPoints = enemy.HealthPoints - HealthPoints;
            if (enemy.HealthPoints <= 0)
            {
                Console.WriteLine($"{Wizard._currRank} Wizard {Name} with HP {HealthPoints} is dead");
            } else { }
        }
    }

    public override string ToString()
    {
        return $"Knight {Name} with HP {HealthPoints} ";
    }
}