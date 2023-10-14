using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShtokerVN.Sprint2.Task1.V28.Lib;

namespace Tyuiu.ShtokerVN.Sprint2.Task1.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int a = 247;
            int b = 654;
            int c = 671;
            int d = 671;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);


            Console.WriteLine("**********************************************************************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                                                                  *");
            Console.WriteLine("* Тема: Базовые навыки работы C#                                                                                                             *");
            Console.WriteLine("* Задание #1                                                                                                                                 *");
            Console.WriteLine("* Вариант #28                                                                                                                                *");
            Console.WriteLine("* Выполнил: Штокер Владимир Николаевич | ИИПБ-23-1                                                                                           *");
            Console.WriteLine("**********************************************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                                                   *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность можно чередовать, но использовать один раз в выражении) *");
            Console.WriteLine("* и логических операций (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться),                                              *");
            Console.WriteLine("* а также арифметических выражений, которая вернет логическую последовательность(массив): (True, False, True, False, True, False)            *");
            Console.WriteLine("*                                                                                                                                            *");
            Console.WriteLine("**********************************************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                                           *");
            Console.WriteLine("**********************************************************************************************************************************************");

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);

            Console.WriteLine("*****************************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                                *");
            Console.WriteLine("*****************************************************************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadKey();
        }
    }
}
