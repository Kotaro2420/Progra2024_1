using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograProducc.Semana2.ArmasInventario
{
    public abstract class Arma
    {
        public string Nombre { get; protected set; }
        public int Daño { get; protected set; }
        public double VelocidadAtaque { get; protected set; }
        public int Precio { get; protected set; }

        public Arma(string nombre, int daño, double velocidadAtaque, int precio)
        {
            Nombre = nombre;
            Daño = daño;
            VelocidadAtaque = velocidadAtaque;
            Precio = precio;
        }

        public abstract double CalcularDañoPorSegundo();
    }
}
