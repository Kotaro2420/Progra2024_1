using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograProducc.Semana2.ArmasInventario
{
    public class ArmaDistancia : Arma
    {
        public Proyectil Proyectil { get; private set; }

        public ArmaDistancia(string nombre, int daño, double velocidadAtaque, int precio, Proyectil proyectil)
            : base(nombre, daño, velocidadAtaque, precio)
        {
            Proyectil = proyectil;
        }

        public override double CalcularDañoPorSegundo()
        {
            return (Daño + Proyectil.Daño) / VelocidadAtaque;
        }
    }
}
