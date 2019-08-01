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
        //public decimal Tolerancia = 
        public float LimiteIzquierdo { get; set; }
        public float LimiteDerecho { get; set; }
        public int Contador { get; set; }
        public float Xr { get; set; }
        public float Error { get; set; }
        public float Xant { get; set; }

    }
}
