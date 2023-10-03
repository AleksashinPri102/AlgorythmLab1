namespace PowAlgorythm;
//Класс для храния информации о каждом шаге
public class Steps
{
    //Конструктор в котором у нас шаги и степень
    public Steps(int stepNumber, int degree)
    {
        StepNumber = stepNumber;
        Degree = degree;
    }

    public int StepNumber { get; set; }
    public int Degree { get; set; }

}