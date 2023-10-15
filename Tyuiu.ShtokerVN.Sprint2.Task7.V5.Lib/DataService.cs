using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShtokerVN.Sprint2.Task7.V5.Lib
{
    public class DataService : ISprint2Task7V9
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((Math.Pow(x, 2) <=y) && ((x <= 0) && (x >= 0) && (y <= 1) && (x <= 1)))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
