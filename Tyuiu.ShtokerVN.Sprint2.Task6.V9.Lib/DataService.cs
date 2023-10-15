using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShtokerVN.Sprint2.Task6.V9.Lib
{
    public class DataService : ISprint2Task6V9
    {
        public string FindDateOfNextDay(int m, int n)
        {
            int Day = 0;
            int Month;
            
            if ((m == 1) || (m == 3) || (m == 5) || (m == 7) || (m == 8) || (m == 10) || (m == 12))
            {
                switch (n)
                {
                    case 31: Day = 1; break;
                    default: Day = n + 1; break;
                }
            }
            if ((m == 4) || (m == 6) || (m == 9) || (m == 11))
            {
                switch (n)
                {
                    case 30: Day = 1; break;
                    default: Day = n + 1; break;
                }
            }
            if ((m == 2))
            {
                switch (n)
                {
                    case 28: Day = 1; break;
                    default: Day = n + 1; break;
                }
            }
            switch (Day)
            {
                case 1: Month = m + 1; break;
                default: Month = m; break;
            }

            string MonthFinal;
            switch (Month)
            {
                case 1: MonthFinal = "Январь"; break;
                case 2: MonthFinal = "Февраль"; break;
                case 3: MonthFinal = "Март"; break;
                case 4: MonthFinal = "Апрель"; break;
                case 5: MonthFinal = "Май"; break;
                case 6: MonthFinal = "Июнь"; break;
                case 7: MonthFinal = "Июль"; break;
                case 8: MonthFinal = "Август"; break;
                case 9: MonthFinal = "Сентябрь"; break;
                case 10: MonthFinal = "Октябрь"; break;
                case 11: MonthFinal = "Ноябрь"; break;
                case 12: MonthFinal = "Декабрь"; break;

                default: throw new ArgumentException($"Месяц должен быть от 1 до 12. Введенное значение {n}");
            }
            Console.WriteLine("Следующий день:");
            string Date = $"Месяц: {MonthFinal}\nДата: {Day}";
            return Date;








        }
    }
}
