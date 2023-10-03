using System.Text;

namespace PowAlgorythm;
//Класс для записи результатов в формате csv
public class Export
{
    public static void ExportAsCsvPow(PowTest pow)
    {
        //Получаем путь для сохранения файла
        string path =
            $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\{pow.GetName()}_{DateTime.Now.ToString("yyyy-M-dd")}.csv";
        //Выводим в консоль куда сохранили файл
        Console.WriteLine($"File saved at: {path}");
        StringBuilder sb = new StringBuilder();
        //Делаем заголовок
        sb.AppendLine($"Tested algorithm:;{pow.GetName()}");
        //Делаем заголовки столбцов
        sb.AppendLine($"Number;Degree;Steps");
        //Записываем каждый результат
        foreach (var step in pow.Steps)
        {
            sb.AppendLine($"{pow.Number};{step.Degree};{step.StepNumber}");
        }
        //Записываем всё в файл
        File.WriteAllText(path, sb.ToString());
    }
}