namespace AlgorithmsAnalysis
{
    public class Multiplication : IResercheable
    {
        // Запуск перемножение
        public override void Run(int[] array, int value)
        {
            int difference = 1;
            foreach (int elem in array)
            {
                difference *= elem;
            }
        }
        //Конструктор класса, который принимает имя и размер массива.
        public Multiplication(int size, string name) : base(size, name)
        {
        }
    }
}