namespace AlgorithmsAnalysis;

class TreeSort : IResercheable
{
    public override void Run(int[] array, int value)
    {
        var enumerator = array.GetEnumerator();
        enumerator.MoveNext();
        var root = new TreeNode((int)enumerator.Current);
        while (enumerator.MoveNext())
            root.Insert((int)enumerator.Current);
        Array.Copy(root.Parse(new List<int>()).ToArray(), array, array.Length);
    }
    public TreeSort(int size, string name) : base(size, name)
    {
    }
}


