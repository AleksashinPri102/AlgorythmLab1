namespace AlgorithmsAnalysis
{
    public class QuickSort : IResercheable
    {
        public static int[] Calculate(int[] vector)
        {
            // проверяет, если длина массива меньше или равна 1,
            // то возвращает исходный массив без изменений.
            if (vector.Length <= 1) return vector;
            //генерирует случайное число из массив
            var randomNum = vector[new Random().Next(0, vector.Length)];

            int bigCount = 0;
            int lowCount = 0;
            int equalCount = 0;

            //выполняет цикл для каждого элемента в массиве
            foreach (var element in vector)
            {
                if (element > randomNum)
                    bigCount++;
                else if (element < randomNum)
                    lowCount++;
                else
                    equalCount++;
            }

            //создает новые массивы на основе вычисленных счетчиков
            int[] bigElements = new int[bigCount];
            int[] lowElements = new int[lowCount];
            int[] equalElements = new int[equalCount];

            int lowindex = 0;
            int bigindex = 0;
            int equalindex = 0;
            // Cортировка каждого эллемента массива
            for (int i = 0; i < vector.Length; i++)
            {
                var element = vector[i];
                if (element > randomNum)
                    bigElements[bigindex++] = element;
                else if (element < randomNum)
                    lowElements[lowindex++] = element;
                else
                    equalElements[equalindex++] = element;
            }
            // вызов метода для отсортированных массивов
            Calculate(lowElements);
            Calculate(bigElements);

            //перезаписывает массив отсортированными елементами
            for (int i = 0; i < vector.Length; i++)
            {
                if (i < lowElements.Length)
                    vector[i] = lowElements[i];
                else if (i - lowElements.Length < equalElements.Length)
                    vector[i] = equalElements[i - lowElements.Length];
                else
                    vector[i] = bigElements[i - lowElements.Length - equalElements.Length];
            }
            return vector;
        }

        //Конструктор класса, который принимает имя и размер массива.
        public QuickSort(int size, string name) : base(size, name)
        {
        }

        public override void Run(int[] array, int value = 0)
        {
            Calculate(array);
        }
    }
}