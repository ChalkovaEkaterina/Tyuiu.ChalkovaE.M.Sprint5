using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ChalkovaE.M.Sprint5.Task1.V13.Lib;

namespace Tyuiu.ChalkovaE.M.Sprint5.Task1.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнила: Чалкова Е. М. | ИИПб-23-2";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #5                                                                    *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                      *");
            Console.WriteLine("* Задание #1                                                                   *");
            Console.WriteLine("* Вариант #13                                                                  *");
            Console.WriteLine("* Выполнила Чалкова Е. М. | ИИПб-23-2                                          *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Дана функция, произвести табулирование на заданном диапазоне [-5, 5]         *");
            Console.WriteLine("* с шагом 1. Результат сохранить в текстовый файл                              *");
            Console.WriteLine("* и вывести на консоль в таблице. Округлить до 2х знаков после запятой         *");
            Console.WriteLine("*               2x - 3                                                         *");
            Console.WriteLine("*    F(x) =  ------------- + 5                                                 *");
            Console.WriteLine("*             cos(x) + x                                                       *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");
            
            
            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("StartValue = " + startValue);
            Console.WriteLine("StopValue = " + stopValue);
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
