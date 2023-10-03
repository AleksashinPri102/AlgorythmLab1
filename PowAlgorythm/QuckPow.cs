namespace PowAlgorythm;
//Алгоритм быстрого возведения в степень.
public class QuickPow : PowTest
{
    public override long Run()
    {
        long res = 0;
        //Перебираем степени.
        for (int i = 0; i < 2000; i++)
        {
            int count = 0;
            int number = Number;
            int degree = i;
            //Определяем значение степени чет, нечет. Если чет то res = 1, иначе rec = Number.
            res = degree % 2 == 1 ? Number : 1;

            do
            {
                //Уменьшаем степень вдвое для каждой итерации.
                degree /= 2;
                number *= number;

                if (degree % 2 == 1)
                {
                    res *= number;
                    count++;
                }

                count += 2;

            } while (degree != 0);
            //Записываем степень и количество пройденных шагов
            Steps.Add(new Steps(degree: i, stepNumber: count));
        }


        return res;
    }
    //Возвращаем строку "QuickPow", указывая на то, что это реализация алгоритма быстрого возведения в степень.
    public override string GetName()
    {
        return "QuickPow";
    }
}