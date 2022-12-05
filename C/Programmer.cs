using System;

internal class Programmer
{
    private readonly int id;
    private readonly int linesOfCode;

    public int Id => id;

    public int LinesOfCode => linesOfCode;

    private int GetAlmostRandomNumber() => (int)Math.Abs(Math.Sin(GetIdDigitsSum() % 11 + 1) * 12345);

    public Programmer(int id)
    {
        this.id = id;
        this.linesOfCode = GetAlmostRandomNumber();
    }

    private int GetIdDigitsSum()
    {
        var sum = 0;
        var idCopy = Id;
        while (idCopy != 0)
        {
            sum += idCopy % 10;
            idCopy /= 10;
        }

        return sum;
    }

    public override string ToString()
    {
        return $"Id: {Id}\nLines of code: {linesOfCode}";
    }
}