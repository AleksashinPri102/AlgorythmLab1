namespace AlgorithmsAnalysis;

public class GornerDirect : IResercheable
{
    static double Direct(int[] array)
    {
        double x = 1.5;
        double result = 0;

        for (int k = 1; k < array.Length + 1; k++)
        {
            result += array[k - 1] * Math.Pow(x, k - 1);
        }

        return result;
    }

    public GornerDirect(int size, string name) : base(size, name)
    {
    }

    public override void Run(int[] array, int value = 0)
    {
        Direct(array);
    }
}