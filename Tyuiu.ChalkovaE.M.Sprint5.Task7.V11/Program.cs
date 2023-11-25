using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using Tyuiu.ChalkovaE.M.Sprint5.Task7.V11.Lib;


namespace Tyuiu.ChalkovaE.M.Sprint5.Task7.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнила: Чалкова Е. М. | ИИПб-23-2";
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* Спринт #5                                                                     *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                       *");
            Console.WriteLine("* Задание #7                                                                    *");
            Console.WriteLine("* Вариант #11                                                                   *");
            Console.WriteLine("* Выполнила Чалкова Е. М. | ИИПб-23-2                                           *");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                      *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask7V11.txt в котором есть набор      *");
            Console.WriteLine("* символьных данных.Удалить все строчные русские буквы из файла.                *");
            Console.WriteLine("* Полученный результат сохранить в файл OutPutDataFileTask7V11.txt.             *");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                              *");
            Console.WriteLine("*********************************************************************************");
            string path = @"C:\DataSprint5\InPutDataFileTask7V11.txt";
            string pathSaveFile = @"C:\DataSprint5\OutPutDataFileTask7V11.txt";
            Console.WriteLine("Данные из файла: " + path);
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                    *");
            Console.WriteLine("*********************************************************************************");
            pathSaveFile = ds.LoadDataAndSave(path);
            Console.WriteLine(pathSaveFile);
            Console.ReadKey();
        }
    }
}
