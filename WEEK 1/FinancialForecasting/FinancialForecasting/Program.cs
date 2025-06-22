using System;

namespace FinancialForecasting
{
    class Program
    {
        static void Main(string[] args)
        {
            double p = 250000;    //principle 
            double r = 0.08;     //rate    
            int n = 4;          //years

            double futureValue = Forecast.CalFutureValue(p, r, n);

            Console.WriteLine($"Future value after {n} years: Rs. {futureValue:F2}");
        }
    }
}
