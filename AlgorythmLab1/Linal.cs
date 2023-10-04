namespace AlgorithmsAnalysis
{
    class Linal : IResercheable
    {
        // присваивает массиву значение 1
        public int Returning(int[] array)
        {
            return 1;
        }
        //запуск программы
        public override void Run(int[] array, int value)
        {
            Returning(array);
        }
        // Инцилизация объекта класса
        public Linal(int size, string name) : base(size, name)
        {
        }
    }
}