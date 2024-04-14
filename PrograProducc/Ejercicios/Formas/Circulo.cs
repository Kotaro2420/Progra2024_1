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
            return Math.PI * Math.Pow(radioCirculo, 2);
        }
    }
}
