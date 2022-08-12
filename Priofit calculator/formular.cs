using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priofit_calculator
{
    /// <summary>
    /// This is a method that calculates the total profit from a list of goods, the try catch is used to avoid the crshing of the software
    /// </summary>
    internal class formular
    {
        double Totalprofit(List<Profit> profits)
        {
            try
            {
                double totalprofit = 0;
                foreach (var profit in profits)
                {
                    totalprofit += profit.Calc();
                }
                return totalprofit;
            }
            catch (Exception a)
            {

                Console.WriteLine("This is an error");
                return 0;
            }
        }
    }
}
