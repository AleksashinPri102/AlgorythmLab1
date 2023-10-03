namespace PowAlgorythm;
//Классический алгоритм быстрого возведения в степень.
public class QuickPow1 : PowTest
{
    public override long Run()
    {
        long res = 1;
        //Перебираем степени.
        for (int i = 0; i < 2000; i++)
        {
            int count = 0;
            int number = Number;
            res = 1;
            int degree = i;

            while (degree != 0)
            {
                //Если степень четная, то выполняем возводение в квадрат, и степень делим на 2. При этом, количество шагов count увеличиваем на 2.
                if (degree % 2 == 0)
                {
                    number *= number;
                    degree /= 2;
                    count += 2;
                }
                //сли степень нечетная, то делаем умножение результата на текущее значение, степень уменьшаем на 1, и количество шагов увеличиваем на 2.
                else
                {
                    res *= number;
                    degree--;
                    count += 2;

                }
            }
            //Записываем степень и количество пройденных шагов
            Steps.Add(new Steps(degree: i, stepNumber: count));

        }


        return res;
    }
    //Возвращаем строку "QuickPow1", указывая на то, что это реализация классического алгоритма быстрого возведения в степень.
    public override string GetName()
    {
        return "QuickPow1";
    }
}