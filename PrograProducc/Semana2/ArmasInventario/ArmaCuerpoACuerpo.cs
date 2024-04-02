using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograProducc.Semana2.ArmasInventario
{
    public class ArmaCuerpoACuerpo : Arma
    {
        public ArmaCuerpoACuerpo(string nombre, int daño, double velocidadAtaque, int precio)
            : base(nombre, daño, velocidadAtaque, precio)
        {
        }

        public override double CalcularDañoPorSegundo()
        {
            return Daño / VelocidadAtaque;
        }
    }
}
