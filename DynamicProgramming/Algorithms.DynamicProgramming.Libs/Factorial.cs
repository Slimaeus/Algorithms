namespace Algorithms.DynamicProgramming.Libs;

public static class Factorial
{
    public static double IterateCalculate(int number)
    {
        double[] expos = new double[number + 1];
        expos[1] = 1;
        for (int i = 2; i <= number; i++)
        {
            expos[i] = i * expos[i - 1];
        }
        return expos[number];
    }
}

