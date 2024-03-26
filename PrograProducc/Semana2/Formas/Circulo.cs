using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograProducc.Semana2.Formas
{
    public class Circulo : Figura
    {
        private double radioCirculo;

        public Circulo(double radioCirculo)
        {
            this.radioCirculo = radioCirculo;
        }

        public override double CalcularArea()
        {
            const double pi = 3.14;
            return pi * radioCirculo * radioCirculo;
        }
    }
}
