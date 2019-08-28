using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public class Newton_Raphson
    {
        public static double f(double x)
        {
            return Math.Log(x) + (1 / x) - 3;

        }

        public Salida NewtonRaphson(double xi)
        {
            double c = 0;
            var itermax = 100;
            double error = 0;
            double derivada;
            double xr = 0;
            double xant = 0;
            double tolerancia = 0.0001;

            Salida salida = new Salida();

            if (f(xi) == 0)
            {
                salida.ErrorRelativo = 0;
                salida.Raiz = xi;
                salida.NroIteraciones = c;
                
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

                salida.Raiz = xr;
                salida.NroIteraciones = c;
                salida.ErrorRelativo = error;
                
            }

            return salida;

        }

      
    }
}