using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShtokerVN.Sprint2.Task5.V15.Lib
{
    public class DataService : ISprint2Task5V15
    {
        public string FindDayName(int k)
        {

            string res;

            int reman = (k - 1) % 7;

            switch(reman)
            {
                case 0:
                    res = "Понедельник";
                    break;
                case 1:
                    res = "Вторник";
                    break;
                case 2:
                    res = "Среда";
                    break;
                case 3:
                    res = "Четверг";
                    break;
                case 4:
                    res = "Пятница";
                    break;
                case 5:
                    res = "Суббота";
                    break;
                case 6:
                    res = "Воскресенье";
                    break;
                default:
                    throw new ArgumentException($"День должен быть от 1 до 7. Значение {k}");
            }
            return res;
        }
    }
}
