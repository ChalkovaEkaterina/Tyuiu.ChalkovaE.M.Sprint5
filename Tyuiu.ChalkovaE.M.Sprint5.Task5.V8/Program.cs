using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using Tyuiu.ChalkovaE.M.Sprint5.Task5.V8.Lib;



namespace Tyuiu.ChalkovaE.M.Sprint5.Task5.V8
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
            Console.WriteLine("* Задание #5                                                                   *");
            Console.WriteLine("* Вариант #8                                                                   *");
            Console.WriteLine("* Выполнила Чалкова Е. М. | ИИПб-23-2                                          *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask5V8.txt (файл взять из архива     *");
            Console.WriteLine("* согласно вашему варианту. Создать папку в ручную С:\\DataSprint5\\ и         *");
            Console.WriteLine("* скопировать в неё файл) в котором есть набор значений. Найти минимальное     *");
            Console.WriteLine("* вещественное число в файле. Полученный результат вывести на консоль.         *");
            Console.WriteLine("* У вещественных значений округлить до трёх знаков после запятой.              *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask5V8.txt";
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Минимальный вещественный элемент в файле = " + res);
            Console.ReadKey();
        }
    }
}
