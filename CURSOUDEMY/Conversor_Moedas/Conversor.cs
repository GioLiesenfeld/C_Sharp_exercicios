using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Course
{
    internal class Conversor
    {
        public static double ValorTotal(double cotacao, double dolares)
        {
            double ValorReais = cotacao * dolares;
            double iof = ValorReais * 0.06;
            return ValorReais + iof;
        }
        


    }
    
}
