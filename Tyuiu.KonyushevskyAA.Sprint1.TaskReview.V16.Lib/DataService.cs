using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KonyushevskyAA.Sprint1.TaskReview.V16.Lib
{
    public class DataService : ISprint1Task7V16
    {
        public double Calculate(double x)
        {
            double res = Math.Sin(Math.Sqrt(x * x)) + (Math.Cos(x * x) / (3 * Math.Pow(x, 3))) - Math.Sin(Math.Sqrt(x * x - 1));
            res = Math.Round(res, 3);
            return res;
        }
    }
}
