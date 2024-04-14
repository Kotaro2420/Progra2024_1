using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograProducc.Semana2
{
    abstract class Personaje
    {
        public string Nombre { get; set; }
        public int Fuerza { get; set; }
        public int Destreza { get; set; }
        public int Vida { get; set; }

        public abstract void Crear();
    }
}
