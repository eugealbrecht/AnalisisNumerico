using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public class Biseccion
    {
        public string Funcion { get; set; }
        public int Iteraciones = 100;
        public double Tolerancia = 0.0001;
        public float LimiteIzquierdo { get; set; }
        public float LimiteDerecho { get; set; }
        public int Contador { get; set; }
        public int Xr { get; set; }
        public float Error { get; set; }
        public float Xant { get; set; }


        public Salida RetornarValores(string funcion,  int extremoderecho, int extremoizquierdo)
        {
            string mensaje = "";
            if (funcion != "")
            {
                if (funcion[extremoderecho] * funcion[extremoizquierdo] == 0)
                {
                    if (funcion[extremoizquierdo] == 0)
                    {
                        mensaje = "Extremo izquierdo es la raiz";
                        return mensaje;
                        
                    }
                    else
                    {
                        mensaje = "Extremo derecho es la raiz";
                        return mensaje;
                    }
                }
                else if (funcion[extremoderecho] * funcion[extremoizquierdo] < 0)
                {
                    int contador = 0;
                    int Xant = 0;
                    Xr = ((extremoderecho + extremoizquierdo) / 2);
                    contador = contador + 1;
                    Error = ((Xr - Xant) / Xant); //ACA IRIA EL ABS
                    if ((funcion[Xr] < Tolerancia) || contador > Iteraciones || Error < Tolerancia)// ACA IRIA EL ABS
                    {
                        mensaje = "Xr es la Raiz";
                        return mensaje;
                    }
                    else if (funcion[extremoizquierdo] *funcion[Xr]<0)
                    {
                        extremoderecho = Xr;
                    }
                    else
                    {
                        extremoizquierdo = Xr;
                    }
                    Xant = Xr;
                    //ACA SE VOLVERIA A SACAR XR
                }
                else if (funcion[extremoderecho] * funcion[extremoizquierdo] > 0)
                {
                    break; //ACA SE TENDRIA QUE VOLVER A PEDIR LOS EXTREMOS
                }
            }
        }

    }
}
