using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public class ReglaFalsa
    {
        public static double f(double x)
        {
            return -(x * x) - (2 * x) + 1;
        }
        static void Main(string[] args)
        {

            double extremoderecho = 0, extremoizquierdo = 0, xr = 0;
            Console.WriteLine("Ingrese extremo derecho");
            string d = Console.ReadLine();
            extremoderecho = double.Parse(d);

            Console.WriteLine("Ingrese extremo izquierdo");
            string i = Console.ReadLine();
            extremoizquierdo = double.Parse(i);

            int contador = 0;
            double Xant = 0;
            double Error;
            int Iteraciones = 100;
            double Tolerancia = 0.0001;
            if (f(extremoderecho) * f(extremoizquierdo) > 0)
            {
                Console.WriteLine("No se cumple que f(extremoderecho)*f(extremoizquierdo)<0");
                Console.ReadKey();
                return;
            }
            while (1 > 0)
            {
                xr = (((f(extremoizquierdo) * extremoderecho) - (f(extremoderecho) * extremoizquierdo)) / (f(extremoizquierdo) * f(extremoderecho)));
                contador = contador + 1;
                Error = ((xr - Xant) / Xant);
                if (Math.Abs(f(xr)) < Tolerancia | contador > Iteraciones | Error < Tolerancia)
                {
                    Console.WriteLine("La raiz aproximada es r= " + xr);
                    Console.WriteLine("El valor de f en r= " + f(xr));
                    Console.WriteLine("El error relativo es= ", Error);
                    Console.WriteLine("La cantidad de iteraciones que se realizaron fueron= ", contador);
                    Console.ReadKey();
                    return;
                }
                if (f(extremoderecho) * f(extremoizquierdo) < 0)
                {
                    extremoizquierdo = xr;
                }
                else
                {
                    extremoderecho = xr;
                }
                Xant = xr;
            }
        }

    }
}
