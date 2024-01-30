namespace Algorithms.DynamicProgramming.Libs;

public static class Exponential
{
    public static float Calculate(int num, int expo)
    {
        if (expo < 0)
        {
            return Calculate(num, expo + 1) * (1 / (float)num);
        }
        if (expo == 0) return 1;
        if (expo == 1)
        {
            return num;
        }
        return Calculate(num, expo - 1) * num;
    }
}

