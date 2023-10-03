namespace PowAlgorythm;

public abstract class PowTest
{
    //Устанавливаем число, которое будем возводить в степень
    public int Number { get; set; } = 3;
    //Инициализируем шаги
    public List<Steps> Steps { get; set; } = new List<Steps>();
    //Метод, реализованный в производных классах
    public abstract long Run();
    //Метод, реализованный в производных классах
    public abstract string GetName();
}