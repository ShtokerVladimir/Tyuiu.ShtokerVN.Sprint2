using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShtokerVN.Sprint2.Task4.V29.Lib;

namespace Tyuiu.ShtokerVN.Sprint2.Task4.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                         *");
            Console.WriteLine("* Тема: Базовые навыки работы C#                                                                    *");
            Console.WriteLine("* Задание #4                                                                                        *");
            Console.WriteLine("* Вариант #29                                                                                       *");
            Console.WriteLine("* Выполнил: Штокер Владимир Николаевич | ИИПБ-23-1                                                  *");
            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                          *");
            Console.WriteLine("* Написать программу, которая  вычисляет требуемое значение с использованием тернарного оператора,  *");
            Console.WriteLine("* где пользователь вводит значение переменной X и Y с клавиатуры.                                   *");
            Console.WriteLine("*                                                                                                   *");
            Console.WriteLine("*****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                  *");
            Console.WriteLine("*****************************************************************************************************");
           

            Console.WriteLine("Введите значение переменной X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение переменной Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            double res = ds.Calculate(x, y);

            Console.WriteLine("*********************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                        *");
            Console.WriteLine("*********************************************************************************************************************");

            Console.WriteLine("Значение функции =" + res);
            Console.ReadKey();
        }
    }
}
