using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GofmanDV.Sprint5.Task1.V16.Lib;
namespace Tyuiu.GofmanDV.Sprint5.Task1.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #5 | Выполнил: Гофман Д. В. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема:   Класс File. Запись набора данных в текстовый файл               *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Гофман Даниил Викторович  | СМАРТб-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить значение функции и записать в текстовый файл*");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("startValue: " + startValue);
            Console.WriteLine("stopValue: " + stopValue);


            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine("Файл создан: " + res);

            Console.ReadKey();
        }
    }
}
