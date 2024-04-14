using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program_JuegoPorTurnos
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese la vida del jugador:");
        int vidaJugador = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el daño del jugador:");
        int dañoJugador = int.Parse(Console.ReadLine());
        Jugador jugador = new Jugador(vidaJugador, dañoJugador);

        List<Enemigo> enemigos = new List<Enemigo>();
        enemigos.Add(new EnemigoMelee(50, 10));
        enemigos.Add(new EnemigoMelee(40, 15));
        enemigos.Add(new EnemigoRango(60, 20, 5));

        Juego juego = new Juego(jugador, enemigos);
        juego.Jugar();
    }
}
