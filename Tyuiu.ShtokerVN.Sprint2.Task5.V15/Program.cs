using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShtokerVN.Sprint2.Task5.V15.Lib;

namespace Tyuiu.ShtokerVN.Sprint2.Task5.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("*******************************************************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                                                   *");
            Console.WriteLine("* Тема: Базовые навыки работы C#                                                                                              *");
            Console.WriteLine("* Задание #5                                                                                                                  *");
            Console.WriteLine("* Вариант #15                                                                                                                 *");
            Console.WriteLine("* Выполнил: Штокер Владимир Николаевич | ИИПБ-23-1                                                                            *");
            Console.WriteLine("*******************************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                                    *");
            Console.WriteLine("* Написать программу,  которая использует оператор switch вычисляет требуемое значение и возвращает результат.                *");
            Console.WriteLine("* Дано целое число k (1 <= k <= 365). Определить, каким днем недели (понедельником, вторником, …, субботой или воскресеньем)  *");
            Console.WriteLine("* является k-й день не високосного года, в котором 1 января понедельник.                                                      *");
            Console.WriteLine("*                                                                                                                             *");
            Console.WriteLine("*******************************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                            *");
            Console.WriteLine("*******************************************************************************************************************************");

            Console.WriteLine("Введите число: ");
            int numDay = Convert.ToInt32(Console.ReadLine());

            string res;

            if ((numDay < 1) || (numDay > 365))
            {
                res = "Введенно неверное значение!";
            }
            else
            {
                res = "Это день недели: " + ds.FindDayName(numDay);
            }

            Console.WriteLine("*******************************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                                  *");
            Console.WriteLine("*******************************************************************************************************************************");


            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
