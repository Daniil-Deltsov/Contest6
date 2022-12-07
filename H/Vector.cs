using System;

internal struct Vector : IComparable
{
    int x;
    int y;
    public Vector(int x, int y)
    {
        this.y = y;
        this.x = x;
    }

    public double Length => Math.Sqrt((x * x) + (y * y));

    public static Vector Parse(string input)
    {
        int x, y;
        try
        {
#nullable enable
            string[]? values = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            x = int.Parse(values[0]);
            y = int.Parse(values[1]);
            return new Vector(x, y);
#nullable disable
        }
        catch
        {
            throw new ArgumentException("Incorrect vector");
        }
    }
#nullable enable
    public int CompareTo(object? obj)
    {
        if (obj != null && obj is Vector vector)
            return this.Length.CompareTo(vector.Length);
        else
            throw new ArgumentException();
    }
#nullable disable
}