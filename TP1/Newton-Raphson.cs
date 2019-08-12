using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Newton_Raphson
    {
        public static double f(double x)
        {
            return (x * x);

        }
        public static string NewtonRaphson (double xi, double tolerancia)
        {
            double x = xi;
            double c = 0;
            var itermax = 100;
            double error = 0;
            double derivada;
            double xr;
            double xant = 0;
            while ((f(x) > tolerancia) | (c > itermax) | (error < tolerancia))
            {
                c = c + 1;
                derivada = ((f(x + tolerancia) - f(x)) / (tolerancia));
                xr = x - (f(x) / derivada);
                error = (Math.Abs(xr - xant) / xr);
                if (f(x) <= tolerancia)
                {
                    return x + "   El número de iteraciones realizadas es:" + c;

                }

                xant = x;
                x = xr;
            }
            return "";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("La raiz aproximada es: " + NewtonRaphson(0, 0.0001));
            Console.ReadKey();
        }
    }
}