using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograProducc.Semana2.Formas
{
    public class Cuadrado : Figura
    {
        private double ladoCuadrado;
        public Cuadrado(double ladoCuadrado)
        {
            this.ladoCuadrado = ladoCuadrado;
        }

        public override double CalcularArea()
        {
            return ladoCuadrado * ladoCuadrado;
        }
    }

}
