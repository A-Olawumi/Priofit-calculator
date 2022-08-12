using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priofit_calculator
{
    /// <summary>
    /// this shows the calculation of the profit of each goods
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
           Pineapples pinapples = new Pineapples();
            pinapples.CostOfGoods = 500;
            pinapples.SalesOfGoods = 600;
            Oranges orange = new Oranges();
            orange.CostOfGoods = 200;
            orange.SalesOfGoods = 700;
            Console.WriteLine($"The total profit for pineapples is {pinapples.Calc()} and oranges are {orange.Calc()}");
            Console.ReadLine();
        }
    }
}
