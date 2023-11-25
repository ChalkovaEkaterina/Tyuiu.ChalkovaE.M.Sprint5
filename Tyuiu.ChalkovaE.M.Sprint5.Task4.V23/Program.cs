using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using Tyuiu.ChalkovaE.M.Sprint5.Task4.V23.Lib;

namespace Tyuiu.ChalkovaE.M.Sprint5.Task4.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнила: Чалкова Е. М. | ИИПб-23-2";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #5                                                                    *");
            Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                          *");
            Console.WriteLine("* Задание #4                                                                   *");
            Console.WriteLine("* Вариант #23                                                                  *");
            Console.WriteLine("* Выполнила Чалкова Е. М. | ИИПб-23-2                                          *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask4V0.txt  Создать папку            *");
            Console.WriteLine("* вручную С:\\DataSprint5\\ и скопировать в неё файл) в котором есть           *");
            Console.WriteLine("* вещественное значение. Прочитать значение из файла и подставить              *");
            Console.WriteLine("* вместо Х в формуле :  y = x^-3 + 2 + cos(x)                                  *");
            Console.WriteLine("* Вычислить значение по формуле (Полученное значение округлить до              *");
            Console.WriteLine("* трёх знаков после запятой) и вернуть полученный результат на консоль.        *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask4V23.txt";
            Console.WriteLine("Данные находятся в файле: " + path);
            
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
