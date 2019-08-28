using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public class Secante
    {
        public Secante()
        {

        }

        public static double f(double x)
        {
            return Math.Log(x) + (1 / x) - 3;
        }


        public Salida MetodoSecante(double x1, double x2)
        {
            double xant, error;
            int itermax = 100;
            double tolerancia = 0.001;
            double c = 0;
            double xr = 0;
            error = 0;

            Salida salida = new Salida();

            if (f(x1) == 0)
            {
                salida.Raiz = x1;
                salida.ErrorRelativo = 0;
                salida.NroIteraciones = c;
            }
            else
            {
                if (f(x2) == 0)
                {
                    salida.Raiz = x2;
                    salida.ErrorRelativo = 0;
                    salida.NroIteraciones = c;
                }
                    
               // Console.WriteLine("La raíz es: " + x2);
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

                salida.Raiz = xr;
                salida.ErrorRelativo = error;
                salida.NroIteraciones = c;

            }

            return salida;
        }
        

    }

    


}
