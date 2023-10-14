using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShtokerVN.Sprint2.Task3.V20.Lib;

namespace Tyuiu.ShtokerVN.Sprint2.Task3.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("*********************************************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                                         *");
            Console.WriteLine("* Тема: Базовые навыки работы C#                                                                                    *");
            Console.WriteLine("* Задание #3                                                                                                        *");
            Console.WriteLine("* Вариант #20                                                                                                       *");
            Console.WriteLine("* Выполнил: Штокер Владимир Николаевич | ИИПБ-23-1                                                                  *");
            Console.WriteLine("*********************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                          *");
            Console.WriteLine("* Написать программу, которая  вычисляет требуемое значение функции Y с использованием вложенных оператор if-else,  *");
            Console.WriteLine("* где пользователь вводит значение переменной X с клавиатуры.                                                       *");
            Console.WriteLine("*                                                                                                                   *");
            Console.WriteLine("*********************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                  *");
            Console.WriteLine("*********************************************************************************************************************");
            Console.WriteLine("    x(x + 1/ x - 1) ^ x , если x > 1");
            Console.WriteLine("    x^2 - cos(x)^2 + 10 / x^2 - sin(x)^2 + 12 , если x = 0");
            Console.WriteLine("y =");
            Console.WriteLine("    (1 + 1/ x^2)^x , если -24 < x < 2");
            Console.WriteLine("    x + 10*x - (1/x) , если x < -24");

            Console.WriteLine("Введите значение переменной X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x);


            Console.WriteLine("*********************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                        *");
            Console.WriteLine("*********************************************************************************************************************");

            Console.WriteLine("Значение функции =" + res);
            Console.ReadKey();















        }
    }
}
