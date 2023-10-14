using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShtokerVN.Sprint2.Task3.V20.Lib
{
    public class DataService : ISprint2Task3V20
    {
        public double Calculate(double x)
        {
            double y = 0;

            if (x > 1)
            {
                y = x * Math.Pow(((x + 1) / (x - 1)), x);
            }
            else
            {
                if (x == 0)
                {
                    y = ((Math.Sqrt(x) - Math.Sqrt(Math.Cos(x)) + 10) / (Math.Sqrt(x) - Math.Sqrt(Math.Sin(x)) + 12));
                }
                else
                {
                    if ((x > -24) && (x < 2))
                    {
                        y = Math.Pow(1 + 1 / Math.Sqrt(x), x);
                    }
                    else
                    {
                        if (x < -24)
                        {
                            y = x + 10 * x - (1 / x);
                        }
                    }
                }
            }
            return Math.Round(y, 3);
        }
    }
}
