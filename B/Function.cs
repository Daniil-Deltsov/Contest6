using System;

internal abstract class Function
{
    public static Function GetFunction(string functionName) => throw new NotImplementedException();

    public static double SolveIntegral(Function func, double left, double right, double step)
        => throw new NotImplementedException();
}