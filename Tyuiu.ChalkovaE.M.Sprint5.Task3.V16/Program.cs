using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ChalkovaE.M.Sprint5.Task3.V16.Lib;

namespace Tyuiu.ChalkovaE.M.Sprint5.Task3.V16
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
            Console.WriteLine("* Задание #3                                                                   *");
            Console.WriteLine("* Вариант #16                                                                  *");
            Console.WriteLine("* Выполнила Чалкова Е. М. | ИИПб-23-2                                          *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить в       *");
            Console.WriteLine("*  бинарный файл OutPutFileTask3.bin и вывести на консоль. Округлить до трёх   *");
            Console.WriteLine("* знаков после запятой.                                                        *");
            Console.WriteLine("*             2x^2 - 1                                                         *");
            Console.WriteLine("*    y(x) =  -----------                                                       *");
            Console.WriteLine("*            (x^2 - 2)^0.5                                                     *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");
            int x = 3;
            Console.WriteLine("Значение переменной X = " + x);
            string res = ds.SaveToFileTextData(x);
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
