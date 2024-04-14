using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograProducc.Semana2
{
    class Guerrero : Personaje
    {
        public override void Crear()
        {
            Console.WriteLine("¡Bienvenido, guerrero! Por favor, crea tu personaje:");

            Console.Write("Nombre: ");
            Nombre = Console.ReadLine();

            Console.Write("Fuerza (máx. 100): ");
            Fuerza = int.Parse(Console.ReadLine());

            Console.Write("Destreza (máx. {0}): ", 100 - Fuerza);
            Destreza = int.Parse(Console.ReadLine());

            Vida = 100 - Fuerza - Destreza;
            Console.WriteLine("Vida restante: {0}", Vida);
        }
    }
}
