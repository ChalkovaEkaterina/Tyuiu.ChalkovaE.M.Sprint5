using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ChalkovaE.M.Sprint5.Task0.V15.Lib;

namespace Tyuiu.ChalkovaE.M.Sprint5.Task0.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнила: Чалкова Е. М. | ИИПб-23-2";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #5                                                                    *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                             *");
            Console.WriteLine("* Задание #0                                                                   *");
            Console.WriteLine("* Вариант #15                                                                  *");
            Console.WriteLine("* Выполнила Чалкова Е. М. | ИИПб-23-2                                          *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить в       *");
            Console.WriteLine("* текстовый файл OutPutFileTask0.txt и вывести на консоль. Округлить до трёх   *");
            Console.WriteLine("* знаков после запятой.                                                        *");
            Console.WriteLine("*             x                                                                *");
            Console.WriteLine("*    y =  --------                                                             *");
            Console.WriteLine("*          x^3 + 2                                                             *");
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
