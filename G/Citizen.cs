using System;

class Citizen : IOptimist, IPessimist
{
    int salary;
    public Citizen(int predictedValue)
    {
        this.salary = predictedValue;
    }

    double IOptimist.GetForecast()
    {
        return this.salary * 2;
    }
    double IPessimist.GetForecast()
    {
        return this.salary * 0.6;
    }
    public double GetForecast()
    {
        return (this.salary * 0.1) + this.salary;
    }
    internal static Citizen Parse(string input)
    {
        int salary;
        if (!int.TryParse(input, out salary) || salary < 0)
        {
            throw new ArgumentException("Incorrect citizen");
        }
        return new Citizen(salary);
    }
}