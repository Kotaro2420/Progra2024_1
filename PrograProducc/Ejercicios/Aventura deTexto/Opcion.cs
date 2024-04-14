using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograProducc.Semana2
{
    class Opcion : IOpcion
    {
        public string Texto { get; set; }
        public int RequerimientoFuerza { get; set; }
        public int RequerimientoDestreza { get; set; }
        public int Daño { get; set; }

        public Opcion(string texto, int requerimientoFuerza, int requerimientoDestreza, int daño)
        {
            Texto = texto;
            RequerimientoFuerza = requerimientoFuerza;
            RequerimientoDestreza = requerimientoDestreza;
            Daño = daño;
        }

        public void Ejecutar(Personaje jugador)
        {
            if (jugador.Fuerza >= RequerimientoFuerza && jugador.Destreza >= RequerimientoDestreza)
            {
                jugador.Vida -= Daño;
            }
            else
            {
                Console.WriteLine("No cumples con los requisitos para seleccionar esta opción.");
            }
        }

        public override string ToString()
        {
            return Texto;
        }
    }
}
