using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PowAlgorythm;

public class Pow : PowTest
{
    public override long Run()
    {
        long res = 1;
        //Перебираем степени.
        for (int i = 0; i < 2000; i++)
        {
            int count = 0;
            res = 1;
            int degree = i;
            for (int j = 0; j < degree; j++)
            {
                res *= Number;
                count++;

            }
            //Записываем степень и количество пройденных шагов
            Steps.Add(new Steps(degree: degree, stepNumber: count));
        }

        return res;
    }
    //Возвращаем строку "Pow", указывая на то, что это реализация алгоритма возведения в степень с использованием обычного умножения (без оптимизаций).
    public override string GetName()
    {
        return "Pow";
    }
}