using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public class ReglaFalsa
    {
        public ReglaFalsa()
        {

        }
        public static double f(double x)
        {
            //double e = 2.71828;
            // return ((x * x * x * x * x - 1) * (e * x) - 10);
            return ((12.5 * (x + 2)) / (x * x + 4 * x + 5)) + 2;

        }
        public Salida MReglaFalsa(double extremoizquierdo, double extremoderecho)
        {
            Salida salida = new Salida();
            double xr = 0;
            int contador = 0;
            double Xant = 0;
            double Error = 0;
            int Iteraciones = 100;
            double Tolerancia = 0.0001;
            double resultado = 0;
            resultado = f(extremoizquierdo) * f(extremoderecho);
            if (resultado > 0)
            {
                salida.ErrorMsje = ("No se cumple que f(extremoderecho)*f(extremoizquierdo) < 0");
            }
            if (resultado == 0)
            {
                if (f(extremoizquierdo) == 0)
                {
                    salida.ErrorMsje = ("El extremo izquierdo es la raiz");
                    salida.ErrorRelativo = 0;
                    salida.NroIteraciones = contador;

                }
                else if (f(extremoderecho) == 0)
                {
                    salida.ErrorMsje = ("El extremo derecho es la raiz");
                    salida.ErrorRelativo = 0;
                    salida.NroIteraciones = contador;

                }
            }
            if (resultado < 0)
            {

                do
                {
                    xr = (((f(extremoizquierdo) * extremoderecho) - (f(extremoderecho) * extremoizquierdo))) / (f(extremoizquierdo) - f(extremoderecho));
                    contador = contador + 1;
                    Error = Math.Abs((xr - Xant) / xr);

                    if (Math.Abs(f(xr)) < Tolerancia | contador > Iteraciones | Error < Tolerancia)
                    {
                        salida.Raiz = xr;
                        salida.ErrorRelativo = Error;
                        salida.NroIteraciones = contador;
                    }
                    else if (f(extremoizquierdo) * f(extremoderecho) < 0)
                    {
                        extremoizquierdo = xr;
                    }
                    else
                    {
                        extremoderecho = xr;
                    }
                    Xant = xr;
                } while (Error > Tolerancia && contador <= Iteraciones);
            }
            return salida;
        }

    }
}