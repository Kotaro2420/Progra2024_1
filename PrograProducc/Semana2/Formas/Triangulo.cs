using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograProducc.Semana2.Formas
{
    public class Triangulo : Figura
    {
        private double baseTriangulo;
        private double alturaTriangulo;

        // Constructor
        public Triangulo(double baseTriangulo, double alturaTriangulo)
        {
            this.baseTriangulo = baseTriangulo;
            this.alturaTriangulo = alturaTriangulo;
        }

        // Implementación del método abstracto para calcular el área del triángulo
        public override double CalcularArea()
        {
            return (baseTriangulo * alturaTriangulo) / 2;
        }
    }
}
