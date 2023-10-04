namespace AlgorithmsAnalysis
{
    class TreeNode
    {
        public TreeNode(int num) => number = num;
        int number;
        TreeNode? left;
        TreeNode? right;

        // Рекурсивный алгоритм вставки числа в двоичное дерево
        public void Insert(int num)
        {
            if (num < number)
            {
                if (left == null)
                    left = new TreeNode(num);
                else
                    left.Insert(num);
            }
            else
            {
                if (right == null)
                    right = new TreeNode(num);
                else
                    right.Insert(num);
            }
        }

        // Рекурсивный алгоритм обхода дерева
        public List<int> Parse(List<int> array)
        {
            if (left != null)
                left.Parse(array);
            array.Add(number);
            if (right != null)
                right.Parse(array);
            return array;
        }
    }
}