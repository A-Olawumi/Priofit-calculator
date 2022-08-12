using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priofit_calculator
{
    /// <summary>
    /// this is an abstract class that has the properties to calculate the profit formular
    /// </summary>
    abstract class Profit
    {
        public double CostOfGoods { get; set; }
        public int SalesOfGoods { get; set; }
        public abstract double Calc();
    }
}
