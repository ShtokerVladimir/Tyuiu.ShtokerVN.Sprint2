using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShtokerVN.Sprint2.Task0.V11.Lib;

namespace Tyuiu.ShtokerVN.Sprint2.Task0.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int x = 8105;
            int y = 275;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);


            Console.WriteLine("*****************************************************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                                                 *");
            Console.WriteLine("* Тема: Базовые навыки работы C#                                                                                            *");
            Console.WriteLine("* Задание #0                                                                                                                *");
            Console.WriteLine("* Вариант #11                                                                                                               *");
            Console.WriteLine("* Выполнил: Штокер Владимир Николаевич | ИИПБ-23-1                                                                          *");
            Console.WriteLine("*****************************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                                  *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность операций не должна нарушаться)         *");
            Console.WriteLine("* и арифметических выражений, которая вернет логическую последовательность(массив): (True, False, True, False, True, False) *");
            Console.WriteLine("*                                                                                                                           *");
            Console.WriteLine("*****************************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                          *");
            Console.WriteLine("*****************************************************************************************************************************");

            Console.WriteLine("X = " + x);
            Console.WriteLine("Y = " + y);

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
