namespace PowAlgorythm;
//Алгоритм рекурсивного возведения в степень.
public class RecPow : PowTest
{
    private int stepsCount;
    public override long Run()
    {
        long result = 0;
        for (int i = 0; i < 2000; i++)
        {
            stepsCount = 0;
            long tempResult = RecAlgorithm(i);
            Steps.Add(new Steps(degree: i, stepNumber: stepsCount));
            result += tempResult;
        }

        return result;
    }
    //Возвращаем строку "RecPow", указывая на то, что
    //это реализация алгоритма рекурсивного возведения в степень.
    public override string GetName()
    {
        return "RecPow";
    }

    private long RecAlgorithm(int degree)
    {
        //Если возводим в нулевую степень, возвращаем единицу
        if (degree == 0)
        {
            stepsCount++;
            return 1;
        }

        //Иначе метод вызывает сам себя и делить степень на 2
        long res = RecAlgorithm(degree / 2);

        //Если степень нечетная, то результат умножается на себя
        //и умножается на 2, и счетчик увеличивается на 1.
        if (degree % 2 == 1)
        {
            stepsCount++;
            return res * res * 2;
        }
        //Если степень четная, то результат умножается на себя, и счетчик увеличивается на 1.
        stepsCount++;

        return res * res;
    }
}
