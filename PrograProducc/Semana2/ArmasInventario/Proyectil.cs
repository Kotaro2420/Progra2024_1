using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograProducc.Semana2.ArmasInventario
{
    public class Proyectil
    {
        public string Nombre { get; private set; }
        public int Daño { get; private set; }

        public Proyectil(string nombre, int daño)
        {
            Nombre = nombre;
            Daño = daño;
        }
    }
}
