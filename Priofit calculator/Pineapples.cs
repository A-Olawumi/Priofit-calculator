using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priofit_calculator
{
    /// <summary>
    /// this class inherited the class profit and it makes use of 
    /// this propfit formular to calculate profit made on pineapples with a little extension
    /// </summary>
    internal class Pineapples : Profit
    {
        public double CostOfGoods { get; set; }
        public int SalesOfGoods { get; set; }
        public override double Calc()
        {
            return (SalesOfGoods - CostOfGoods) / 2;
        }
    }
}
