using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShtokerVN.Sprint2.Task6.V9.Lib;

namespace Tyuiu.ShtokerVN.Sprint2.Task6.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("*******************************************************************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы C#                                                                                                          *");
            Console.WriteLine("* Задание #5                                                                                                                              *");
            Console.WriteLine("* Вариант #15                                                                                                                             *");
            Console.WriteLine("* Выполнил: Штокер Владимир Николаевич | ИИПБ-23-1                                                                                        *");
            Console.WriteLine("*******************************************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                                                *");
            Console.WriteLine("* Написать программу,  которая использует  сокращенную форму записи оператора switch вычисляет требуемое значение и возвращает результат. *");
            Console.WriteLine("* Дата некоторого дня характеризуется двумя натуральными числами: m (порядковый номер месяца) и n (число).                                *");
            Console.WriteLine("* По заданным n и m определить дату следующего дня (принять, что n и m не характеризуют 31 декабря).                                      *");
            Console.WriteLine("*                                                                                                                                         *");
            Console.WriteLine("*******************************************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                                        *");
            Console.WriteLine("*******************************************************************************************************************************************");

            Console.WriteLine("Введите номер месяца: ");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("*******************************************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                                              *");
            Console.WriteLine("*******************************************************************************************************************************************");

            if ((m > 12) || (m < 1) || (n > 31) || (n < 1))
            {
                Console.WriteLine("Такой даты не существует");
            }
            else
            {
                string Data = ds.FindDateOfNextDay(m, n);
                Console.WriteLine(Data);
            }
            Console.ReadKey();
        }
    }
}
