using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShtokerVN.Sprint2.Task7.V5.Lib;

namespace Tyuiu.ShtokerVN.Sprint2.Task7.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                     *");
            Console.WriteLine("* Тема: Базовые навыки работы C#                                                                *");
            Console.WriteLine("* Задание #7                                                                                    *");
            Console.WriteLine("* Вариант #5                                                                                    *");
            Console.WriteLine("* Выполнил: Штокер Владимир Николаевич | ИИПБ-23-1                                              *");
            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                      *");
            Console.WriteLine("* Написать программу,  которая запрашивает исходные данные (вещественные значения) и вычисляет, *");
            Console.WriteLine("* находится ли точка с координатами X,Y в заштрихованной области.                               *");
            Console.WriteLine("*                                                                                               *");
            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                              *");
            Console.WriteLine("*************************************************************************************************");

            Console.WriteLine("Введите значение переменной X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение переменной Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                    *");
            Console.WriteLine("*************************************************************************************************");
            if (res)
            {
                Console.WriteLine("Точка находится в заштрихованной области");
            }
            else
            {
                Console.WriteLine("Точка не находится в заштрихованной области");
            }

            Console.ReadKey();        
        }

    }
}
