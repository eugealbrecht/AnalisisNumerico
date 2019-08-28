using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public class Secante
    {
        public static double f(double x)
        {
            return Math.Log(x) + (1 / x) - 3;
        }


        public void MetodoSecante(double x1, double x2)
        {
            double xant, error;
            int itermax = 100;
            double tolerancia = 0.001;
            double c = 0;
            double xr = 0;
            
            if (f(x1) == 0)
                Console.WriteLine("La raiz es: " + x1);
            else
            {
                if (f(x2) == 0)
                    Console.WriteLine("La raíz es: " + x2);
                else
                {
                    xant = 0;

                    do
                    {


                        c = c + 1;
                        xr = ((f(x2) * x1) - (f(x1) * x2)) / (f(x2) - f(x1));
                        error = Math.Abs((xr - xant) / xr);

                        x1 = x2;
                        x2 = xr;
                        xant = xr;



                    } while ((Math.Abs(f(xr)) > tolerancia) && (c < itermax));
                }

                Console.WriteLine("La raíz es: " + xr + " - Cantidad de iteraciones: " + c);

            }

        }

        
    }


}
