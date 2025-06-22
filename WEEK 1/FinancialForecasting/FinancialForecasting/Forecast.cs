using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialForecasting
{
    public static class Forecast
    { 
        public static double CalFutureValue(double p, double r, int n)
        {
            if (n == 0)
                return p;

            return CalFutureValue(p * (1 + r), r, n - 1);
        }
    }
}
