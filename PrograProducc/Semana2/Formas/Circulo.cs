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

        // Constructor
        public Circulo(double radioCirculo)
        {
            this.radioCirculo = radioCirculo;
        }

        // Implementación del método abstracto para calcular el área del círculo
        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(radioCirculo, 2);
        }
    }
}
