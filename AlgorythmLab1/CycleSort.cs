namespace AlgorithmsAnalysis;

class CycleSort : IResercheable
{
    //Выполняем обмен значениями между правым и левым элементом.
    public static void Swap(ref int leftItem, ref int rightItem)
    {
        int temp = leftItem;

        leftItem = rightItem;

        rightItem = temp;
    }
    public override void Run(int[] array, int value)
    {

        for (int cycleStart = 0; cycleStart < array.Length - 1; cycleStart++)
        {
            //Прогоняем итерации сортировки.
            int elem = array[cycleStart];
            int pos = cycleStart;

            //Ищем позицию, куда вставить элемент.
            for (int i = cycleStart + 1; i < array.Length; i++)
            {
                if (array[i] < elem)
                {
                    pos += 1;
                }
            }
            //Если элемент уже стоит на месте, то сразу переходим к следующей итерации внешнего цикла.
            if (pos == cycleStart) continue;

            //В противном случае, помещаем элемент на правильное место или сразу после всех его дубликатов.
            while (elem == array[pos])
            {
                pos += 1;
            }

            Swap(ref array[pos], ref elem);


            //Циклический круговорот продолжается до тех пор, пока на текущей позиции не окажется её элемент.
            while (pos != cycleStart)
            {
                //Ищем, куда переместить элемент.
                pos = cycleStart;
                for (int i = cycleStart + 1; i < array.Length; i++)
                {
                    if (array[i] < elem)
                    {
                        pos += 1;
                    }
                }
                //Помещаем элемент на своё место или сразу после его дубликатов.
                while (elem == array[pos])
                {
                    pos += 1;
                }

                Swap(ref array[pos], ref elem);
            }
        }


    }
    //Конструктор класса, который принимает имя и размер массива.
    public CycleSort(int size, string name) : base(size, name)
    {
    }
}