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
            return Math.Log(x) + (1 / x) - 3;

        }

        public static void NewtonRaphson(double xi)
        {
            double c = 0;
            var itermax = 100;
            double error = 0;
            double derivada;
            double xr = 0;
            double xant = 0;
            double tolerancia = 0.0001;

            if (f(xi) == 0)
            {
                Console.WriteLine("La raíz es: " + xi + " - Cantidad de iteraciones: " + c);
            }
            else
            {
                xant = 0;

                do
                {

                    derivada = ((f(xi + tolerancia) - f(xi))) / tolerancia;
                    xr = xi - (f(xi) / derivada);
                    error = Math.Abs(xr - xant) / xr;

                    c = c + 1;
                    xi = xr;
                    xant = xr;


                } while ((Math.Abs(f(xr)) > tolerancia) && (c < itermax));

                Console.WriteLine("La raíz es: " + xr + " - Cantidad de iteraciones: " + c);

            }

        }

        static void Main(string[] args)
        {
            NewtonRaphson(4);
            Console.ReadKey();

        }

    }
}