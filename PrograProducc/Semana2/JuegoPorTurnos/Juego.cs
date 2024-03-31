using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Juego
{
    private Jugador jugador;
    private List<Enemigo> enemigos;

    public Juego(Jugador jugador, List<Enemigo> enemigos)
    {
        this.jugador = jugador;
        this.enemigos = enemigos;
    }

    public void Jugar()
    {
        bool jugadorVivo = true;
        bool enemigosVivos = true;

        while (jugadorVivo && enemigosVivos)
        {
            // Turno del jugador
            Console.WriteLine("Es el turno del jugador.");
            foreach (Enemigo enemigo in enemigos)
            {
                if (enemigo.Vivo)
                {
                    enemigo.RecibirDaño(jugador.ObtenerDaño());
                    Console.WriteLine("El jugador ataca al enemigo. Vida del enemigo: " + enemigo.Vida);
                }
            }

            // Turno de los enemigos
            Console.WriteLine("Es el turno de los enemigos.");
            foreach (Enemigo enemigo in enemigos)
            {
                if (enemigo.Vivo)
                {
                    jugador.RecibirDaño(enemigo.ObtenerDaño());
                    Console.WriteLine("El enemigo ataca al jugador. Vida del jugador: " + jugador.Vida);
                }
            }

            jugadorVivo = jugador.Vida > 0;
            enemigosVivos = false;
            foreach (Enemigo enemigo in enemigos)
            {
                if (enemigo.Vivo)
                {
                    enemigosVivos = true;
                    break;
                }
            }
        }

        if (!jugadorVivo)
        {
            Console.WriteLine("¡Derrota! El jugador ha sido derrotado.");
        }
        else
        {
            Console.WriteLine("¡Victoria! Todos los enemigos han sido derrotados.");
        }
    }
}

