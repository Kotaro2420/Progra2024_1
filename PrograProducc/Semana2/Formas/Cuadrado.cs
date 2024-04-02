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

        // Constructor
        public Cuadrado(double ladoCuadrado)
        {
            this.ladoCuadrado = ladoCuadrado;
        }

        // Implementación del método abstracto para calcular el área del cuadrado
        public override double CalcularArea()
        {
            return ladoCuadrado * ladoCuadrado;
        }
    }
}
